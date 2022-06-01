using Aula6.Fiap.Exceptions;
using Aula6.Fiap.Services;
using System;

namespace Aula6.Fiap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Digite sua idade:");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine($"A idade é {idade}");
            }
            catch (FormatException) // Capturar a exception e o tratamento
            {
                Console.WriteLine("Número inválido");

            }
            catch (Exception)
            {
                Console.WriteLine("Erro genérico");

            }
            finally // O bloco Finally é sempre executado
            {
                Console.WriteLine("Este bloco é sempre executado");
            }

            // Instanciando um novo tipo de IMessagem
            IMessagem service = new MensagemEmail();

            IMessagem service2 = new MensagemSms();

            //Ler mensagem do usuário
            Console.WriteLine($"Digite sua mensagem de email:");
            var msg = Console.ReadLine();

            try //  Chamar o método para enviar uma mensagem
            {
                service.EnviarMensagem(msg);

            }
            catch (InvalidMessageException)
            {
                Console.WriteLine("MENSAGEM INVALIDA!!");
            }

            Console.WriteLine($"Digite sua mensagem de texto:");
            var msg2 = Console.ReadLine();

            try //  Chamar o método para enviar uma mensagem
            {
                service2.EnviarMensagem(msg2);

            }
            catch (InvalidMessageException)
            {
                Console.WriteLine("MENSAGEM INVALIDA!!");
            }

        }
    }
}
