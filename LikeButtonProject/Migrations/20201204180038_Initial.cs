using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LikeButtonProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_articles",
                columns: table => new
                {
                    id_article = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    content = table.Column<string>(type: "varchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_articles", x => x.id_article);
                });

            migrationBuilder.CreateTable(
                name: "tb_likes",
                columns: table => new
                {
                    id_like = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    article_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    liked_instant = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_likes", x => x.id_like);
                    table.ForeignKey(
                        name: "FK_tb_likes_tb_articles_article_id",
                        column: x => x.article_id,
                        principalTable: "tb_articles",
                        principalColumn: "id_article",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_likes_article_id",
                table: "tb_likes",
                column: "article_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_likes");

            migrationBuilder.DropTable(
                name: "tb_articles");
        }
    }
}
