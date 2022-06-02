using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6.Fiap.Ex3.Models
{
    public class Funcionario
    {
        public Funcionario()
        {
            Console.WriteLine("Construtor invocado.");
        }

        ~Funcionario()
        {
            Console.WriteLine("Finalizador invocado");
        }
    }
}
