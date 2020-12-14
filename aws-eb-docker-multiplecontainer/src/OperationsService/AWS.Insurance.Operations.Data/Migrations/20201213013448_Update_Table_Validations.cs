﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AWS.Insurance.Operations.Data.Migrations
{
    public partial class Update_Table_Validations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CNumber",
                table: "Customers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNumber",
                table: "Customers");
        }
    }
}
