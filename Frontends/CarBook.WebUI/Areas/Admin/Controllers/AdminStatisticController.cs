using CarBook.Dto.AboutDtos;
using CarBook.Dto.AuthorDtos;
using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Packaging.Signing;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistic")]
    public class AdminStatisticController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();

           

            var responseMessage = await client.GetAsync("https://localhost:7001/api/Statistic/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int carCountRandom = random.Next(0, 101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCount = values.carCount;
                ViewBag.carCountRandom = carCountRandom;
            }

            var responseMessage2 = await client.GetAsync("https://localhost:7001/api/Statistic/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int locationCountRandom = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.locationCount = values2.locationCount;
                ViewBag.locationCountRandom = locationCountRandom;
            }


            var responseMessage3 = await client.GetAsync("https://localhost:7001/api/Statistic/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int authorCountRandom = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.authorCount = values3.authorCount;
                ViewBag.authorCountRandom = authorCountRandom;
            }


            var responseMessage4 = await client.GetAsync("https://localhost:7001/api/Statistic/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int blogCountRandom = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.blogCount = values4.blogCount;
                ViewBag.blogCountRandom = blogCountRandom;
            }

            var responseMessage5 = await client.GetAsync("https://localhost:7001/api/Statistic/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int BrandCountRandom = random.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.BrandCount = values5.brandCount;
                ViewBag.BrandCountRandom = BrandCountRandom;
            }

            var responseMessage6 = await client.GetAsync("https://localhost:7001/api/Statistic/GetAvgRentPriceForDaily");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int avgRentPriceForDailRandom = random.Next(0, 101);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.avgRentPriceForDail = values6.avgRentPriceForDail;
                ViewBag.avgRentPriceForDailRandom = avgRentPriceForDailRandom;
            }

            var responseMessage7 = await client.GetAsync("https://localhost:7001/api/Statistic/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int avgRentPriceForWeeklyRandom = random.Next(0, 101);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.avgRentPriceForWeekly = values7.avgRentPriceForWeekly;
                ViewBag.avgRentPriceForWeeklyRandom = avgRentPriceForWeeklyRandom;
            }

            var responseMessage8 = await client.GetAsync("https://localhost:7001/api/Statistic/GetAvgRentPriceForMonthly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int avgRentPriceForMonthlyRandom = random.Next(0, 101);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.avgRentPriceForMonthly = values8.avgRentPriceForMonthly;
                ViewBag.avgRentPriceForMonthlyRandom = avgRentPriceForMonthlyRandom;
            }

            var responseMessage9 = await client.GetAsync("https://localhost:7001/api/Statistic/GetCarCountByTranmissionIsAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int carCountByTranmissionIsAutoRandom = random.Next(0, 101);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.carCountByTranmissionIsAuto = values9.carCountByTranmissionIsAuto;
                ViewBag.carCountByTranmissionIsAutoRandom = carCountByTranmissionIsAutoRandom;
            }

            var responseMessage10 = await client.GetAsync("https://localhost:7001/api/Statistic/GetBrandNameByMaxCar");
            if (responseMessage10.IsSuccessStatusCode)
            {
                int GetBrandNameByMaxCarRandom = random.Next(0, 101);
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
                ViewBag.GetBrandNameByMaxCar = values10.GetBrandNameByMaxCar;
                ViewBag.GetBrandNameByMaxCarRandom = GetBrandNameByMaxCarRandom;
            }


            var responseMessage11 = await client.GetAsync("https://localhost:7001/api/Statistic/GetBlogTitleByMaxBlogComment");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int GetBlogTitleByMaxBlogCommentRandom = random.Next(0, 101);
                var jsonData11 = await responseMessage9.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
                ViewBag.GetBlogTitleByMaxBlogComment = values11.GetBlogTitleByMaxBlogComment;
                ViewBag.GetBlogTitleByMaxBlogCommentRandom = GetBlogTitleByMaxBlogCommentRandom;
            }

            var responseMessage12 = await client.GetAsync("https://localhost:7001/api/Statistic/GetCarCountByKmSmallerThen1000");
            if (responseMessage12.IsSuccessStatusCode)
            {
                int GetCarCountByKmSmallerThen1000Random = random.Next(0, 101);
                var jsonData12 = await responseMessage9.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
                ViewBag.GetCarCountByKmSmallerThen1000 = values12.GetCarCountByKmSmallerThen1000;
                ViewBag.GetCarCountByKmSmallerThen1000Random = GetCarCountByKmSmallerThen1000Random;
            }

            var responseMessage13 = await client.GetAsync("https://localhost:7001/api/Statistic/GetCarCountByFuelElectric");
            if (responseMessage13.IsSuccessStatusCode)
            {
                int GetCarCountByFuelElectricRandom = random.Next(0, 101);
                var jsonData13 = await responseMessage9.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData13);
                ViewBag.GetCarCountByFuelElectric = values13.GetCarCountByFuelElectric;
                ViewBag.GetCarCountByFuelElectricRandom = GetCarCountByFuelElectricRandom;
            }

            var responseMessage14 = await client.GetAsync("https://localhost:7001/api/Statistic/GetCarBrandAndModelByRentPriceDailyMax");
            if (responseMessage14.IsSuccessStatusCode)
            {
                int GetCarBrandAndModelByRentPriceDailyMaxRandom = random.Next(0, 101);
                var jsonData14 = await responseMessage9.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData14);
                ViewBag.GetCarBrandAndModelByRentPriceDailyMax = values14.GetCarBrandAndModelByRentPriceDailyMax;
                ViewBag.GetCarBrandAndModelByRentPriceDailyMaxRandom = GetCarBrandAndModelByRentPriceDailyMaxRandom;
            }

            var responseMessage15 = await client.GetAsync("https://localhost:7001/api/Statistic/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessage15.IsSuccessStatusCode)
            {
                int GetCarBrandAndModelByRentPriceDailyMinRandom = random.Next(0, 101);
                var jsonData15 = await responseMessage9.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData15);
                ViewBag.GetCarBrandAndModelByRentPriceDailyMin = values15.GetCarBrandAndModelByRentPriceDailyMin;
                ViewBag.GetCarBrandAndModelByRentPriceDailyMinRandom = GetCarBrandAndModelByRentPriceDailyMinRandom;
            }


            return View();
        }
    }
}
