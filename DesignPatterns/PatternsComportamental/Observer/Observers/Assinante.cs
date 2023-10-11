
using DesignPatterns.PatternsComportamental.Observer.Interfaces;
using DesignPatterns.PatternsComportamental.Observer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Observer.Observers
{
    public class Assinante : IObservavel
    {
        public Assinante(Pessoa pessoa, string mensagem)
        {
            Pessoa = pessoa;
            Mensagem = mensagem;
        }

        public Pessoa Pessoa { get; set; }
        public string Mensagem { get; set; }

        public void update()
        {
            //simular envio de email para assinante
            Console.WriteLine($"Enviando e-mail para {Pessoa.Email}\n");
            Console.WriteLine($"Prezado {Pessoa.Nome}\n{Mensagem}");

            Console.WriteLine($" insert into tb_notificacao(pessoaId, notificado, mes) VALUES ({Pessoa.Id}, 1, {DateTime.Now.Month})");

        }
    }
}
