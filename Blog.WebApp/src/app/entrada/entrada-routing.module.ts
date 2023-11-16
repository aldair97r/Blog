import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IndexContainer } from './index/containers/index/index.container';
import { DetalleContainer } from './detalle/containers/detalle/detalle.container';

const routes: Routes = [
  { path: '', children:[
    { path: '', component: IndexContainer },
    { path: 'detalle/:id', component: DetalleContainer },
    {
      path: '**',
      redirectTo: ''
    }
  ] }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EntradaRoutingModule { }
