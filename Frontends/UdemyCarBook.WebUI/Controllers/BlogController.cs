using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.BlogDtos;

namespace UdemyCarBook.WebUI.Controllers;
public class BlogController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public BlogController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.v1 = "Bloglar";
        ViewBag.v2 = "Yazarlarımızın Blogları";
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7038/api/Blogs/GetAllBlogsWithAuthorList");

        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorDto>>(jsonData);

            return View(values);
        }

        return View();
    }

    public async Task<IActionResult> BlogDetail(int id)
    {
        ViewBag.v1 = "Bloglar";
        ViewBag.v2 = "Blog Detayı ve Yorumlar";
        ViewBag.blogid = id;

        var client = _httpClientFactory.CreateClient();
        var responseMessage2 = await client.GetAsync($"https://localhost:7038/api/Comments/CommentCountByBlog?id=" + id);
        var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
        ViewBag.commentCount = jsonData2;

        return View();
    }
}
