using DesignPatterns.Patterns.AbstractFactory.Product.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory.Product.Products
{
    public class TreinoSegundaQuinta : ITreino
    {
        public TreinoSegundaQuinta()
        {
            this.ObterTreino();
        }
        public void ObterTreino()
        {
            Console.WriteLine("Treino Segunda e Quinta ...");
        }
    }
}
