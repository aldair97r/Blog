import { Component, EventEmitter, Output } from '@angular/core';
import { EntradaPost } from '../../../../core/models/entradaPost.model';
import { EntradaService } from '../../../../core/services/entrada.service';

@Component({
  selector: 'app-agregar-container',
  templateUrl: './agregar.container.html',
  styleUrl: './agregar.container.css',
})
export class AgregarContainer {
  limpiarFormulario?: number;
  @Output() actualizarEntradas: EventEmitter<number> = new EventEmitter();
  constructor(private entradaService: EntradaService) {}

  agregarEntrada($event: EntradaPost) {
    this.entradaService.agregarEntrada($event).subscribe(
      (data: number) => {
        console.log('Id creado 😀', data);
        this.limpiarFormulario = data;
        this.actualizarEntradas.emit(data);
      },
      (error: any) => {
        console.error('Error😕:', error);
      }
    );
  }
}
