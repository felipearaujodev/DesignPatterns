using DesignPatterns.Patterns.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FactoryMethod.Servicos
{
    public class MasterServico : IServico
    {
        public MasterServico()
        {
            Console.WriteLine("Produto Master criando com sucesso!");
        }
        public void ExecutaCobrancaServico()
        {
            //Lógica da cobraça master
        }
    }
}
