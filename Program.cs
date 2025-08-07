using SistemaIphone;

//Usando polimorfismo para tratar diferentes tipos de celulares de forma genérica
class Program
{
    static void Main(string[] args)
    {
        List<Celular> celulares = new List<Celular>
            {
                new Celular("Nokia", "1100", "Proprietário"),
                new Smartphone("Apple", "iPhone 13", "iOS", 128)
            };

        foreach (var cel in celulares)
        {
            cel.Ligar();
            cel.FazerChamada("12345-6789");
        }
    }
}


