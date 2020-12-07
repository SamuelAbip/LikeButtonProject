using LikeButtonProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LikeButtonProject.Repositories.Mappings
{
    public class LikeConfiguration : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.ToTable("tb_likes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_like");
            builder.Property(x => x.LikeInstant).HasColumnName("liked_instant");
            builder.Property(x => x.ArticleId).HasColumnName("article_id");
            builder.HasOne(x => x.Article).WithMany(x => x.Likes).HasForeignKey(x => x.ArticleId);
        }
    }
}
