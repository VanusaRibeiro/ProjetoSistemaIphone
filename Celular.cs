using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIphone
{
public class Celular
{
    // Atributos
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string SistemaOperacional { get; set; }
    public bool Ligado { get; private set; }

    // Construtor
    public Celular(string marca, string modelo, string sistemaOperacional)
    {
        Marca = marca;
        Modelo = modelo;
        SistemaOperacional = sistemaOperacional;
        Ligado = false;
    }

    // Métodos
    public void Ligar()
    {
        Ligado = true;
        Console.WriteLine("Celular ligado.");
    }

    public void Desligar()
    {
        Ligado = false;
        Console.WriteLine("Celular desligado.");
    }

    public void FazerChamada(string numero)
    {
        if (Ligado)
            Console.WriteLine($"Chamando {numero}...");
        else
            Console.WriteLine("Não é possível fazer chamada. O celular está desligado.");
    }

    public void EnviarMensagem(string numero, string mensagem)
    {
        if (Ligado)
            Console.WriteLine($"Enviando mensagem para {numero}: {mensagem}");
        else
            Console.WriteLine("Não é possível enviar mensagem. O celular está desligado.");
    }
}
}