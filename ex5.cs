using System;

class Program
{
    static int contarX(int[,] matriz, int x)
    {
        int quantidade = 0;

        // Percorre as linhas
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            // Percorre as colunas
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                // Verifica se encontrou X
                if (matriz[i, j] == x)
                {
                    quantidade = quantidade + 1;
                }
            }
        }

        // Retorna a quantidade de vezes que X apareceu
        return quantidade;
    }

    static void Main()
    {
        int[,] matriz = new int[3, 4];

        // Preenche a matriz
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("Digite um valor: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int x;

        Console.Write("Digite o valor X: ");
        x = int.Parse(Console.ReadLine());

        // Chama a função
        int quantidade = contarX(matriz, x);

        Console.WriteLine("O valor aparece " + quantidade + " vezes.");
    }
}