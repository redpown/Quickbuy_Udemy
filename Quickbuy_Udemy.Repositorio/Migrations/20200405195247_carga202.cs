using Microsoft.EntityFrameworkCore.Migrations;

namespace Quickbuy_Udemy.Repositorio.Migrations
{
    public partial class carga202 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormaPagamentos",
                columns: new[] { "Id", "Descricao", "IsBoleto", "IsCartaoDeCredito", "IsDeposito", "IsNaoDefinido", "Nome" },
                values: new object[,]
                {
                    { 1, "Forma de pagamento Boleto.", true, false, false, false, "Boleto" },
                    { 2, "Forma de pagamento Cartão.", false, true, false, false, "Cartão" },
                    { 3, "Forma de pagamento Deposito.", false, false, true, false, "Deposito" },
                    { 4, "Forma de pagamento Dinheiro.", false, false, false, false, "Dinheiro" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormaPagamentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormaPagamentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormaPagamentos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FormaPagamentos",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
