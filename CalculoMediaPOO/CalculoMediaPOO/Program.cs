using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoMediaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULANDO MÉDIA E SITUAÇÃO FINAL DO ALUNO");
            Aluno interacao = new Aluno();
            Console.WriteLine("Digite o Nome do Aluno: ");
            interacao.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Nota 01 do Aluno: ");
            interacao.Nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Nota 02 do Aluno: ");
            interacao.Nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Nota 03 do Aluno: ");
            interacao.Nota3 = float.Parse(Console.ReadLine());
            interacao.ExibirDados();
            Console.ReadLine();
        }
    }
}
