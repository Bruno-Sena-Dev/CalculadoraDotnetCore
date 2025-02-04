﻿using System;

namespace Calculator
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
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicacao");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------");
            Console.WriteLine("Selecione uma opção: ");
            short resultado = short.Parse(Console.ReadLine());

            switch (resultado)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtração é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o Seu primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da Divisão é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            var v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            var v2 = float.Parse(Console.ReadLine());

            var resultado = v1 * v2;

            Console.WriteLine("");

            Console.WriteLine($"O Resultado da Multiplicação é: {resultado}");

            Console.ReadKey();
            Menu();
        }
    }

}