using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int carCount { get; set; }
        public int locationCount { get; set; }
        public int authorCount { get; set; }
        public int blogCount { get; set; }
        public int brandCount { get; set; }
        public decimal avgRentPriceForDail { get; set; }
        public decimal avgRentPriceForWeekly { get; set; }
        public decimal avgRentPriceForMonthly { get; set; }
        public int carCountByTranmissionIsAuto { get; set; }
        public string GetBrandNameByMaxCar { get; set; }
        public string GetBlogTitleByMaxBlogComment { get; set; }
        public int GetCarCountByKmSmallerThen1000 { get; set; }
        public int GetCarCountFuelCasolLineOrDiesel { get; set; }
        public int GetCarCountByFuelElectric { get; set; }
        public string GetCarBrandAndModelByRentPriceDailyMax { get; set; }
        public string GetCarBrandAndModelByRentPriceDailyMin { get; set; }
      
    }
}
