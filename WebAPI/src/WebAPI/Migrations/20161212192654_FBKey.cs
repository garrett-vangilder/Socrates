using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class FBKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirebaseUid",
                table: "Student",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "FirebaseUid",
                table: "Educator",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FirebaseUid",
                table: "Student",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "FirebaseUid",
                table: "Educator",
                nullable: false);
        }
    }
}
