import { Injectable,Inject} from "@angular/core";
import {HttpClient,HttpHeaders } from "@angular/common/http";
import {Observable} from "rxjs";
import { Usuarios } from "../../modelo/Usuarios";

@Injectable({
  providedIn: 'root'
})

//com o @Injectable ele permite usar objetos o variaveis de qualquer lugar do projeto
// tm colocar no  providers: [UsuariosServicos], em app.module.ts

export class UsuariosServicos {

  private baseURL: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public verificaUsuario(usuarios: Usuarios): Observable<Usuarios> {

    const headers = new HttpHeaders().set('content-type', 'application/json');

    var body = { email: usuarios.email, senha: usuarios.senha }

    return this.http.post<Usuarios>(this.baseURL + "api/usuarios/verificausuario", body, { headers })
  }
}
