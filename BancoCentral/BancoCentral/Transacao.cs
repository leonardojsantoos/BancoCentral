using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoCentral;
using static System.Net.Mime.MediaTypeNames;

namespace BancoCentral
{
    internal class Transacao
    {
        public decimal Valor { get; set; }
        public DateTime  Data { get; set; }
        public string Tipo { get; set; }
        public ContaBancaria ContaOrigem { get; set; }
        public ContaBancaria ContaDestino { get; set; }

        public Transacao()
        {
            ContaOrigem = new ContaBancaria();
            ContaDestino = new ContaBancaria();
        }
    }
}
