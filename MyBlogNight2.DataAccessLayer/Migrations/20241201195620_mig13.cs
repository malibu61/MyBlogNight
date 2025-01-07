﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlogNight2.DataAccessLayer.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleViewCount",
                table: "Articles",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleViewCount",
                table: "Articles");
        }
    }
}
