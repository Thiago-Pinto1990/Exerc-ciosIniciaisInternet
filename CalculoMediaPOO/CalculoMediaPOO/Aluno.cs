using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoMediaPOO
{
    public class Aluno
    {
        //CRIANDO MÉTODO DE ACESSO PARA O NOME DO ALUNO
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }
        //CRIANDO MÉTODO DE ACESSO PARA A NOTA1
        private float nota1;

        public float Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }
        //CRIANDO MÉTODO DE ACESSO PARA A NOTA2
        private float nota2;

        public float Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }
        //CRIANDO MÉTODO DE ACESSO PARA A NOTA3
        private float nota3;

        public float Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }
        //CRIANDO UM MÉTODO PARA CALCULAR A MÉDIA
        private float CalcularMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }
        //CRIANDO UM MÉTODO PARA ANALISAR A SITUAÇÃO DO ALUNO
        private string AnalisarSituacao()
        {
            string situacao = null;
            if(CalcularMedia() >= 7)
            {
                situacao = "Parabéns. Aluno Aprovado !";
            }
            else
            {
                situacao = "Aluno Reprovado !";
            }

            return situacao;
        }
        //CRIANDO UM MÉTODO PARA EXIBIR AS INFORMAÇÕES
        public void ExibirDados()
        {
            Console.WriteLine("Nome do Aluno: " + Nome);
            Console.WriteLine("Média Final: " + CalcularMedia());
            Console.WriteLine("Situação Final do Aluno: " + AnalisarSituacao());
            
        }
    }
}
