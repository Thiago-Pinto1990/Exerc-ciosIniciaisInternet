using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Animais_de_Estimação
{
    class Program
    {
        static void Main(string[] args)
        {
            int tlcachorro = 0 , tlgato = 0 , tlpeixe = 0;
           
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            
            Console.Write("INFORME O NOME DO ANIMAL 1: ");
            a1.Nome = Console.ReadLine().ToUpper();
            Console.Write("INFORME O TIPO DO ANIMAL 1: ");
            a1.Tipo = Console.ReadLine().ToUpper();

            if (a1.Tipo == "CACHORRO") tlcachorro ++;
            if (a1.Tipo == "GATO") tlgato ++;
            if (a1.Tipo == "PEIXE") tlpeixe ++;


            Console.Write("INFORME O NOME DO ANIMAL 2: ");
            a2.Nome = Console.ReadLine().ToUpper();
            Console.Write("INFORME O TIPO DO ANIMAL 2: ");
            a2.Tipo = Console.ReadLine().ToUpper();

            if (a2.Tipo == "CACHORRO") tlcachorro++;
            if (a2.Tipo == "GATO") tlgato++;
            if (a2.Tipo == "PEIXE") tlpeixe++;


            Console.Write("INFORME O NOME DO ANIMAL 3: ");
            a3.Nome = Console.ReadLine().ToUpper();
            Console.Write("INFORME O TIPO DO ANIMAL 3: ");
            a3.Tipo = Console.ReadLine().ToUpper();

            if (a3.Tipo == "CACHORRO") tlcachorro++;
            if (a3.Tipo == "GATO") tlgato++;
            if (a3.Tipo == "PEIXE") tlpeixe++;


            Console.Write("INFORME O NOME DO ANIMAL 4: ");
            a4.Nome = Console.ReadLine().ToUpper();
            Console.Write("INFORME O TIPO DO ANIMAL 4: ");
            a4.Tipo = Console.ReadLine().ToUpper();

            if (a4.Tipo == "CACHORRO") tlcachorro++;
            if (a4.Tipo == "GATO") tlgato++;
            if (a4.Tipo == "PEIXE") tlpeixe++;


            Console.Write("INFORME O NOME DO ANIMAL 5: ");
            a5.Nome = Console.ReadLine().ToUpper();
            Console.Write("INFORME O TIPO DO ANIMAL 5: ");
            a5.Tipo = Console.ReadLine().ToUpper();

            if (a5.Tipo == "CACHORRO") tlcachorro++;
            if (a5.Tipo == "GATO") tlgato++;
            if (a5.Tipo == "PEIXE") tlpeixe++;


            Console.WriteLine("CONTROLE DE ANIMAIS");
            Console.WriteLine("CACHORRO: " + tlcachorro + "\nGATO: " + tlgato + "\nPEIXE: " + tlpeixe);
            Console.ReadLine();

        }
    }
}
