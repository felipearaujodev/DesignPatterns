using DesignPatterns.Patterns.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder.Builders
{
    public class Studio30mBuilder : StudioBuilder
    {
        public Studio30mBuilder()
        {
            studio = new Studio30m();
        }
        public override void DefinirValorStudio()
        {
            studio.DefinirValorStudio(200000.00M);
        }

        public override void EscolherFinanciamento()
        {
            studio.EscolherFinanciamento("BancoFinanciamentos30");
        }

        public override void EscolherPiso()
        {
            studio.EscolherPiso("Laminado");
        }
    }
}
