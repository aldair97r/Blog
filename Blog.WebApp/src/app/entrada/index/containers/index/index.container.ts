import { Component, Input, OnInit } from '@angular/core';
import { Entrada } from '../../../../core/models/entrada.model';
import { EntradaService } from '../../../../core/services/entrada.service';
import { FiltroService } from '../../../../core/services/filtro.service';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-index-container',
  templateUrl: './index.container.html',
  styleUrl: './index.container.css',
})
export class IndexContainer implements OnInit {
  entradas?: Entrada[];
  filtro?: string = '';

  constructor(
    private entradaService: EntradaService,
    private filtroService: FiltroService,
    private spinner: NgxSpinnerService
  ) {}

  ngOnInit(): void {
    this.obtenerEntradas();

    this.filtroService.filtroUpdated.subscribe((newObsValue: string) => {
      console.log('Filtro 😀', newObsValue);
      this.filtro = newObsValue;
      this.obtenerEntradas();
    });
  }

  obtenerEntradas() {
    this.spinner.show();
    this.entradaService.obtenerEntradas(this.filtro).subscribe((entradas) => {
      this.entradas = entradas;
      this.spinner.hide();
    });
  }

  actualizarEntradas($event: number) {
    this.filtro = '';
    this.filtroService.setObservableValue(this.filtro);

    this.obtenerEntradas();
  }
}
