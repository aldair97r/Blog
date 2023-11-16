import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'Blog.WebApp';
  filtro?: string = '';

  filtrar($event: string) {
    this.filtro = $event;
    console.log('Filtro 😀', this.filtro);
  }
}
