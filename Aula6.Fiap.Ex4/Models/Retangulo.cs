using Aula6.Fiap.Ex4.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6.Fiap.Ex4.Models
{
    //Implementação da interface IPoligono na classe Retangulo
    class Retangulo : IPoligono
    {
        //Chamando métodos da interface
        public void CalcularArea()
        {
            int h = 30;
            int b = 90;
            int area = h * b;
            Console.WriteLine($"Area de um retângulo de {h} de altura por {b} de base = {area}");
        }
    }
}
