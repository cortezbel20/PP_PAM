using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;
using TempoPrevisao_PP.Models;

namespace TempoPrevisao_PP.Services
{
    public class WeatherApiService
    {
        private readonly HttpClient _http = new HttpClient();
        private readonly string apiKey = "coloque_sua_Chave";

        public async Task<List<TempoClima>> GetForecast(string city)
        {


            var lista = new List<TempoClima>();

            try
            {
                var url =
                    $"https://api.weatherapi.com/v1/forecast.json" +
                    $"?key={apiKey}&q={city}&days=4&lang=pt";

                var result = await _http.GetFromJsonAsync<WeatherApiResponse>(url);


                if (result?.forecast?.forecastday == null)
                    return lista;

                var cultura = new CultureInfo("pt-BR");
                int index = 0;

                foreach (var day in result.forecast.forecastday)
                {

                    DateTime data = DateTime.Now.Date.AddDays(index);

                    var dia = cultura.TextInfo.ToTitleCase(
                        data.ToString("dddd", cultura)
                    );

                    lista.Add(new TempoClima
                    {
                        DiaSemana = dia,
                        Condicao = day.day.condition.text,
                        TempMax = day.day.maxtemp,
                        TempMin = day.day.mintemp ,
                        Icone = "https:" + day.day.condition.icon,
                        Hoje = index == 0
                    });

                    index++;
                }
            }
            catch
            {

            }

            return lista;
        }
    }
}