using DesignPatterns.Patterns.AbstractFactory.Product.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory.Product.Products
{
    public class TreinoQuartaSabado : ITreino
    {
        public TreinoQuartaSabado()
        {
            this.ObterTreino();
        }
        public void ObterTreino()
        {
            Console.WriteLine("Treino Quarta e Sabado ...");
        }
    }
}
