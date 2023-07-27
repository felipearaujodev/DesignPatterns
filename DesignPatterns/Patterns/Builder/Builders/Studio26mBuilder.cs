﻿using DesignPatterns.Patterns.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder.Builders
{
    public class Studio26mBuilder : StudioBuilder
    {
        public Studio26mBuilder()
        {
            studio = new Studio26m();
        }
        public override void DefinirValorStudio()
        {
            studio.DefinirValorStudio(190000.00M);
        }

        public override void EscolherFinanciamento()
        {
            studio.EscolherFinanciamento("BancoFinanciamentos26");
        }

        public override void EscolherPiso()
        {
            studio.EscolherPiso("Porcelanato");
        }
    }
}
