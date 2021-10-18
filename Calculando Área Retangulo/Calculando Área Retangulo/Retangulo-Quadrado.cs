using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_Área_Retangulo
{
    public class Retangulo_Quadrado//CLASSE CRIADA PARA RECEBER AS PROPRIEDADES DO RETANGULO
    {
        private float lado;//CRIANDO UM MÉTODO DE ACESSO PARA O VALOR "LADO" E ENCAPSULANDO A MESMA

        public float Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        private float altura;//CRIANDO UM MÉTODO DE ACESSO PARA  O VALOR "ALTURA"E ENCAPSULANDO A MESMA

        public float Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        //VOU CRIAR UM CONSTRUTOR QUE RECEBERÁ OS DOIS PARÂMETROS

        public Retangulo_Quadrado(float lado = 0 , float altura = 0)
        {
            this.Lado = lado;
            this.Altura = altura;
        }

        //CRIANDO MÉTODO PARA EXIBIR DADOS

        public void ExibirDados()
        {
            Console.Write("A Área é: " + CalcularArea());
        }

        //CRIANDO UM MÉTODO PARA CALCULAR A ÁREA
        private float CalcularArea()
        {
            return Lado * Altura;
        }

    }
}
