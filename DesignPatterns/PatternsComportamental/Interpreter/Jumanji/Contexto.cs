using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Interpreter.Jumanji
{
    public class Contexto
    {
        public Contexto(string personagem)
        {
            Personagem = personagem;
            Conteudo = String.Empty;
        }

        public string Personagem { get; set; }
        public string Conteudo { get; set; }
    }
}
