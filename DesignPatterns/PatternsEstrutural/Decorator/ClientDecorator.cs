using DesignPatterns.PatternsEstrutural.Decorator.Decorators;
using DesignPatterns.PatternsEstrutural.Decorator.Interfaces;
using DesignPatterns.PatternsEstrutural.Decorator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Decorator
{
    public class ClientDecorator
    {
        public void ConsumirServicos()
        {
            IPet banhoTosa = new BanhoTosa("Banho e Tosa", 45.00);

            IPet acessorioDecotator = new AcessorioDecorator(banhoTosa);

            IPet luxoSpaDecorator = new LuxoSpaDecorator(acessorioDecotator);

            Console.WriteLine("Resumo dos Serviços PetShop");
            Console.WriteLine(luxoSpaDecorator.GetNomeServico());
            Console.WriteLine("Valor Total: " + luxoSpaDecorator.GetValorServico());
        }
    }
}
