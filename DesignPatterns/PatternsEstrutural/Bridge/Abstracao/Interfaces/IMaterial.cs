using DesignPatterns.PatternsEstrutural.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Bridge.Abstracao.Interfaces
{
    public interface IMaterial
    {
        public ICor CorImplementacao { get; set; }

        string ConsultarEstoque();
    }
}
