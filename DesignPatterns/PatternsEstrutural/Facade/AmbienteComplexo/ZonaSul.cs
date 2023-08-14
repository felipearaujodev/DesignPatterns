using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Facade.AmbienteComplexo
{
    public class ZonaSul
    {
        public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
        {
            //executa store procedure para itens e vendas perdidas e regras de negócio no SQL server
            Console.WriteLine("[!] - Executanto complexidade rotina vendas perdidas região Sul.");

            return new List<object>();
        }
    }
}
