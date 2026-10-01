using System;

class Program
{
    static int menorValor(int[,] matriz)
    {
        // Começa considerando o primeiro valor como o menor
        int menor = matriz[0, 0];

        // Percorre as linhas
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            // Percorre as colunas
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                // Verifica se encontrou um valor menor
                if (matriz[i, j] < menor)
                {
                    menor = matriz[i, j];
                }
            }
        }

        // Retorna o menor valor
        return menor;
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

        // Chama a função
        int menor = menorValor(matriz);

        Console.WriteLine("Menor valor: " + menor);
    }
}