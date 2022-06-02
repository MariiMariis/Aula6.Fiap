using Aula6.Fiap.Ex4.Services;
using Aula6.Fiap.Ex4.Models;
using System;

namespace Aula6.Fiap.Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando um novo objeto do tipo Retangulo, à partir da classe Retangulo
            Retangulo retangulo = new Retangulo();
            //Chama o método calcular área
            retangulo.CalcularArea();

            //Instanciando um novo objeto do tipo Quadrado, à partir da classe Quadrado
            Quadrado quadrado = new Quadrado();
            //Chama o método calcular área
            quadrado.CalcularArea();

        }
    }
}
