import { Component, Input } from '@angular/core';
import { Entrada } from '../../../../core/models/entrada.model';

@Component({
  selector: 'app-detalle-component',
  templateUrl: './detalle.component.html',
  styleUrl: './detalle.component.css',
})
export class DetalleComponent {
  @Input() entrada?: Entrada;
}
