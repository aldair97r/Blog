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
  constructor(private http: HttpClient) {}

  obtenerEntradas(filtro?: string): Observable<Entrada[]> {
    return this.http.get<Entrada[]>(environment.urlApi + 'Entradas/' + filtro);
  }

  obtenerEntradaPorId(id?: string): Observable<Entrada> {
    return this.http.get<Entrada>(
      environment.urlApi + 'Entradas/ObtenerEntradaPorId/' + id
    );
  }

  agregarEntrada(entrada?: EntradaPost): Observable<number> {
    return this.http.post<number>(environment.urlApi + 'Entradas', entrada);
  }
}
