using DesignPatterns.Patterns.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FactoryMethod.Servicos
{
    public class TradicionalServico : IServico
    {
        public TradicionalServico()
        {
            Console.WriteLine("Produto tradicional criado com sucesso!");
        }
        public void ExecutaCobrancaServico()
        {
            //Lógica cobrança tradicional
        }
    }
}
