using System.Collections;
using System.Collections.Generic;

namespace RestaurantAPI
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get(int count, int mintTemperature, int maxTemperature);
    }
}
