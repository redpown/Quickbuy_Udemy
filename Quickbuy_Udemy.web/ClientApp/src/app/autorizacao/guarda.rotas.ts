import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";
@Injectable({
  providedIn: 'root'
})

export class GuardaRotas implements CanActivate {
 //com o @Injectable ele instancia o objeto router ja intanciado tipo Tentity da classe que ele sera usado
  constructor(private router: Router) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    var autenticado = sessionStorage.getItem("usuario-autenticado");
    if (autenticado == "1") {
      return true;
    }

    this.router.navigate(['/login'], { queryParams: {returnUrl:state.url}});
     return false;
  }



}
