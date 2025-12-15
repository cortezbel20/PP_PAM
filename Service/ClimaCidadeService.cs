using System;
using System.Collections.Generic;
using System.Text;

namespace TempoPrevisao_PP.Services
{
    using System.Net.Http.Json;
    using TempoPrevisao_PP.Models;
    using TempoPrevisao_PP.Models;

    public class ClimaCidade
    {
        private readonly HttpClient _http = new HttpClient();

        public async Task<string> GetCityByCep(string cep)
        {
            var url = $"https://brasilapi.com.br/api/cep/v1/{cep}";
            var result = await _http.GetFromJsonAsync<BrasilApiCepResponse>(url);
            return result.cidade;
        }

        public async Task<Endereco> GetEnderecoByCep(string cep)
        {
            try
            {
                var url = $"https://brasilapi.com.br/api/cep/v1/{cep.Replace("-", "")}";
                var endereco = await _http.GetFromJsonAsync<Endereco>(url);
                return endereco;
            }
            catch
            {
                return null;
            }
        }
    }

}