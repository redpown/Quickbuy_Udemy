import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";
import { UsuariosServicos } from "../servicos/usuarios/usuarios.servicos";
@Injectable({
  providedIn: 'root'
})
//permite injetar pelo construtor em qualquer classe
export class GuardaRotas implements CanActivate {
 //com o @Injectable ele permite instanciar o objeto router ja intanciado tipo Tentity da classe que ele sera usado
 //com o @Injectable ele deixa essas classe global permitindo o  constructor(private guardaRotas: GuardaRotas) { }
  constructor(private router: Router, private usuarioservico:UsuariosServicos) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
  //this.usuarioservico
    var autenticado = sessionStorage.getItem("usuario-autenticado");
    if (autenticado == "1") {
      return true;
    }

    this.router.navigate(['/login'], { queryParams: {returnUrl:state.url}});
     return false;
  }



}
