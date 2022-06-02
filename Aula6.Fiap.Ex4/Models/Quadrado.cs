using Aula6.Fiap.Ex4.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6.Fiap.Ex4.Models
{
    // Implementação da interface IPoligono
    class Quadrado : IPoligono
    {
        public void CalcularArea()
        {
            int l = 30;
            int area = l * l;
            Console.WriteLine($"Area de um quadrado de {l} de lado: {area}");
        }
    }
}
