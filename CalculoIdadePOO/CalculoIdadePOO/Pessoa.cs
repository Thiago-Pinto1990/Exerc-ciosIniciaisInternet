using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIdadePOO
{
    public class Pessoa
    {
        private int ano_nascimento;//criando a variável do ano de nascimento. Variável é PRIVADA. Estamos ENCAPSULANDO

        public int Ano_nascimento//criando a propriedade(ATRIBUTO). Propriedade é PÚBLICA
        {
            get { return ano_nascimento; }
            set { ano_nascimento = value; }
        }

        private string nome;//criando a variável nome. Variável é PRIVADA. Estamos ENCAPSULANDO

        public string Nome//criando a propriedade(ATRIBUTO). Propriedade é PÚBLICA
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        //DEFINI OS ATRIBUTOS, AGORA VOU CRIAR UM MÉTODO/FUNÇÃO PARA EXIBIR AS INFORMAÇÕES QUE PRECISO, NOME E IDADE

        public void ExibirDados()
        {
            int idade = CalcularIdade();//CRIEI UM VARIÁVEL QUE TBM TEM O NOME IDADE, E ESTA ESTÁ RECENDO O RETURN(OQ SAIR) DO MÉTODO CALCULARIDADE
            Console.WriteLine("Nome: " + Nome);//PERCEBA QUE PEGUEI O VALOR DA PROPRIEDADE, NÃO PEGUEI O VALOR DA VARIÁVEL DIRETAMENTE
            Console.WriteLine("Ano de Nascimento: " + Ano_nascimento);//MESMO COMENTÁRIO DE CIMA, PEGUEI O VALOR DA PROPRIEDADE
            Console.WriteLine("Idade: " + idade);//AINDA NÃO SEI A IDADE
        }

        //AGORA VAMOS CRIAR UM MÉTODO PRIVADO PARA CALCULAR A IDADE, PRIVADO QUER DIZER QUE SÓ ESTA CLASSE VAI INTERAGIR COM O MÉTODO.

        private int CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            int idade = ano - Ano_nascimento;//USANDO O MÉTODO, NÃO A VARIÁVEL DIRETAMENTE.
            return idade;
        }


    }
}
