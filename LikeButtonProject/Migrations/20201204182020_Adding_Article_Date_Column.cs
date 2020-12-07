using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LikeButtonProject.Migrations
{
    public partial class Adding_Article_Date_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "content",
                table: "tb_articles",
                type: "varchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varhcar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "tb_articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "tb_articles",
                columns: new[] { "id_article", "content", "date", "title" },
                values: new object[] { "9b06de81-77c2-4bbf-8021-a8e05ef97ec9", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "William" });

            migrationBuilder.InsertData(
                table: "tb_articles",
                columns: new[] { "id_article", "content", "date", "title" },
                values: new object[] { "11241631-ff06-437c-b860-ede5b472ef3b", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "William" });

            migrationBuilder.InsertData(
                table: "tb_articles",
                columns: new[] { "id_article", "content", "date", "title" },
                values: new object[] { "2bff555f-78d9-4cae-ab5a-ff0528b8d141", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "William" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tb_articles",
                keyColumn: "id_article",
                keyValue: "11241631-ff06-437c-b860-ede5b472ef3b");

            migrationBuilder.DeleteData(
                table: "tb_articles",
                keyColumn: "id_article",
                keyValue: "2bff555f-78d9-4cae-ab5a-ff0528b8d141");

            migrationBuilder.DeleteData(
                table: "tb_articles",
                keyColumn: "id_article",
                keyValue: "9b06de81-77c2-4bbf-8021-a8e05ef97ec9");

            migrationBuilder.DropColumn(
                name: "date",
                table: "tb_articles");

            migrationBuilder.AlterColumn<string>(
                name: "content",
                table: "tb_articles",
                type: "varhcar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldNullable: true);
        }
    }
}
