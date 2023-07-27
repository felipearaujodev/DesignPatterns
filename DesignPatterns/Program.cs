// See https://aka.ms/new-console-template for more information
using DesignPatterns.Patterns.AbstractFactory;
using DesignPatterns.Patterns.Builder;
using DesignPatterns.Patterns.Singleton;

Console.WriteLine("Design Patterns!");

//ClientSingleton client = new ClientSingleton();
//client.ConsumirDB();

ClientBuilder clientbuilder = new ClientBuilder();
clientbuilder.ConsumirDadosStudio();