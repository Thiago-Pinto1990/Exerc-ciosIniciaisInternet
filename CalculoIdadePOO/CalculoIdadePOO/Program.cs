using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIdadePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a idade !");
            //MESMO QUE PRECISE MANDAR PARA CLASSE DUAS INFORMAÇÕES(NOME E ANO), APENAS O OBJETO P SERÁ USADO, APENAS ELE VAI INTERAGIR COM A CLASSE
            Pessoa p = new Pessoa();//INSTANCIANDO O OBJETO P. NESTE CASO, "PESSOA" É UM CONSTRUTOR(MÉTODO ESPECIAL QUE POSSUI O MESMO NOME DA CLASSE)
            Console.WriteLine("Digite o Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o ano de nascimento:  ");
            p.Ano_nascimento = Convert.ToInt32(Console.ReadLine());
            p.ExibirDados();
            Console.ReadLine();
            

        }
    }
}
