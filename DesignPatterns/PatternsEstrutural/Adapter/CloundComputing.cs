using DesignPatterns.PatternsEstrutural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Adapter
{
    public class CloundComputing
    {
        IAdapter adapter;

        public CloundComputing()
        {
            this.adapter = new Adapter(new BusinessLegado());
        }

        public void ProcessarContas(string mes)
        {
            var result = this.adapter.ExecutarRotinaContasPagar(mes);
            Console.WriteLine("Processando camada clound computing contas a pagar");
            Console.WriteLine(result); 
            Thread.Sleep(3000);

            Console.WriteLine(new String('-', 40));

            result = this.adapter.ExecutarRotinaContasReceber(mes);
            Console.WriteLine("Processando camada clound computing contas a receber");
            Console.WriteLine(result);
            Thread.Sleep(3000);

            Console.WriteLine("\n Processo finalizado com sucesso!");


        }
    }
}
