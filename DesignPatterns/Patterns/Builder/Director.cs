using DesignPatterns.Patterns.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder
{
    public class Director
    {
        public void ConstruirStudio(StudioBuilder studioBuilder)
        {
            studioBuilder.EscolherPiso();
            studioBuilder.EscolherFinanciamento();
            studioBuilder.DefinirValorStudio();
        }
    }
}
