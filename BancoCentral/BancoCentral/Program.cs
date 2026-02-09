using System;
using BancoCentral;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco meuBanco = new Banco();
            meuBanco.Nome = "Banco do Brasil";
            meuBanco.CodigoBacen = "001";
            Transacao minhaTransacao = new Transacao();
            minhaTransacao.Valor = 250.00m;
            minhaTransacao.Data = DateTime.Now;
            minhaTransacao.Tipo = "PIX";

            Console.WriteLine("--- REGISTRO BACEN ---\n\n" +
                $"Banco: {meuBanco.Nome}\n" +
                $"Codigo: {meuBanco.CodigoBacen}\n" +
                $"---" +
                $"Tipo: {minhaTransacao.Tipo}\n" +
                $"Valor: R${minhaTransacao.Valor}\n" +
                $"Data: {minhaTransacao.Data}\n");
        }
    }
}