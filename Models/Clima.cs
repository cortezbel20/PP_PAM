using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoPrevisao_PP.Models
{
    public class TempoClima
    {
        public string DiaSemana { get; set; }
        public string Condicao { get; set; }
        public double TempMax { get; set; }
        public double TempMin { get; set; }
        public string Icone { get; set; }
        public bool Hoje { get; set; }
    }
}
