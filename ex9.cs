using System;

class Program
{
    static void Main()
    {
        int linhas;
        int colunas;

        Console.Write("Digite o número de regiões: ");
        linhas = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de cidades: ");
        colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, colunas];

        Random aleatorio = new Random();

        // Preenche a matriz com valores de 0 a 100
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] = aleatorio.Next(0, 101);
            }
        }

        Console.WriteLine("\nMatriz das Tropas:");

        // Mostra a matriz
        for (int i = 0; i < linhas; i++)
        {
            Console.Write("Região " + (i + 1) + ": ");

            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nForça Total das Regiões:");

        // Soma cada linha
        for (int i = 0; i < linhas; i++)
        {
            int soma = 0;

            for (int j = 0; j < colunas; j++)
            {
                soma = soma + matriz[i, j];
            }

            Console.WriteLine("Região " + (i + 1) + ": " + soma + " tropas");
        }
    }
}