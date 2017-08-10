using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RPG.Migrations
{
    public partial class AddApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Players",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_ApplicationUserId",
                table: "Players",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_AspNetUsers_ApplicationUserId",
                table: "Players",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_AspNetUsers_ApplicationUserId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_ApplicationUserId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Players");
        }
    }
}
