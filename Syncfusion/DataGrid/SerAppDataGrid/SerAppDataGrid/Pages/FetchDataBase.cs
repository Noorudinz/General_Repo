using Microsoft.AspNetCore.Components;
using SerAppDataGrid.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SerAppDataGrid.Pages
{
    public class FetchDataBase : ComponentBase
    {
        protected WeatherForecast[] forecasts;

        [Inject]  
        private WeatherForecastService ForecastServicee { get; set; }
        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastServicee.GetForecastAsync(DateTime.Now);
        }
    }
}
