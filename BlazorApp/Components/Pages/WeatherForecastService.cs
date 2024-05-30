namespace BlazorApp.Components.Pages;

using System;
using System.Linq;
using System.Threading.Tasks;

public class WeatherForecastService
{
    public async Task<WeatherForecast[]> GetForecastsAsync(DateTime selectedDate)
    {
        await Task.Delay(500); // Simula la carga asincrónica

        var startDate = DateOnly.FromDateTime(selectedDate);
        var summaries = new[] { "Helado", "Fresco", "Fresco", "Agradable", "Moderado", "Cálido", "Agradable", "Caluroso", "Bochornoso", "Abrasador" };
        var forecasts = Enumerable.Range(0, 7).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = summaries[Random.Shared.Next(summaries.Length)]
        }).ToArray();

        return forecasts;
    }

    public class WeatherForecast
    {
        public DateOnly Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
