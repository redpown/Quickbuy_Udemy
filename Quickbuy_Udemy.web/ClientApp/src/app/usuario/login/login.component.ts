import { Component, OnInit } from "@angular/core";
import { Usuarios } from "../../modelo/Usuarios";
import { Router, ActivatedRoute } from "@angular/router";


@Component({
  selector: "app-login",/* aqui e a tag html do component*/
  templateUrl: "./login.component.html",
  styleUrls: ['./login.component.css']
})
//acho q a versao 6 do angular cli nao aceita
//export class ProdutoComponent extends Component {
//tudo que precisa ser inicializado usar a clase OnInit
export class LoginComponent implements OnInit {
  public usuarios;
  public usuariologado: boolean;

  constructor(private router: Router, private activatedRouter: ActivatedRoute) {
  
  }

  public returnUrl: string;

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
  //ngOnInit vem da clase OnInit
  ngOnInit(): void {
    this.usuarios = new Usuarios();
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
  }

  login() {
    if (this.usuarios.email != "" && this.usuarios.senha != "") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]);
    } //else {
     // this.usuariologado = false;
   // }

    // alert(this.usuarios.email + this.usuarios.senha);
  }

}
