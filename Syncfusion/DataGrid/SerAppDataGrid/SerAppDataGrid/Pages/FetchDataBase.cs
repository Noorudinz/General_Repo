using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Caching.Memory;
using SerAppDataGrid.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SerAppDataGrid.Pages
{
    public class FetchDataBase : ComponentBase
    {
        protected IEnumerable<WeatherForecast> forecasts;

        [Inject]  
        private WeatherForecastService ForecastServicee { get; set; }

        [Inject]
        private IMemoryCache memoryCache { get; set; }
        protected override async Task OnInitializedAsync()
        {
             forecasts = GetForecastAsync(DateTime.Now);
       
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> GetForecastAsync(DateTime dtime)
        {
            if (!memoryCache.TryGetValue("weatherdata", out IEnumerable<WeatherForecast> data))
            {
                var rng = new Random();
                //return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
                //{
                //    Date = startDate.AddDays(index),
                //    TemperatureC = rng.Next(-20, 55),
                //    Summary = Summaries[rng.Next(Summaries.Length)]
                //}).ToArray());
                data = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                }).ToArray();

                var cacheOption = new MemoryCacheEntryOptions()
                {
                    Priority = CacheItemPriority.High,
                    AbsoluteExpiration = DateTime.Now.AddMinutes(10),
                    Size = 128
                };

                memoryCache.Set("weatherdata", data, cacheOption);
            }

            return data;

        }
    }
}
