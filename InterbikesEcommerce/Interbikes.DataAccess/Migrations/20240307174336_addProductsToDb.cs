using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Interbikes.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "BICICLETA GTSM1 RIDE FEMININA É IDEAL PARA MULHERES QUE QUEREM COMEÇAR A PEDALAR, FAZER MUITOS PASSEIOS E UTILIZAR NO DIA-A-DIA. SÃO 2 TIPOS DE TAMANHOS DE QUADRO E 3 CORES PARA VOCÊ ESCOLHER, O PESO TOTAL DA BIKE É DE 15KG MONTADA. A BIKE É DIRETA DA FÁBRICA OFICIAL GTS M1 COM MAIS DE 28 ANOS NO MERCADO E GARANTIA EXCLUSIVA COM SUPORTE DIFERENCIADO. A BICICLETA SUPORTA UMA PESSOA DE ATÉ 100KGS.", "Bicleta Feminina Aro 29 GTS Freio a Disco Quadro 15", 989.10000000000002 },
                    { 2, "Quadro 29 A6061 KSW XLT 100 Alumínio. Abraçadeira Quadro c/ Blocagem 31.8 Alumínio. Suporte de Guidão 80mmx31.8x7mm Alumínio. Canote Selim 27.2x350 sem Carrinho. Guidão Mtb 680x31.8x30mm Alumínio.", "Bicicleta Aro 29 Ksw 21 Marchas Alumínio Cambio Shimano Freio a Disco", 969.89999999999998 },
                    { 3, "Terra, lama, descidas, subidas, galhos, pedras, saltos e curvas apertadas... são obstáculos que você enfrentará em seus passeios e trilhas, seja você um ciclista por hobby ou profissional. A Bicicleta modelo Legend, da marca South Bike e tipo Mountain Bike foi feita pensando em você aventureiro! Ela é aro 29, conta com um freio a disco garantindo conforto e segurança e 21 marchas para maior aproveitamento de suas pedaladas. Seu câmbio é Shimano (TZ dianteiro e traseiro) e seu diferencial fica por conta de sua suspensão dianteira com 60 mm de curso.", "Bicicleta South Legend Aro 29 Shimano Alumínio - Mountain Bike Freio a Disco 21 Marchas", 1.399 },
                    { 4, "Terra, lama, descidas, subidas, galhos, pedras, saltos e curvas apertadas... são obstáculos que você enfrentará em seus passeios e trilhas, seja você um ciclista por hobby ou profissional. A Bicicleta modelo Legend, da marca South Bike e tipo Mountain Bike foi feita pensando em você aventureiro! Ela é aro 29, conta com um freio a disco garantindo conforto e segurança e 21 marchas para maior aproveitamento de suas pedaladas. Seu câmbio é Shimano (TZ dianteiro e traseiro) e seu diferencial fica por conta de sua suspensão dianteira com 60 mm de curso.", "Bicicleta South Legend Preto com Verde Aro 29 Shimano Alumínio - Mountain Bike Freio a Disco 21 Marchas", 1.399 },
                    { 5, "Bicicleta South Legend Preto com Verde Aro 29 Shimano Alumínio - Mountain Bike Freio a Disco 21 Marchas", "Bicicleta South Legend Preto com Rosa com Verde Aro 29 Quadro 15 Shimano Alumínio - Mountain Bike Freio a Disco 21 Marchas", 1.399 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
