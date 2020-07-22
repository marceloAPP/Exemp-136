using System;
using System.Collections.Generic;
using System.Globalization;
using Exemp_136.Entities;
using Exemp_136.Entities.Enums;

namespace Exemp_136
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> listaFigura = new List<Figura>();
                
            Console.WriteLine("Digite o número de formas:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Dados da forma nº {i}: ");
                Console.Write("Retângulo ou círculo(R / C) ? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Cor (preto / azul / vermelho): ");
                Cores cor = (Cores)Enum.Parse(typeof(Cores), Console.ReadLine());

                if (ch == 'R')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Retangulo: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listaFigura.Add(new Retangulo(largura, altura, cor));

                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listaFigura.Add(new Circulo(raio, cor));
                }

            }

            Console.WriteLine("\nÁREA DA FIGURA");
            foreach (var item in listaFigura)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

