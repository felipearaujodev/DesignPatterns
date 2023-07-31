// See https://aka.ms/new-console-template for more information
using DesignPatterns.Patterns.AbstractFactory;
using DesignPatterns.Patterns.Builder;
using DesignPatterns.Patterns.Prototype;
using DesignPatterns.Patterns.Singleton;
using DesignPatterns.PatternsEstrutural.Adapter;

Console.WriteLine("Design Patterns!");

//ClientSingleton client = new ClientSingleton();
//client.ConsumirDB();

//ClientBuilder clientbuilder = new ClientBuilder();
//clientbuilder.ConsumirDadosStudio();

//ClientPrototype client = new ClientPrototype();
//client.Consumir();

CloundComputing clound = new CloundComputing();
clound.ProcessarContas("setembro");