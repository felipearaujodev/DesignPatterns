using DesignPatterns.Patterns.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FactoryMethod.Servicos
{
    public class CoberturaServico : IServico
    {
        public CoberturaServico()
        {
            Console.WriteLine("Produto cobertura criado co sucesso!");
        }
        public void ExecutaCobrancaServico()
        {
            //Lógica da cobrança
        }
    }
}
