import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Entrada } from '../models/entrada.model';
import { environment } from '../../environments/environment';
import { EntradaPost } from '../models/entradaPost.model';

@Injectable({
  providedIn: 'root',
})
export class EntradaService {
  urlApi = environment.url + environment.port + /api/;

  constructor(private http: HttpClient) {}

  obtenerEntradas(filtro?: string): Observable<Entrada[]> {
    return this.http.get<Entrada[]>(this.urlApi + 'Entradas/' + filtro);
  }

  obtenerEntradaPorId(id?: string): Observable<Entrada> {
    return this.http.get<Entrada>(
      this.urlApi + 'Entradas/ObtenerEntradaPorId/' + id
    );
  }

  agregarEntrada(entrada?: EntradaPost): Observable<number> {
    return this.http.post<number>(this.urlApi + 'Entradas', entrada);
  }
}
