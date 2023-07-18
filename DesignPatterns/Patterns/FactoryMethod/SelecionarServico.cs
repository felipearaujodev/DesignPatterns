using DesignPatterns.Patterns.FactoryMethod.Enums;
using DesignPatterns.Patterns.FactoryMethod.Interfaces;
using DesignPatterns.Patterns.FactoryMethod.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FactoryMethod
{
    public class SelecionarServico : ServicoFactory
    {
        public override IServico FabricarProduto(eTiposServicos tiposServicos)
        {
            switch (tiposServicos)
            {
                case eTiposServicos.tradicional:
                    return new TradicionalServico();
                case eTiposServicos.premium:
                    return new PremiumServico();
                case eTiposServicos.master:
                    return new MasterServico();
                case eTiposServicos.cobertura:
                    return new CoberturaServico();
                default:
                    return null;

            }
        }
    }
}
