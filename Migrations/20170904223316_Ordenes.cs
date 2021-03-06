﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace hki.web.Migrations
{
    public partial class Ordenes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Asignado = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dia = table.Column<int>(type: "int", nullable: false),
                    Estatus2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estatus3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaReq = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Finalizadas = table.Column<int>(type: "int", nullable: false),
                    Levantamiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Terminado = table.Column<bool>(type: "bit", nullable: false),
                    TotalHrs = table.Column<float>(type: "real", nullable: false),
                    Ubicacion = table.Column<int>(type: "int", nullable: false),
                    UltModificacion = table.Column<int>(type: "int", nullable: false),
                    Validada = table.Column<bool>(type: "bit", nullable: false),
                    ValorHrs = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Piezas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estatus = table.Column<int>(type: "int", nullable: false),
                    Levantamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nomina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Orden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preparado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Surtido = table.Column<TimeSpan>(type: "time", nullable: false),
                    Surtir = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Terminado = table.Column<bool>(type: "bit", nullable: false),
                    Ubicacion = table.Column<int>(type: "int", nullable: false),
                    UltimaModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piezas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorHrs = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ordenes");

            migrationBuilder.DropTable(
                name: "Piezas");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
