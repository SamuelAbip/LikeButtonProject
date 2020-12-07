using LikeButtonProject.DTOs;
using LikeButtonProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonProject.Controllers
{
    [ApiController]
    [Route("[controller]/{action=Index}")]
    public class ArticleController : ControllerBase
    {
        private ILogger<ArticleController> Logger { get; }
        private IArticleService ArticleService { get; }

        public ArticleController(ILogger<ArticleController> logger, IArticleService articleService)
        {
            Logger = logger;
            ArticleService = articleService;
        }

        [HttpGet]
        public List<ArticleDTO> Index()
        {
            return ArticleService.ListTopArticles();
        }

        [HttpPost]
        public int LikeArticle([FromBody] LikeDTO like)
        {
            return ArticleService.LikeArticle(like);
        }

        [HttpPost]
        public int UnlikeArticle([FromBody] string likeId)
        {
            return ArticleService.UnlikeArticle(likeId);
        }
    }
}
