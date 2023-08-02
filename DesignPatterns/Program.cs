// See https://aka.ms/new-console-template for more information
using DesignPatterns.Patterns.AbstractFactory;
using DesignPatterns.Patterns.Builder;
using DesignPatterns.Patterns.Prototype;
using DesignPatterns.Patterns.Singleton;
using DesignPatterns.PatternsEstrutural.Adapter;
using DesignPatterns.PatternsEstrutural.Bridge;
using DesignPatterns.PatternsEstrutural.Bridge.Abstracao;
using DesignPatterns.PatternsEstrutural.Bridge.Implementacao;

Console.WriteLine("Design Patterns!");

//ClientSingleton client = new ClientSingleton();
//client.ConsumirDB();

//ClientBuilder clientbuilder = new ClientBuilder();
//clientbuilder.ConsumirDadosStudio();

//ClientPrototype client = new ClientPrototype();
//client.Consumir();

//Adapter
//CloundComputing clound = new CloundComputing();
//clound.ProcessarContas("setembro");

ClientBridge client;
Random random;

while (true)
{
    client = new ClientBridge();
    random = new Random();

    if (random.Next(2) == 1)
        client.Material = new CanetaEsferografica();
    else
        client.Material = new PincelMarcador();

    if (random.Next(1, 3) == 1)
        client.Material.CorImplementacao = new Azul();
    else if (random.Next(1, 3) == 2)
        client.Material.CorImplementacao = new Preto();
    else
        client.Material.CorImplementacao = new Vermelho();

    client.ConsultarCanetasPinceisNoEstoque();

    Console.WriteLine("Pressionei enter para continuar ou qualquer tecla para finalizar...");
    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

    if (consoleKeyInfo.KeyChar != 13)
        break;
}