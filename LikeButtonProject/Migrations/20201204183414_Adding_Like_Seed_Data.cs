using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LikeButtonProject.Migrations
{
    public partial class Adding_Like_Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tb_articles",
                keyColumn: "id_article",
                keyValue: "11241631-ff06-437c-b860-ede5b472ef3b",
                column: "title",
                value: "Second");

            migrationBuilder.UpdateData(
                table: "tb_articles",
                keyColumn: "id_article",
                keyValue: "2bff555f-78d9-4cae-ab5a-ff0528b8d141",
                column: "title",
                value: "Third");

            migrationBuilder.UpdateData(
                table: "tb_articles",
                keyColumn: "id_article",
                keyValue: "9b06de81-77c2-4bbf-8021-a8e05ef97ec9",
                column: "title",
                value: "First");

            migrationBuilder.InsertData(
                table: "tb_likes",
                columns: new[] { "id_like", "article_id", "liked_instant" },
                values: new object[,]
                {
                    { "c90cbc69-26b2-4ed9-897c-56af0f8b4b8b", "9b06de81-77c2-4bbf-8021-a8e05ef97ec9", new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "cafac3c2-e80d-4f62-9bff-621385f02c12", "9b06de81-77c2-4bbf-8021-a8e05ef97ec9", new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "06995fc4-ffda-4007-b360-1197c0306710", "11241631-ff06-437c-b860-ede5b472ef3b", new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tb_likes",
                keyColumn: "id_like",
                keyValue: "06995fc4-ffda-4007-b360-1197c0306710");

            migrationBuilder.DeleteData(
                table: "tb_likes",
                keyColumn: "id_like",
                keyValue: "c90cbc69-26b2-4ed9-897c-56af0f8b4b8b");

            migrationBuilder.DeleteData(
                table: "tb_likes",
                keyColumn: "id_like",
                keyValue: "cafac3c2-e80d-4f62-9bff-621385f02c12");

            migrationBuilder.UpdateData(
                table: "tb_articles",
                keyColumn: "id_article",
                keyValue: "11241631-ff06-437c-b860-ede5b472ef3b",
                column: "title",
                value: "William");

            migrationBuilder.UpdateData(
                table: "tb_articles",
                keyColumn: "id_article",
                keyValue: "2bff555f-78d9-4cae-ab5a-ff0528b8d141",
                column: "title",
                value: "William");

            migrationBuilder.UpdateData(
                table: "tb_articles",
                keyColumn: "id_article",
                keyValue: "9b06de81-77c2-4bbf-8021-a8e05ef97ec9",
                column: "title",
                value: "William");
        }
    }
}
