using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Facade.AmbienteComplexo
{
    public class ZonaNorte
    {
        public List<object> ExecutarRotinaVendasPerdidas(DateTime periodo)
        {
            // Executar store procedure para itens de vendas perdidas região norte MySQL
            Console.WriteLine("[!] - Executanto complexidade rotina vendas perdidas região Norte.");

            return new List<object>();
        }
    }
}
