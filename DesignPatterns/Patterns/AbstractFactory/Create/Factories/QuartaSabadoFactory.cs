using DesignPatterns.Patterns.AbstractFactory.Create.Interfaces;
using DesignPatterns.Patterns.AbstractFactory.Product.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory.Create.Factories
{
    public class QuartaSabadoFactory : IFactory
    {
        public QuartaSabadoFactory()
        {
            this.ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Quarta e Sabado criado com sucesso!");

            DietaQuartaSabado dieta = new DietaQuartaSabado();
            TreinoQuartaSabado treino = new TreinoQuartaSabado();
            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}
