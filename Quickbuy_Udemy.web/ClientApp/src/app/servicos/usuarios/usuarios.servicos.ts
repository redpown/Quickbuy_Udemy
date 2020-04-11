import { Injectable,Inject} from "@angular/core";
import {HttpClient,HttpHeaders } from "@angular/common/http";
import {Observable} from "rxjs";
import { Usuarios } from "../../modelo/Usuarios";
import { Session } from "protractor";

@Injectable({
  providedIn: 'root'
})

//com o @Injectable ele permite usar objetos o variaveis de qualquer lugar do projeto
// tm colocar no  providers: [UsuariosServicos], em app.module.ts

export class UsuariosServicos {

  private baseURL: string;

  private _usuarios: Usuarios;

  get usuario(): Usuarios {
    let usuario_json = sessionStorage.getItem("usuario-autenticado");
    this._usuarios = JSON.parse(usuario_json);
    return this._usuarios
   
  }

  set usuario(usuario: Usuarios) {
    sessionStorage.setItem("usuario-autenticado", JSON.stringify(usuario));
    this._usuarios = usuario; 
  }//toda vez que é feita uma tribuicao(=) e feito  um set

  public usuario_autenticado(): boolean {
    return this._usuarios != null && this._usuarios.email != "" && this._usuarios.senha != "";
  }

  public limpar_session() {
    sessionStorage.setItem("usuario-autenticado", "");
    this._usuarios = null;
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public verificaUsuario(usuarios: Usuarios): Observable<Usuarios> {

    const headers = new HttpHeaders().set('content-type', 'application/json');

    var body = { email: usuarios.email, senha: usuarios.senha }

    return this.http.post<Usuarios>(this.baseURL + "api/usuarios/VerificarUsuario", body, { headers })
  }
}
