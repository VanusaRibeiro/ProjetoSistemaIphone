using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//trabalhando com Herança
namespace SistemaIphone
{
    public class Smartphone : Celular
    {
        public int Armazenamento { get; set; }

        public Smartphone(string marca, string modelo, string sistemaOperacional, int armazenamento)
            : base(marca, modelo, sistemaOperacional)
        {
            Armazenamento = armazenamento;
        }

        public void AcessarInternet()
        {
            if (Ligado)
                Console.WriteLine("Acessando a internet...");
            else
                Console.WriteLine("O celular está desligado.");
        }
    }
}