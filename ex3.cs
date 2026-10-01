using System;

class Program
{
    static void Main()
    {
        int tamanho;

        Console.Write("Digite o tamanho da matriz: ");
        tamanho = int.Parse(Console.ReadLine());

        int[,] matriz = new int[tamanho, tamanho];

        // Preenche a matriz
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Diagonal principal:");

        // Mostra a diagonal principal
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine(matriz[i, i]);
        }
    }
}