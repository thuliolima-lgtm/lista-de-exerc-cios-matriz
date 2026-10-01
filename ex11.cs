using System;

class Program
{
    static void Main()
    {
        int tamanho;

        Console.Write("Digite o tamanho da matriz: ");
        tamanho = int.Parse(Console.ReadLine());

        int[,] matriz = new int[tamanho, tamanho];

        Random aleatorio = new Random();

        // Preenche a matriz com valores de 1 a 100
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                matriz[i, j] = aleatorio.Next(1, 101);
            }
        }

        Console.WriteLine("\nMapa do Tesouro:");

        // Mostra a matriz
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }

            Console.WriteLine();
        }

        int somaPrincipal = 0;
        int somaSecundaria = 0;

        // Soma as duas diagonais
        for (int i = 0; i < tamanho; i++)
        {
            somaPrincipal = somaPrincipal + matriz[i, i];

            somaSecundaria =
                somaSecundaria + matriz[i, tamanho - 1 - i];
        }

        Console.WriteLine("\nSoma da Diagonal Principal: " + somaPrincipal);
        Console.WriteLine("Soma da Diagonal Secundária: " + somaSecundaria);

        // Compara as duas somas
        if (somaPrincipal > somaSecundaria)
        {
            Console.WriteLine("O maior tesouro está na diagonal principal!");
        }
        else if (somaSecundaria > somaPrincipal)
        {
            Console.WriteLine("O maior tesouro está na diagonal secundária!");
        }
        else
        {
            Console.WriteLine("As duas diagonais possuem a mesma quantidade!");
        }
    }
}