import { Component } from "@angular/core";
import { Usuarios } from "../../modelo/Usuarios";


@Component({
  selector: "app-login",/* aqui e a tag html do component*/
  templateUrl: "./login.component.html",
  styleUrls: ['./login.component.css']
})
//acho q a versao 6 do angular cli nao aceita
//export class ProdutoComponent extends Component {
export class LoginComponent {
  public usuarios;
  public usuariologado: boolean;

  constructor() {
    this.usuarios = new Usuarios();
  }

  public ano: Number = new Date().getFullYear();
  //referenciando atributos no html
  //precisa ser igual a baixo entre colchetes
 // [placeholder]="mascaradesenha" > <!--[placeholder]="mascaradesenha" atrbitu html = nome da funcao ou atrbuto na classe-- >
  public mascaradesenha: String = "*************";
  // com eles vazio ele pega os valores do atributo placeholder
  public teste_usuario:string = "";

  public teste_senha: string = "";

  public logados = ["Andre", "Youko", "Panda", "Uros"];

  
  public getAno(): Number {
    this.ano = 1989;
     //let anoAtual: String = year.getFullYear.toString();
    return this.ano;
  }

  public obterNome(): String {
    //return this.nome;
    return "Samsung";
  }

  login() {
   /* if (this.usuarios.email != "" && this.usuarios.senha != "") {
      this.usuariologado = true;
    } else {
      this.usuariologado = false;
    }*/

     alert(this.usuarios.email + this.usuarios.senha);
  }

}
