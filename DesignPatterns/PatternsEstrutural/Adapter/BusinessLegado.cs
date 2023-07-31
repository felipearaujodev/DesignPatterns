using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Adapter
{
    public class BusinessLegado
    {
        public string ExecutarRotinaContasPagar(string mes)
        {
            var result = AcessoSQL.GetDadosPagar(mes);
            Console.WriteLine("\nProcessando regras de negócio contas a pagar ...");
            //Aplicando as regras
            Thread.Sleep(3000);

            return result;
        }

        public string ExecutarRotinaContasReceber(string mes)
        {
            var result = AcessoSQL.GetDadosReceber(mes);
            Console.WriteLine("\nProcessando regras de negócio contas a receber ...");
            //Aplicando as regras
            Thread.Sleep(3000);

            return result;
        }
    }

    public class AcessoSQL
    {
        public static string GetDadosPagar(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("junho", "junho CNPJ:123123123123\nRazão Social: Lojas São Paulo\n Valor: 1200.00\n Contato: (11) 1234-1234");
            dic.Add("julho", "julho CNPJ:123123123123\nRazão Social: Lojas São Paulo\n Valor: 1200.00\n Contato: (11) 1234-1234");
            dic.Add("agosto", "agosto CNPJ:123123123123\nRazão Social: Lojas São Paulo\n Valor: 1200.00\n Contato: (11) 1234-1234");
            dic.Add("setembro", "setembro CNPJ:123123123123\nRazão Social: Lojas São Paulo\n Valor: 1200.00\n Contato: (11) 1234-1234");
            dic.Add("outubro", "outubro CNPJ:123123123123\nRazão Social: Lojas São Paulo\n Valor: 1200.00\n Contato: (11) 1234-1234");

            return dic[mes];
        }

        public static string GetDadosReceber(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("junho", "junho CNPJ:123123123123\nRazão Social: Lojas São Paulo\n Valor: 1200.00\n Contato: (11) 1234-1234");
            dic.Add("julho", "julho CNPJ:123123123123\nRazão Social: Lojas São Paulo\n Valor: 1200.00\n Contato: (11) 1234-1234");
            dic.Add("agosto", "agosto CNPJ:123123123123\nRazão Social: Lojas São Paulo\n Valor: 1200.00\n Contato: (11) 1234-1234");
            dic.Add("setembro", "setembro CNPJ:123123123123\nRazão Social: Lojas São Paulo\n Valor: 1200.00\n Contato: (11) 1234-1234");
            dic.Add("outubro", "outubro CNPJ:123123123123\nRazão Social: Lojas São Paulo\n Valor: 1200.00\n Contato: (11) 1234-1234");

            return dic[mes];
        }
    }
}
