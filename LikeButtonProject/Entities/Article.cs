using System;
using System.Collections.Generic;

namespace LikeButtonProject.Entities
{
    public class Article
    {         
        public string Id { get; set;  }

        public string Title { get; set; }

        public string Content { get; set; }
        public DateTime Date { get; set; }

        public virtual List<Like> Likes { get; set; }
    }
}
