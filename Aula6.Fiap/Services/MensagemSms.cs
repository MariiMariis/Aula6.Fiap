using Aula6.Fiap.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6.Fiap.Services
{
    class MensagemSms : IMessagem
    {
        public void EnviarMensagem(string msg)
        {
            if (msg.Length > 300)
            {
                throw new InvalidMessageException();
            }
            Console.WriteLine($"Enviando um SMS com a mensagem: \n {msg}");
        }

        public void EnviarMensagem(string msg, string assunto)
        {
            Console.WriteLine($"Enviando um SMS com assunto - {assunto} \n Mensagem: {msg}");
        }
    }
}
