using LikeButtonProject.Entities;
using LikeButtonProject.Repositories.Mappings;
using Microsoft.EntityFrameworkCore;
using System;

namespace LikeButtonProject.Repositories
{
    public class LikeButtonContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Like> Likes { get; set; }

        public LikeButtonContext(DbContextOptions<LikeButtonContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ArticleConfiguration());
            builder.ApplyConfiguration(new LikeConfiguration());
            builder.Entity<Article>().HasData(
                new Article
                {
                    Id = "9b06de81-77c2-4bbf-8021-a8e05ef97ec9",
                    Title = "First",
                    Date = new DateTime(2020, 12, 4),
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                },
                new Article
                {
                    Id = "11241631-ff06-437c-b860-ede5b472ef3b",
                    Title = "Second",
                    Date = new DateTime(2020, 12, 4),
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                },
                new Article
                {
                    Id = "2bff555f-78d9-4cae-ab5a-ff0528b8d141",
                    Title = "Third",
                    Date = new DateTime(2020, 12, 4),
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                }
            );
            builder.Entity<Like>().HasData(
                new Like
                {
                    Id = "c90cbc69-26b2-4ed9-897c-56af0f8b4b8b",
                    ArticleId = "9b06de81-77c2-4bbf-8021-a8e05ef97ec9",
                    LikeInstant = new DateTime(2020, 12, 5)
                },
                new Like
                {
                    Id = "cafac3c2-e80d-4f62-9bff-621385f02c12",
                    ArticleId = "9b06de81-77c2-4bbf-8021-a8e05ef97ec9",
                    LikeInstant = new DateTime(2020, 12, 5)
                },
                new Like
                {
                    Id = "06995fc4-ffda-4007-b360-1197c0306710",
                    ArticleId = "11241631-ff06-437c-b860-ede5b472ef3b",
                    LikeInstant = new DateTime(2020, 12, 5)
                }
            );
        }
    }
}
