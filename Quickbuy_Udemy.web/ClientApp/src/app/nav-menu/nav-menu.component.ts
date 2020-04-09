import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UsuariosServicos } from '../servicos/usuarios/usuarios.servicos';
@Component({
  selector: 'app-nav-menu',/* aqui e a tag html do component*/
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  constructor(private router: Router, private usariosservicos:UsuariosServicos) { }
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  public usuarioLogado(): boolean {
    return sessionStorage.getItem("usuario-autenticado") == "1";
  }
  sair() {
    this.usariosservicos.limpar_session();
    //sessionStorage.setItem("usuario-autenticado", "");
    this.router.navigate(['/']);
  }
}
