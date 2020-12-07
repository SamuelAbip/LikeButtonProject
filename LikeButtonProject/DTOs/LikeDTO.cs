using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonProject.DTOs
{
    public class LikeDTO
    {
        public string Id { get; set; }
        public string ArticleId { get; set; }
        public DateTime LikeDate { get; set; }
    }
}
