﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Interpreter.Jumanji.Personagem.PontosFracos
{
    public class Bolo : IPontoFraco
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += "[-] - Alergia mortal a bolo\n";
        }
    }
}
