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
var ProdutoComponent = /** @class */ (function (_super) {
    __extends(ProdutoComponent, _super);
    function ProdutoComponent() {
        var _this = _super !== null && _super.apply(this, arguments) || this;
        _this.selector = "produto";
        _this.template = "<html><body>{{ obterNome() }}</body></html>";
        return _this;
    }
    ProdutoComponent.prototype.obterNome = function () {
        //return this.nome;
        return "Samsung";
    };
    return ProdutoComponent;
}(core_1.Component));
exports.ProdutoComponent = ProdutoComponent;
//# sourceMappingURL=produto.component.js.map