using Aula6.Fiap.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6.Fiap.Services
{
    class MensagemEmail : IMessagem
    {

        public void EnviarMensagem(string msg)
        {
            if(msg.Length < 10)
            {
                throw new InvalidMessageException();
            }
            Console.WriteLine($"Enviando email com a seguinte mensagem: \n {msg}");
        }

        public void EnviarMensagem(string msg, string assunto)
        {
            Console.WriteLine($"Enviando email com assunto {assunto} e mensagem {msg}");
        }
    }
}
