import { Component } from '@angular/core';

@Component({
  selector: "app-produto",/* aqui e a tag html do component*/
  templateUrl: "./produto.component.html",
  styleUrls: ['./produto.component.css']
})


/* aqui e a tag html do component*/
//acho q a versao 6 do angular cli nao aceita
//export class ProdutoComponent extends Component {
export class ProdutoComponent {


//export funciona como o public do c# ou java
  public nome: String;
//acho q a versao 6 do angular cli nao aceita
//export class ProdutoComponent extends Component {
 // selector = "produto";
//  template = "<html><body>{{ obterNome() }}</body></html>";
  public liberadoParaVenda: boolean;
  public obterNome(): String {
    //return this.nome;
    return "Samsung";
  }
}
