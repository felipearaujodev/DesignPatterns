using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Singleton
{
    public class ClientSingleton
    {
        public void ConsumirDB()
        {
            var instancia = ContextDB.Instancia;
            instancia.ExecutaQuery("SELECT * FROM Tabela");

            instancia = ContextDB.Instancia;
            instancia.ExecutaQuery("INSERT INTO Tabela(Nome) VALUES ('Nome')");

            instancia = ContextDB.Instancia;
            instancia.ExecutaQuery("UPDATE Tabela SET Nome = 'Nome Completo' WHERE Id = 1");
            
            instancia = ContextDB.Instancia;
            instancia.ExecutaQuery("DELETE FROM Tabela WHERE Id = 1");
        }
    }
}
