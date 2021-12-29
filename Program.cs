using ProjetoElevador.Models;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicita a informação de quantos andares existem.
            Console.WriteLine("Informe quantos andares existem no prédio?");
            int qtdeAndares = int.Parse(Console.ReadLine());
            //Solcita a quantidade de pessoas que o elevador suporta.
            Console.WriteLine("Informe quantas pessoas o elevador suporta?");
            int qtdePessoasCapacidade = int.Parse(Console.ReadLine());

            Elevador elevador = new Elevador();
            //Passa a informações de andares e quantidade de pessoas para a classe Elevador
            elevador.Inicializar(qtdeAndares, qtdePessoasCapacidade);
            Console.Clear();

            bool opcao = true;
            do
            {
                //Opções de escolha para o usuário
                Console.WriteLine(@"Escolha uma opção:
                                1 - Entrar
                                2 - Sair
                                3 - Subir
                                4 - Descer
                                5 - Encerrar o sistema
                                ");
                string opcaoEscolhida = Console.ReadLine();
                Console.Clear();

                switch (opcaoEscolhida)
                {
                    case "1": elevador.Entrar(); break;
                    case "2": elevador.Sair(); break;
                    case "3": elevador.Subir(); break;
                    case "4": elevador.Descer(); break;
                    case "5": opcao = false; break;
                    default: Console.WriteLine("Escolha incorreta"); break;
                }
            } while (opcao);
        }
    }
}
