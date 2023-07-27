using DesignPatterns.Patterns.AbstractFactory.Create.Interfaces;
using DesignPatterns.Patterns.AbstractFactory.Product.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory.Create.Factories
{
    public class SegundaQuintaFactory : IFactory
    {
        public SegundaQuintaFactory()
        {
            this.ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Segunda e Quinta criada com sucesso!");

            DietaSegundaQuinta dieta = new DietaSegundaQuinta();
            TreinoSegundaQuinta treino = new TreinoSegundaQuinta();
            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}
