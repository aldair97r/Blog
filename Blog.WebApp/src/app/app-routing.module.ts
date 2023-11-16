import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'entradas',
    loadChildren: () => import('./entrada/entrada.module').then((m) => m.EntradaModule)
  },
  {
    path: '**',
    redirectTo: 'entradas'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
