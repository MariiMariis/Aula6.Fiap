using Aula6.Fiap.Ex2.Models;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Aula6.Fiap.Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando lista para armazenar os alunos - Listas
            IList<Aluno> lista = new List<Aluno>();

            do
            {
                //Ler dados dos aluno
                Console.WriteLine("Digite o nome do aluno:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a média do aluno:");
                float media = float.Parse(Console.ReadLine());

                //(Genero) -> casting -> força o objeto a ser de um determinado tipo
                // Enum.Parse -> Tipo do Enum, String para conversão, e não diferencia maiúsculo de minusculos
                Console.WriteLine("Digite o gênero do aluno:");
                Genero genero = (Genero)Enum.Parse(typeof(Genero), Console.ReadLine(), true);


                // Instanciando um aluno
                var aluno = new Aluno()
                {
                    Nome = nome,
                    Media = media,
                    Genero = genero
                };

                //Adicionando cada um dos alunos cadastrados na lista
                lista.Add(aluno);

                //Verifica se deseja continuar o cadastro dos alunos
                Console.WriteLine("Deseja adicionar mais algum aluno? (S/N)");

            } while (Console.ReadLine().ToUpper() == "S");

            // Exibir a quantidade de alunos cadastrados
            //Método Count, conta quantos elementos existem em uma lista
            Console.WriteLine($"A quantidade de aluno é: \n {lista.Count} alunos");

            //Somar as médias dos alunos
            float mediaTotal = 0;
            foreach (var item in lista)
            {
                mediaTotal += item.Media;
            }

            // Exibir a média das notas
            Console.WriteLine($"A média geral dos alunos é: {mediaTotal/lista.Count}");
            //Console.WriteLine($"A média total dos alunos é: {lista.Average( a => a.Media ).ToString("n2")}");

            //Exibindo o percentual de alunos por gênero

            Console.WriteLine("O percentual de alunos do gênero Feminino:" + 
                $"{((float) lista.Count(a => a.Genero == Genero.Feminino)/lista.Count).ToString("p")}");
            Console.WriteLine("O percentual de alunos do gênero Masculino:" +
                $"{((float)lista.Count(a => a.Genero == Genero.Masculino) / lista.Count).ToString("p")}");
            Console.WriteLine("O percentual de alunos de outros gêneros:" +
                $"{((float)lista.Count(a => a.Genero == Genero.Outros) / lista.Count).ToString("p")}");

            int op;

            do
            {
                Console.WriteLine("Escolha uma das opções:\n1- Nomes e médias \n2-Médias acima de 6 \n3- Nome por gênero \n0-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        foreach (var item in lista)
                        {
                            Console.WriteLine($"Nome: {item.Nome} - Média: {item.Media}");
                        }
                        break;
                    case 2:
                        // Coloca em uma lista chamada listaFiltrada todos os aluno que possuem média acima de 6
                        var listaFiltrada = lista.Where(a => a.Media > 6).ToList();
                        foreach (var item in listaFiltrada)
                        {
                            Console.WriteLine($"Nome: {item.Nome} - Média: {item.Media}");
                        }
                        break;
                    case 3:
                        //Ler o gênero informado pelo usuário
                        Console.WriteLine("Digite o gênero:");
                        Genero genero = (Genero)Enum.Parse(typeof(Genero), Console.ReadLine(), true);
                        //Filtrar as listas por gênero
                        listaFiltrada = lista.Where(a => a.Genero == genero).ToList();

                        //Exibe lista filtrada
                        foreach (var item in listaFiltrada)
                        {
                            Console.WriteLine($"Nome: {item.Nome} - Média: {item.Genero}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Finalizando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!!");
                        break;
                }

            } while (op != 0);
        }
    }
}
