using DesignPatterns.PatternsEstrutural.Bridge.Abstracao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Bridge
{
    public class ClientBridge
    {
        public IMaterial Material { get; set; }

        public void ConsultarCanetasPinceisNoEstoque()
        {
            Console.WriteLine(Material.ConsultarEstoque());
        }
    }
}
