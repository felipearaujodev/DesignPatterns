using DesignPatterns.PatternsEstrutural.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Bridge.Implementacao
{
    public class Vermelho : ICor
    {
        public string ConsultarQuantidadePorCor(string tipoAbstracao)
        {
            //Implementa a complexidade de consulta no banco de dados a quantidade por cor
            var random = new Random();
            var quantidade = random.Next(100, 500);

            return $"Existem {quantidade} para {tipoAbstracao} de cor vemelha no estoque.";
        }
    }
}
