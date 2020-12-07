using LikeButtonProject.DTOs;
using LikeButtonProject.Repositories;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using LikeButtonProject.Entities;
using System;

namespace LikeButtonProject.Services
{
    public class ArticleService : IArticleService
    {
        private LikeButtonContext Context { get; }

        public ArticleService(LikeButtonContext context)
        {
            Context = context;
        }

        public List<ArticleDTO> ListTopArticles()
        {
            var articles = Context.Articles.Include(x => x.Likes).OrderByDescending(x => x.Likes.Count).Take(3).Select(x => new { x.Id, x.Content, x.Title, x.Date, LikeCount = x.Likes.Count }).ToList();
            return articles.Select(x => new ArticleDTO
            {
                Id = x.Id,
                Content = x.Content,
                Title = x.Title,
                Date = x.Date,
                LikeCount = x.LikeCount
            }).ToList();
        }

        public int LikeArticle(LikeDTO like)
        {
            var article = Context.Articles.Include(x => x.Likes).First(x => x.Id == like.ArticleId);
            article.Likes.Add(new Like
            {
                Id = like.Id,
                ArticleId = like.ArticleId,
                LikeInstant = like.LikeDate
            });
            Context.Update(article);
            Context.SaveChanges();
            return article.Likes.Count;
        }

        public int UnlikeArticle(string likeId)
        {
            var like = Context.Likes.Find(likeId);
            var article = Context.Articles.Include(x => x.Likes).First(x => x.Id == like.ArticleId);
            Context.Likes.Remove(like);
            Context.SaveChanges();
            return article.Likes.Count;
        }
    }
}
