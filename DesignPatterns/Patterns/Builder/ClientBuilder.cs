using DesignPatterns.Patterns.Builder.Builders;
using DesignPatterns.Patterns.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder
{
    public class ClientBuilder
    {
        public void ConsumirDadosStudio()
        {
            Director director = new Director();
            StudioBuilder studioBuilder;
            Studio studio;

            studioBuilder = new Studio24mBuilder();
            director.ConstruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            imprimirResultado(studio, "24m1");

            studioBuilder = new Studio26mBuilder();
            director.ConstruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            imprimirResultado(studio, "26m1");

            studioBuilder = new Studio30mBuilder();
            director.ConstruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            imprimirResultado(studio, "30m1");
        }

        private void imprimirResultado(Studio studio, string v)
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"[+] - Studio {v}");
            Console.WriteLine("Valor: {0}\nPiso: {1}\nFinanciamento: {2}",
                studio.ValorStudio.ToString("C"),
                studio.TipoPiso,
                studio.TipoFinanciamento);
        }
    }
}
