"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
/*
@Component({

  selector : "produto",
  template: "./produto.component.html",
  styleUrls: ['./produto.component.css']
})

*/
/* aqui e a tag html do component*/
//acho q a versao 6 do angular cli nao aceita
//export class ProdutoComponent extends Component {
var ProdutoComponent = /** @class */ (function (_super) {
    __extends(ProdutoComponent, _super);
    function ProdutoComponent() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    ProdutoComponent.prototype.ngOnInit = function () {
        this.selector = "produto";
        this.template = "./produto.component.html";
        this.styleUrls = ['./produto.component.css'];
    };
    ProdutoComponent.prototype.obterNome = function () {
        //return this.nome;
        return "Samsung";
    };
    return ProdutoComponent;
}(core_1.Component));
exports.ProdutoComponent = ProdutoComponent;
//# sourceMappingURL=produto.component.js.map