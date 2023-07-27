using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Prototype
{
    public class ClientPrototype
    {
        public void Consumir()
        {
            GerenciadorVendasStudio gerenciador = new GerenciadorVendasStudio();

            gerenciador["24m"] = new Studio("24m", "BancoFinanciador24", 170000.00M);
            gerenciador["26m"] = new Studio("26m", "BancoFinanciador26", 180000.00M);
            gerenciador["28m"] = new Studio("28m", "BancoFinanciador28", 190000.00M);

            StudioModel studio24 = gerenciador["24m"].Clone();
            StudioModel studio24_2 = gerenciador["24m"].Clone();
            StudioModel studio26 = gerenciador["26m"].Clone();
            StudioModel studio28 = gerenciador["28m"].Clone();
        }
    }
}
