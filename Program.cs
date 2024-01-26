using System;

namespace pooMaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1;
            Pessoa p2;
            Pessoa p3;

            Console.WriteLine("Determina qual pessoa é a mais velha.");

            //primeirapessoa
            Console.Write("Nome da 1 pessoa:  ");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine();
            Console.Write("Idade da 1 pessoa:  ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            //segundapessoa
            Console.Write("Nome da 2 pessoa:  ");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();
            Console.Write("Idade da 2 pessoa:  ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            //segundapessoa
            Console.WriteLine("Nome da 3 pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Idade da 3 pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            p3 = new Pessoa(nome, idade);


            //Logica

            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é:  ");
                p1.ExibirDados();
            }
            else
            {
                if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
                {
                    Console.WriteLine("A pessoa mais velha é:  ");
                    p2.ExibirDados();
                }
                else
                {
                    Console.WriteLine("A pessoa mais velha é:  ");
                    p3.ExibirDados();
                }
            }
        }
    }
}
