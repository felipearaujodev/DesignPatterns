using DesignPatterns.Patterns.AbstractFactory.Product.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory.Product.Products
{
    public class DietaTercaSexta : IDieta
    {
        public DietaTercaSexta()
        {
            this.ObterAlimentacao();
        }
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de Terça e Sexta ...");
        }
    }
}
