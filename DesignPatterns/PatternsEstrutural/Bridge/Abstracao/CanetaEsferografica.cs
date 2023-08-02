using DesignPatterns.PatternsEstrutural.Bridge.Abstracao.Interfaces;
using DesignPatterns.PatternsEstrutural.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Bridge.Abstracao
{
    public class CanetaEsferografica : IMaterial
    {
        public ICor CorImplementacao { get; set; }

        public string ConsultarEstoque()
        {
            return CorImplementacao.ConsultarQuantidadePorCor("Caneta Esferográfica");
        }
    }
}
