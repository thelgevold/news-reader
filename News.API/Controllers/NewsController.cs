using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using News.API.Model;
using News.API.Services;

namespace News.API.Controllers
{
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        [HttpGet]
        [Route("")]
        public Task<List<NewsStory>> Get([FromQuery(Name = "url")]  string url)
        {
            return newsService.GetNewsStories(url);
        }
    }
}
