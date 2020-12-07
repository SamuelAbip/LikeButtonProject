using System;

namespace LikeButtonProject.Entities
{
    public class Like
    {
        public string Id { get; set; }

        public string ArticleId { get; set; }

        public virtual Article Article { get; set; }
        
        public DateTime LikeInstant { get; set; }
        
    }
}
