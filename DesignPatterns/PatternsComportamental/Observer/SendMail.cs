using DesignPatterns.PatternsComportamental.Observer.Interfaces;
using DesignPatterns.PatternsComportamental.Observer.Observers;
using DesignPatterns.PatternsComportamental.Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Observer
{
    public class SendMail
    {
        public void EnviarEmail()
        {
            string msgNaoAssinante = $"Notamos que ainda não faz parte da nossa plataforma de series e filmes." +
                $"\nPromoção válida até {DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)}.";

            string msgAssinante = $"Lançamentos para o mês {DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)}" +
                $" direto do cinema para sua tela.";

            List<IObservavel> observaveis = new List<IObservavel>()
            {
                new NaoAssinante(new Model.Pessoa(1, "José", "jose@gmail.com"), msgNaoAssinante),
                new NaoAssinante(new Model.Pessoa(2, "Maria", "maria@gmail.com"), msgNaoAssinante),
                new Assinante(new Model.Pessoa(3, "Daiani", "daiani@gmail.com"), msgAssinante),
                new Assinante(new Model.Pessoa(4, "Felipe", "felipe@gmail.com"), msgAssinante)
            };

            PrimeVideos primeVideos = new PrimeVideos();

            foreach (var observavel in observaveis)
            {
                primeVideos.AddObervavel(observavel);
            }

            primeVideos.NotificarObservavel();
        }
    }
}
