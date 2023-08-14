using DesignPatterns.PatternsEstrutural.Proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Proxy
{
    public class ClientProxy
    {
        public void ConectarClientVPN()
        {
            VPNProxy VPNProxy = new VPNProxy();
            Console.Write("Digite o UserName:");
            string userName = Console.ReadLine();

            Console.Write("Digite a senha: ");
            string password = Console.ReadLine();

            var user = new User(userName, password);
            VPNProxy.AcessarVPN(user);  

        }
    }
}
