using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Animais_de_Estimação
{
    public class Animal
    {
        private string nome;

        public  string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set {//TRATANDO A ENTRADA DE DADOS 
                    if (value == "CACHORRO" || value == "GATO" || value == "PEIXE")
                    {
                         tipo = value.ToUpper();
                    }
                    else
                    {
                    tipo = "PEIXE";
                    }
            }
        }

    }
}
