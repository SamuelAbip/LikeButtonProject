using LikeButtonProject.DTOs;
using LikeButtonProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonProject.Services
{
    public interface IArticleService
    {
        List<ArticleDTO> ListTopArticles();
        int LikeArticle(LikeDTO like);
        int UnlikeArticle(string likeId);
    }
}
