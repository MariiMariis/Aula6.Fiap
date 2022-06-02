using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6.Fiap.Ex4.Services
{
    // Um interface, quando herdada por uma classe, deve implementar todos os seu membros
    //Conveção de nomenclatura para interfaces: Com "I" maiúsculo na frente do nome
    interface IPoligono
    {
        //método sem corpo - sem retorno (return)
        void CalcularArea();
    }
}
