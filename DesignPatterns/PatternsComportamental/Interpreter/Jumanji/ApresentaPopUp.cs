using DesignPatterns.PatternsComportamental.Interpreter.Jumanji.Personagem.PontosFortes;
using DesignPatterns.PatternsComportamental.Interpreter.Jumanji.Personagem.PontosFracos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Interpreter.Jumanji
{
    public class ApresentaPopUp
    {
        public void ApresentarHabilidades()
        {
            List<IPontoForte> pontosFortes = new List<IPontoForte> 
            {
                new Armeiro(), new Zoologia()
            };

            List<IPontoFraco> pontosFracos = new List<IPontoFraco> { 
                new Bolo(), new Forca(), new Velocidade()
            };

            var personagem = new Contexto("Felipe");

            Habilidades habilidades = new Habilidades(pontosFortes, pontosFracos);
            habilidades.Interpretar(personagem);
        }
    }
}
