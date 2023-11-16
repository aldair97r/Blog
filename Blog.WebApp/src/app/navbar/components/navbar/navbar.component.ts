import { Component, OnInit } from '@angular/core';
import { FiltroService } from '../../../core/services/filtro.service';
import { NavigationStart, Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css',
})
export class NavbarComponent implements OnInit {
  show: boolean = true;
  constructor(private filtroService: FiltroService, private router: Router) {
    this.router.events.subscribe((val) => {
      if (val instanceof NavigationStart) {
        if (val.url.toString() == '/entradas' || val.url.toString() == '/') {
          this.show = true;
        } else {
          this.show = false;
        }
      }
    });
  }
  filtro?: string = '';

  ngOnInit(): void {
    this.filtrar();
  }

  filtrar() {
    this.filtroService.setObservableValue(this.filtro);
  }
}
