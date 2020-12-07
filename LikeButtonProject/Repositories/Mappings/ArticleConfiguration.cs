using LikeButtonProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonProject.Repositories.Mappings
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("tb_articles");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_article");
            builder.Property(x => x.Title).HasColumnName("title").HasMaxLength(1000);
            builder.Property(x => x.Content).HasColumnName("content").HasColumnType("varchar(max)");
            builder.Property(x => x.Date).HasColumnName("date");
            builder.HasMany(x => x.Likes).WithOne(x => x.Article).HasForeignKey(x => x.ArticleId);
        }
    }
}
