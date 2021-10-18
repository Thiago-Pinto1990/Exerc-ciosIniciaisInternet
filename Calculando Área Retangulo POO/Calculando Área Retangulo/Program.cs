using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_Área_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo_Quadrado interacao = new Retangulo_Quadrado();//INSTANCIANDO O OBJETO INTERAÇÃO
            
            Console.WriteLine("PROGRAMA PARA CALCULAR ÁREA DO RETANGULO");
            Console.Write("DIGITE O VALOR DO LADO DO RETANGULO: ");
            interacao.Lado = float.Parse(Console.ReadLine());//RECEBENDO O LADO DO RETANGULO
            while(interacao.Lado <= 0)//VALIDANDO O VALOR RECEBIDO. OBS: ESTA VALIDAÇÃO PODERIA TER SIDO FEITO NO MÉTODO DE ACESSO, MAS AINDA NÃO SEI.
            {
                Console.WriteLine("VALOR INVÁLIDO !");
                Console.Write("DIGITE O VALOR DO LADO DO RETANGULO: ");
                interacao.Lado = float.Parse(Console.ReadLine());
            }
            
            
            Console.Write("DIGITE O VALOR DA ALTURA DO RETANGULO: ");
            interacao.Altura = float.Parse(Console.ReadLine());//RECEBENDO A ALTURA DO RETANGULO
            while(interacao.Altura <= 0)//VALIDANDO
            {
                Console.WriteLine("VALOR INVÁLIDO !");
                Console.Write("DIGITE O VALOR DA ALTURA DO RETANGULO: ");
                interacao.Altura = float.Parse(Console.ReadLine());
            }
            
            
            interacao.ExibirDados();//CHAMANDO O MÉTODO "EXIBIRDADOS"
            Console.ReadLine();

        }
    }
}
