using DesignPatterns.PatternsEstrutural.Proxy.Interfaces;
using DesignPatterns.PatternsEstrutural.Proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Proxy
{
    public class VPN : IProxy
    {
        public void AcessarVPN(User user)
        {
            Console.WriteLine("[+] - Acessando VPN\n");
            Thread.Sleep(2000);
            Console.WriteLine($"{user.UserName}, você está logado na VPN");
        }
    }
}
