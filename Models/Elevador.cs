using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    internal class Elevador
    {
        int qtdeAndaresTotal;
        int qtdeCapacidadeTotal;
        int qtdePessoasAtual;
        int andarAtual;

        //Recebe as informações iniciais da capacidade do elevador e quantidades de andares
        public void Inicializar(int andares, int capacidade)
        {
            this.qtdeAndaresTotal = andares;
            this.qtdeCapacidadeTotal = capacidade;
        }

        //Controla a entrada de pessoas no elevador
        //Emite aviso se a entrada foi permitida ou já atingiu a capacidade permitida.
        public void Entrar()
        {
            if (qtdePessoasAtual < qtdeCapacidadeTotal)
            {
                qtdePessoasAtual++;
                Console.WriteLine("Entrada permitida! Capacidade maxima de pessoas é " + qtdeCapacidadeTotal + " vagas disponiveis: " + (qtdeCapacidadeTotal - qtdePessoasAtual));
            }
            else Console.WriteLine("Entrada negada! O máximo permitido é " + qtdeCapacidadeTotal);
        }
        //Controla a saída de pessoas do elevador
        //Emite aviso se a saída foi permitida ou o elevador esta vazio. 
        public void Sair()
        {

            if (qtdePessoasAtual > 0)
            {
                qtdePessoasAtual--;
                string msgSaida = qtdePessoasAtual == 0 ? "Saída permitida! Elevador esta vazio!" : "Saída permitida! Quantidade de pessoas no elevador: " + qtdePessoasAtual;
                Console.WriteLine(msgSaida);
            }
            else
                Console.WriteLine("O elevador está vazio!");
        }
        //Permite subir um andar
        //Avisa o andar atual ou se já esta no último andar.
        public void Subir()
        {
            if (andarAtual < qtdeAndaresTotal)
            {
                andarAtual++;
                Console.WriteLine("O prédio possui " + qtdeAndaresTotal + " andares. O elevador subiu para o andar: " + andarAtual);
            }
            else Console.WriteLine("Você está no último andar: " + andarAtual);

        }
        //Permite descer um andar
        //Avisa o andar atual ou se já esta no térreo.
        public void Descer()
        {
            if (andarAtual != 0)
            {
                andarAtual--;
                string msgDescer = andarAtual == 0 ? "O elevador está no térreo" : "O prédio possui " + qtdeAndaresTotal + " andares. O elevador desceu para o andar: " + andarAtual;
                Console.WriteLine(msgDescer);
            }
            else Console.WriteLine("O elevador está no térreo! ");
        }
    }
}
