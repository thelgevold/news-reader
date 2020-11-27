using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using News.API.Model;

namespace News.API.Services
{
    public interface INewsService
    {
        Task<List<NewsStory>> GetNewsStories(string url);
    }

    public class NewsService : INewsService
    {
        private readonly IHttpClientFactory clientFactory;

        public NewsService(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task<List<NewsStory>> GetNewsStories(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Accept", "application/xml");

            var client = clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            XmlSerializer serializer = new XmlSerializer(typeof(Rss));

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var rss = (Rss)serializer.Deserialize(responseStream);

            return rss.Channel.Items.Select(i => new NewsStory() { Title = i.Title, Intro = i.Description, Date = i.PublicationDate, Url = i.Link }).ToList();
        }
    }
}
