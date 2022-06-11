using Dapr.Client;

namespace frontend.Data;

public class WeatherForecastService
{
    public WeatherForecastService(DaprClient daprClient)
    {
        this.daprClient = daprClient;
    }
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    private readonly DaprClient daprClient;

    public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        var forecasts = await daprClient.InvokeMethodAsync<IEnumerable<WeatherForecast>>(HttpMethod.Get,"backend","weatherforecast");
        return forecasts.ToArray();
    }
}
