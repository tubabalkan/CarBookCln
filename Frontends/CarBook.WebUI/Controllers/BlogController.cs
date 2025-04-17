﻿using CarBook.Dto.BlogDtos;
using CarBook.Dto.CarPricingDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
    public class BlogController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.V1 = "Bloglar";
            ViewBag.V2 = "Keyifli Okumalar";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7001/api/Blogss/GetAllBlogsWithAuthorsList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthor>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.V1 = "Bloglar";
            ViewBag.V2 = "Blog Detayı ve Yorumlar ";
            ViewBag.blogid = id;
            return View();
        }

    }
}
