using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerAppDataGrid.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //[Inject]
        //private IMemoryCache memoryCache { get; set; }
        //public IEnumerable<WeatherForecast> GetForecastAsync(DateTime dtime)
        //{
        //    if (!memoryCache.TryGetValue("weatherdata", out IEnumerable<WeatherForecast> data))
        //    {
        //        var rng = new Random();
        //        //return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //        //{
        //        //    Date = startDate.AddDays(index),
        //        //    TemperatureC = rng.Next(-20, 55),
        //        //    Summary = Summaries[rng.Next(Summaries.Length)]
        //        //}).ToArray());
        //        data = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //        {
        //            Date = DateTime.Now.AddDays(index),
        //            TemperatureC = rng.Next(-20, 55),
        //            Summary = Summaries[rng.Next(Summaries.Length)]
        //        }).ToArray();

        //        var cacheOption = new MemoryCacheEntryOptions()
        //        {
        //            Priority = CacheItemPriority.High,
        //            AbsoluteExpiration = DateTime.Now.AddMinutes(10),
        //            Size = 128
        //        };

        //        memoryCache.Set("weatherdata", data, cacheOption);
        //    }

        //    return data;

        //}

    }
}
