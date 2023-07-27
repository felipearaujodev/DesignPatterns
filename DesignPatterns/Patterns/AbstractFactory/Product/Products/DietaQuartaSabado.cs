using DesignPatterns.Patterns.AbstractFactory.Product.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory.Product.Products
{
    public class DietaQuartaSabado : IDieta
    {
        public DietaQuartaSabado()
        {
            this.ObterAlimentacao();
        }
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de Quarta e Sabado ...");
        }
    }
}
