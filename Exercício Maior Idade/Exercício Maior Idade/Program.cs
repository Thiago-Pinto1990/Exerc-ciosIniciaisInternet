using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Maior_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa interacao = new Pessoa();
            for(int contador = 1; contador <= 3; contador++)
            {
                Console.Write("Digite o Nome: ");
                interacao.Nome = Console.ReadLine();
                Console.Write("Digite a Idade: ");
                interacao.Idade = Convert.ToInt32(Console.ReadLine());
            }

            //CHAMANDO O MÉTODO EXIBIR DADOS
            interacao.ExibirDados();
            Console.ReadLine();
        }
    }
}
