﻿// <auto-generated />
using System;
using LikeButtonProject.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LikeButtonProject.Migrations
{
    [DbContext(typeof(LikeButtonContext))]
    [Migration("20201204183414_Adding_Like_Seed_Data")]
    partial class Adding_Like_Seed_Data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LikeButtonProject.Entities.Article", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("id_article");

                    b.Property<string>("Content")
                        .HasColumnType("varchar(max)")
                        .HasColumnName("content");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<string>("Title")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("tb_articles");

                    b.HasData(
                        new
                        {
                            Id = "9b06de81-77c2-4bbf-8021-a8e05ef97ec9",
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Date = new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "First"
                        },
                        new
                        {
                            Id = "11241631-ff06-437c-b860-ede5b472ef3b",
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Date = new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Second"
                        },
                        new
                        {
                            Id = "2bff555f-78d9-4cae-ab5a-ff0528b8d141",
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Date = new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Third"
                        });
                });

            modelBuilder.Entity("LikeButtonProject.Entities.Like", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("id_like");

                    b.Property<string>("ArticleId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("article_id");

                    b.Property<DateTime>("LikeInstant")
                        .HasColumnType("datetime2")
                        .HasColumnName("liked_instant");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("tb_likes");

                    b.HasData(
                        new
                        {
                            Id = "c90cbc69-26b2-4ed9-897c-56af0f8b4b8b",
                            ArticleId = "9b06de81-77c2-4bbf-8021-a8e05ef97ec9",
                            LikeInstant = new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "cafac3c2-e80d-4f62-9bff-621385f02c12",
                            ArticleId = "9b06de81-77c2-4bbf-8021-a8e05ef97ec9",
                            LikeInstant = new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "06995fc4-ffda-4007-b360-1197c0306710",
                            ArticleId = "11241631-ff06-437c-b860-ede5b472ef3b",
                            LikeInstant = new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("LikeButtonProject.Entities.Like", b =>
                {
                    b.HasOne("LikeButtonProject.Entities.Article", "Article")
                        .WithMany("Likes")
                        .HasForeignKey("ArticleId");

                    b.Navigation("Article");
                });

            modelBuilder.Entity("LikeButtonProject.Entities.Article", b =>
                {
                    b.Navigation("Likes");
                });
#pragma warning restore 612, 618
        }
    }
}