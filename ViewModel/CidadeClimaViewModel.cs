using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Claims;
using System.Text;
using System.Windows.Input;
using TempoPrevisao_PP.Models;
using TempoPrevisao_PP.Services;

namespace TempoPrevisao_PP.ViewModels
{
    public partial class WeatherViewModel : ObservableObject
    {
        private readonly ClimaCidade brasilApi = new();
        private readonly WeatherApiService weatherApi = new();

        [ObservableProperty]
        public string cep;

        [ObservableProperty]
        private TempoClima climaAtualmente;

        public ObservableCollection<TempoClima> Previsoes { get; set; }
            = new ObservableCollection<TempoClima>();

        public ICommand BuscarCommand => new Command(async () => await Buscar());

        private async Task Buscar()
        {
            var cidade = await brasilApi.GetCityByCep(cep);
            var previsao = await weatherApi.GetForecast(cidade);

            Previsoes.Clear();
            foreach (var p in previsao)
                Previsoes.Add(p);
        }
    }
}