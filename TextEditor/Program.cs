// See https://aka.ms/new-console-template for more information
using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Olá, seja bem vindo(a)");
            Console.WriteLine("Opções: ");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("O que Você deseja fazer?");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        static void Open()
        {

        }

        static void Edit()
        {

        }
    }
}
