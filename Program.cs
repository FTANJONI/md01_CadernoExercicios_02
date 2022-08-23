using System;

namespace md01_CadernoExercicios_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. Faça um algoritmo que:
            a) Leia o nome;
            b) Leia o sobrenome;
            c) Concatene o nome com o sobrenome;
            d) Apresente o nome completo.
            */
            string nome, sobrenome;

            Console.WriteLine("\nDigite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("\nDigite seu sobrenome:");
            sobrenome = Console.ReadLine();

            Console.WriteLine("'\nOlá " + nome + " " + sobrenome + "\nSeja Bem-vindo ao Sistema!");
            
        }
    }
}
