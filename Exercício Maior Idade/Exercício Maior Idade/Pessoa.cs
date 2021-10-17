using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Maior_Idade
{
    public class Pessoa
    {
        private string nome;

        public  string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        //IMPLEMENTANDO UM CONSTRUTOR

        public Pessoa(string nome_maior_idade = null , int maior_idade = 0)
        {
            if(Idade >= maior_idade)
            {
                maior_idade = Idade;
                nome_maior_idade = Nome;
            }
            

        }

        //CRIANDO MÉTODO EXIBIR DADOS

        public void ExibirDados()
        {
            Console.WriteLine("O Mais Velho é: " + Nome);
            Console.WriteLine("Idade: " + Idade);
        }


    }
}
