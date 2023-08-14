using DesignPatterns.PatternsEstrutural.Proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Proxy.SQL
{
    public class DataBaseConnection
    {
        public void RegistrarAcessoVPN(User user)
        {
            var query = $"INSERT INTO tb_registro_vpn (User, Password, Date) \n " +
                $"VALUES ('{user.UserName}', '{user.Password}', {DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")})";

            Console.WriteLine("[!] - Registrando acesso pelo proxy...\n");
            Console.WriteLine(query);
        }
    }
}
