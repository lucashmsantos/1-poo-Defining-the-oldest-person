using System;

namespace pooMaiorIdade
{
    public class Pessoa  /*Para poder usar em qualquer lugar do programa ou outro projeto*/
    {
        //Construtores
        public Pessoa()
        {
            this.Nome = " ";
            this.Idade = 0;
        }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        //Propriedades
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }  /*Guardar o valor em Maiusculo*/
        }

        private int idade;   /*Garantir que nao vai existir valor negativo*/
        public int Idade {
            get { return idade; }
            set {
            if (value >= 0)
                {
                    idade = value;
                }
                else
                {
                    this.idade = 0;
                }
            }
        
        }   /*Pega o Valor e armazena o valor*/

        //Metodos
        public void ExibirDados()  /*Nao retorna valor algum*/
        {
            Console.WriteLine("Nome:  " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
        }
    }
}
