using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspnetCoreEFCoreExample.Migrations
{
    public partial class AddedSecondModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SecondModelId",
                table: "MyModels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MySecondModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MySecondModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyModels_SecondModelId",
                table: "MyModels",
                column: "SecondModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyModels_MySecondModel_SecondModelId",
                table: "MyModels",
                column: "SecondModelId",
                principalTable: "MySecondModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyModels_MySecondModel_SecondModelId",
                table: "MyModels");

            migrationBuilder.DropTable(
                name: "MySecondModel");

            migrationBuilder.DropIndex(
                name: "IX_MyModels_SecondModelId",
                table: "MyModels");

            migrationBuilder.DropColumn(
                name: "SecondModelId",
                table: "MyModels");
        }
    }
}
