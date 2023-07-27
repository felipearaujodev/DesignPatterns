using DesignPatterns.Patterns.AbstractFactory.Create.Interfaces;
using DesignPatterns.Patterns.AbstractFactory.Product.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory.Create.Factories
{
    public class TercaSextaFactory : IFactory
    {
        public TercaSextaFactory()
        {
            this.ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Terca e Sexta criada com sucesso!");

            DietaTercaSexta dieta = new DietaTercaSexta();
            TreinoTercaSexta treino = new TreinoTercaSexta();
            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}
