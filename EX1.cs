using System;

class Program
{
    static int maiorValor(int[,] matriz)
    {
        // Começa considerando o primeiro valor como o maior
        int maior = matriz[0, 0];

        // Percorre as linhas
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            // Percorre as colunas
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                // Verifica se encontrou um valor maior
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }
        }

        // Retorna o maior valor
        return maior;
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
        int maior = maiorValor(matriz);

        Console.WriteLine("Maior valor: " + maior);
    }
}