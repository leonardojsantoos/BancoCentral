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
            minhaTransacao.ContaOrigem.Agente = "001";
            minhaTransacao.ContaOrigem.Numero = "888";

            minhaTransacao.ContaDestino.Agente = "002";
            minhaTransacao.ContaDestino.Numero = "999";
                               
            Console.WriteLine("--- REGISTRO BACEN ---\n\n" +
                $"Banco: {meuBanco.Nome}\n" +
                $"Codigo: {meuBanco.CodigoBacen}\n" +
                $"---\n" +
                $"Tipo: {minhaTransacao.Tipo}\n" +
                $"Valor: R${minhaTransacao.Valor}\n" +
                $"Data: {minhaTransacao.Data}\n" +
                $"---\n" +
                $"Conta Origem: {minhaTransacao.ContaOrigem.Agente}\n" +
                $"Conta Destino: {minhaTransacao.ContaDestino.Agente}");

        }
    }
}