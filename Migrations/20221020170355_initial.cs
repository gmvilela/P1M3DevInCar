using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P1M3DevInCar.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TokenSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Issuer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Audience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokenSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Venda = table.Column<bool>(type: "bit", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroChassi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpfComprador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCompra = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetalheMotoTriciclo = table.Column<int>(type: "int", nullable: true),
                    DetalheCarro = table.Column<int>(type: "int", nullable: true),
                    DetalheCamionete = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Camionetes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalheCamionete = table.Column<int>(type: "int", nullable: false),
                    QtdePorta = table.Column<int>(type: "int", nullable: false),
                    CapacidadeCarregamento = table.Column<float>(type: "real", nullable: false),
                    Potencia = table.Column<float>(type: "real", nullable: false),
                    Combustivel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camionetes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Camionetes_Veiculos_DetalheCamionete",
                        column: x => x.DetalheCamionete,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalheCarro = table.Column<int>(type: "int", nullable: false),
                    QtdePorta = table.Column<int>(type: "int", nullable: false),
                    Potencia = table.Column<float>(type: "real", nullable: false),
                    Combustivel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carros_Veiculos_DetalheCarro",
                        column: x => x.DetalheCarro,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotoTriciclos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalheMotoTriciclo = table.Column<int>(type: "int", nullable: false),
                    Potencia = table.Column<float>(type: "real", nullable: false),
                    QtdeRoda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotoTriciclos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotoTriciclos_Veiculos_DetalheMotoTriciclo",
                        column: x => x.DetalheMotoTriciclo,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoVeiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    TipoDeVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVeiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoVeiculos_Veiculos_Tipo",
                        column: x => x.Tipo,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "Id", "Cor", "CpfComprador", "DataCompra", "DataFabricacao", "DetalheCamionete", "DetalheCarro", "DetalheMotoTriciclo", "Nome", "NumeroChassi", "Placa", "Tipo", "Valor", "Venda" },
                values: new object[] { 1, "Azul", null, null, new DateTime(2022, 10, 20, 14, 3, 54, 516, DateTimeKind.Local).AddTicks(676), null, null, 1, "Honda CG Titan", "9BWHE21JX24064444", "CCC1A11", 1, 10000f, false });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "Id", "Cor", "CpfComprador", "DataCompra", "DataFabricacao", "DetalheCamionete", "DetalheCarro", "DetalheMotoTriciclo", "Nome", "NumeroChassi", "Placa", "Tipo", "Valor", "Venda" },
                values: new object[] { 2, "Cinza", null, null, new DateTime(2022, 10, 20, 14, 3, 54, 524, DateTimeKind.Local).AddTicks(3094), null, 2, null, "VW Gol", "9BWHE21JX24060831", "AAA1A11", 2, 50000f, false });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "Id", "Cor", "CpfComprador", "DataCompra", "DataFabricacao", "DetalheCamionete", "DetalheCarro", "DetalheMotoTriciclo", "Nome", "NumeroChassi", "Placa", "Tipo", "Valor", "Venda" },
                values: new object[] { 3, "Branca", "11111111100", null, new DateTime(2022, 10, 20, 14, 3, 54, 524, DateTimeKind.Local).AddTicks(3796), 3, null, null, "Chevrolet S10", "9BWHE21JX24060333", "BBB1A11", 3, 100000f, true });

            migrationBuilder.InsertData(
                table: "Camionetes",
                columns: new[] { "Id", "CapacidadeCarregamento", "Combustivel", "DetalheCamionete", "Potencia", "QtdePorta" },
                values: new object[] { 1, 10000f, "Diesel", 3, 2000f, 2 });

            migrationBuilder.InsertData(
                table: "Carros",
                columns: new[] { "Id", "Combustivel", "DetalheCarro", "Potencia", "QtdePorta" },
                values: new object[] { 1, "Flex", 2, 1000f, 4 });

            migrationBuilder.InsertData(
                table: "MotoTriciclos",
                columns: new[] { "Id", "DetalheMotoTriciclo", "Potencia", "QtdeRoda" },
                values: new object[] { 1, 1, 100f, 2 });

            migrationBuilder.InsertData(
                table: "TipoVeiculos",
                columns: new[] { "Id", "Tipo", "TipoDeVeiculo" },
                values: new object[,]
                {
                    { 1, 1, "Moto/Triciclo" },
                    { 2, 2, "Carro" },
                    { 3, 3, "Camionete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Camionetes_DetalheCamionete",
                table: "Camionetes",
                column: "DetalheCamionete");

            migrationBuilder.CreateIndex(
                name: "IX_Carros_DetalheCarro",
                table: "Carros",
                column: "DetalheCarro");

            migrationBuilder.CreateIndex(
                name: "IX_MotoTriciclos_DetalheMotoTriciclo",
                table: "MotoTriciclos",
                column: "DetalheMotoTriciclo");

            migrationBuilder.CreateIndex(
                name: "IX_TipoVeiculos_Tipo",
                table: "TipoVeiculos",
                column: "Tipo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Camionetes");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "MotoTriciclos");

            migrationBuilder.DropTable(
                name: "TipoVeiculos");

            migrationBuilder.DropTable(
                name: "TokenSettings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
