using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TonolucroAPI.Models
{
    public class Destaque
    {
        public Destaque()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Logo { get; set; }
        public string Ilustacao { get; set; }
        public string Descricao { get; set; }
        public string Frase { get; set; }
        public float ValorAnterior { get; set; }
        public float ValorAtual { get; set; }
    }
}
