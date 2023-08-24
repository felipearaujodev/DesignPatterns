﻿using DesignPatterns.PatternsComportamental.Interpreter.Jumanji.Interfaces;
using DesignPatterns.PatternsComportamental.Interpreter.Jumanji.Personagem.PontosFortes;
using DesignPatterns.PatternsComportamental.Interpreter.Jumanji.Personagem.PontosFracos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Interpreter.Jumanji
{
    public class Habilidades : IExpressao
    {
        private List<IPontoForte> _pontosFortes;
        private List<IPontoFraco> _pontosFracos;

        public Habilidades(List<IPontoForte> pontosFortes, List<IPontoFraco> pontosFracos)
        {
            _pontosFortes = pontosFortes;
            _pontosFracos = pontosFracos;
        }

        public void Interpretar(Contexto contexto)
        {
            Console.WriteLine($"\nPersonagem: {contexto.Personagem}");
            contexto.Conteudo += "Exibindo habilidades...\n\nPontos Fortes:\n";
            foreach (var forte in _pontosFortes)
            {
                forte.Interpretar(contexto);
            }
            contexto.Conteudo += "\nPontos Fracos:\n";

            foreach (var fraco in _pontosFracos)
            {
                fraco.Interpretar(contexto);
            }

            Console.WriteLine(contexto.Conteudo);
        }
    }
}
