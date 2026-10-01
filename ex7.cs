using System;

class Program
{
    // Soma duas matrizes se elas tiverem a mesma ordem
    static void somarMatrizes(int[,] matriz1, int[,] matriz2)
    {
        int linhas1 = matriz1.GetLength(0);
        int colunas1 = matriz1.GetLength(1);

        int linhas2 = matriz2.GetLength(0);
        int colunas2 = matriz2.GetLength(1);

        // Verifica se as matrizes possuem o mesmo tamanho
        if (linhas1 != linhas2 || colunas1 != colunas2)
        {
            Console.WriteLine("As matrizes não possuem a mesma ordem.");
            return;
        }

        // Soma as duas matrizes
        for (int i = 0; i < linhas1; i++)
        {
            for (int j = 0; j < colunas1; j++)
            {
                Console.Write(matriz1[i, j] + matriz2[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] matriz1 = new int[2, 3];
        int[,] matriz2 = new int[2, 3];

        // Preenche a primeira matriz
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Matriz 1: ");
                matriz1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Preenche a segunda matriz
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Matriz 2: ");
                matriz2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Chama a função
        somarMatrizes(matriz1, matriz2);
    }
}