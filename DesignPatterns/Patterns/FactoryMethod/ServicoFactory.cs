using DesignPatterns.Patterns.FactoryMethod.Enums;
using DesignPatterns.Patterns.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FactoryMethod
{
    public abstract class ServicoFactory
    {
        public abstract IServico FabricarProduto(eTiposServicos tiposServicos);
    }
}
