using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExplorandoLinguagemCSharp.Models
{
    public class VendaForDeserializeObject
    {
        public int Id { get; set; }

        [JsonProperty("Produto")]
        public string Produto { get; set; }
        [JsonProperty("Preco")]
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }


    }
}