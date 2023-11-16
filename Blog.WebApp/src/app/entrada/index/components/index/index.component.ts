import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { Entrada } from '../../../../core/models/entrada.model';
import { EntradaMap } from '../../../../core/models/entradaMap.model';
@Component({
  selector: 'app-index-component',
  templateUrl: './index.component.html',
  styleUrl: './index.component.css',
})
export class IndexComponent implements OnChanges {
  show: boolean = true;
  buttonName = '';
  public isCollapsed = false;

  @Input() entradas?: Entrada[];
  entradasMap?: EntradaMap[];

  ngOnChanges(changes: SimpleChanges) {
    if (this.entradas != undefined) {
      this.entradasMap = this.entradas!.map<EntradaMap>((e: any) => {
        return {
          id: e.id,
          titulo: e.titulo,
          autor: e.autor,
          fechaPublicacion: e.fechaPublicacion,
          contenido: e.contenido,
          show: false,
        };
      });
      console.log('Entradas 😀', this.entradas);
      this.entradasMap = this.entradasMap.reverse();
    }
  }

  verMas() {
    this.show = false;
  }

  verMenos() {
    this.show = true;
  }
}
