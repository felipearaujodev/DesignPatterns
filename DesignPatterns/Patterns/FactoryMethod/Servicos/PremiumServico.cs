using DesignPatterns.Patterns.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FactoryMethod.Servicos
{
    public class PremiumServico : IServico
    {
        public PremiumServico()
        {
            Console.WriteLine("Produto premium criado com sucesso!");
        }

        public void ExecutaCobrancaServico()
        {
            //Lógica de cobrança premium
        }
    }
}
