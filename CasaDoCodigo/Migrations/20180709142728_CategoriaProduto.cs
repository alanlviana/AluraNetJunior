﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CasaDoCodigo.Migrations
{
    public partial class CategoriaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Produto",
                nullable: false,
                defaultValue: 0);
                 
            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            */
            // Foi necessário criar a coluna já com a foreign key, o SQLite não tem suporte a adição posterior de constraints
            migrationBuilder.Sql("ALTER TABLE Produto ADD COLUMN CategoriaId integer REFERENCES Categoria(Id)");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /* 
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto");
            */
            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Produto");
        }
    }
}
