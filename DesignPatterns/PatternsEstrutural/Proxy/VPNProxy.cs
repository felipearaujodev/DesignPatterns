using DesignPatterns.PatternsEstrutural.Proxy.Interfaces;
using DesignPatterns.PatternsEstrutural.Proxy.Models;
using DesignPatterns.PatternsEstrutural.Proxy.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Proxy
{
    public class VPNProxy : IProxy
    {
        public void AcessarVPN(User user)
        {
            DataBaseConnection sql = new DataBaseConnection();
            sql.RegistrarAcessoVPN(user);
            Console.WriteLine(new String('-', 40));

            VPN vpn = new VPN();
            vpn.AcessarVPN(user);
        }
    }
}
