import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/components/index/index.component';
import { IndexContainer } from './index/containers/index/index.container';
import { EntradaRoutingModule } from './entrada-routing.module';
import { DetalleContainer } from './detalle/containers/detalle/detalle.container';
import { DetalleComponent } from './detalle/components/detalle/detalle.component';
import { AgregarComponent } from './agregar/components/agregar/agregar.component';
import { AgregarContainer } from './agregar/containers/agregar/agregar.container';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    IndexComponent,
    IndexContainer,
    DetalleContainer,
    DetalleComponent,
    AgregarComponent,
    AgregarContainer
  ],
  imports: [
    CommonModule,
    EntradaRoutingModule,
    ReactiveFormsModule,
  ]
})
export class EntradaModule { }
