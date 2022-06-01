using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6.Fiap.Services
{
    interface IMessagem
    {
        void EnviarMensagem(string msg);

        void EnviarMensagem(string msg, string assunto);

    }
}
