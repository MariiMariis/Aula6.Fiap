using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6.Fiap.Ex2.Models
{
    class Aluno
    {
        // Criando as propriedades de Aluno
        public string Nome { get; set; }

        public float Media { get; set; }

        public Genero Genero { get; set; }

    }
    // Enumerate que recebe gêneros pré determinados
    public enum Genero
    {
        Feminino, Masculino, Outros
    }
}
