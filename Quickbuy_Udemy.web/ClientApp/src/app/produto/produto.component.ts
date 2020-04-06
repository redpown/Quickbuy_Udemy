import { Component } from "@angular/core";

@Component({
  selector : "produto",/* aqui e a tag html do component*/
  template : "<html><body>{{ obterNome() }}</body></html>"//,
  //styleUrls: ['./nav-menu.component.css']
})
//acho q a versao 6 do angular cli nao aceita
//export class ProdutoComponent extends Component {
export class ProdutoComponent  {
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
