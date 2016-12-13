using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class FBCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirebaseUid",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "FirebaseUid",
                table: "Educator");

            migrationBuilder.AddColumn<string>(
                name: "FirebaseCode",
                table: "Student",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirebaseCode",
                table: "Educator",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirebaseCode",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "FirebaseCode",
                table: "Educator");

            migrationBuilder.AddColumn<string>(
                name: "FirebaseUid",
                table: "Student",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirebaseUid",
                table: "Educator",
                nullable: true);
        }
    }
}
