import { Component, OnInit } from '@angular/core';
import { Entrada } from '../../../../core/models/entrada.model';
import { EntradaService } from '../../../../core/services/entrada.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-detalle-container',
  templateUrl: './detalle.container.html',
  styleUrl: './detalle.container.css',
})
export class DetalleContainer implements OnInit {
  id?: string | null;
  entrada?: Entrada;

  constructor(
    private route: ActivatedRoute,
    private entradaService: EntradaService
  ) {}

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id');
    this.entradaService.obtenerEntradaPorId(this.id!).subscribe((entrada) => {
      console.log('Entrada 😀', entrada);
      this.entrada = entrada;
    });
  }
}
