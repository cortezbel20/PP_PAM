using System;
using System.Collections.Generic;
using System.Text;

namespace TempoPrevisao_PP.Models
{
    public class BrasilApiCepResponse
    {
        public string cep { get; set; }
        public string cidade { get; set; }
        public string state { get; set; }
    }
}