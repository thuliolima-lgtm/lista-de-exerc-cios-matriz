using System;

class Program
{
    // Soma duas matrizes
    static double[,] somar(double[,] matriz1, double[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);

        double[,] resultado = new double[linhas, colunas];

        // Percorre as duas matrizes
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return resultado;
    }

    // Subtrai a primeira matriz da segunda
    static double[,] subtrair(double[,] matriz1, double[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);

        double[,] resultado = new double[linhas, colunas];

        // Percorre as duas matrizes
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                resultado[i, j] = matriz2[i, j] - matriz1[i, j];
            }
        }

        return resultado;
    }

    // Adiciona uma constante na própria matriz
    static void adicionarConstante(double[,] matriz, double constante)
    {
        // Percorre a matriz
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = matriz[i, j] + constante;
            }
        }
    }

    // Mostra uma matriz
    static void mostrarMatriz(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        int linhas;
        int colunas;

        Console.Write("Digite o número de linhas: ");
        linhas = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de colunas: ");
        colunas = int.Parse(Console.ReadLine());

        double[,] matriz1 = new double[linhas, colunas];
        double[,] matriz2 = new double[linhas, colunas];

        // Preenche a primeira matriz
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write("Matriz 1: ");
                matriz1[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // Preenche a segunda matriz
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write("Matriz 2: ");
                matriz2[i, j] = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Adicionar constante");
        Console.WriteLine("4 - Imprimir");
        Console.Write("Escolha: ");

        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            double[,] resultado = somar(matriz1, matriz2);
            mostrarMatriz(resultado);
        }
        else if (opcao == 2)
        {
            double[,] resultado = subtrair(matriz1, matriz2);
            mostrarMatriz(resultado);
        }
        else if (opcao == 3)
        {
            double constante;

            Console.Write("Digite a constante: ");
            constante = double.Parse(Console.ReadLine());

            adicionarConstante(matriz1, constante);
            adicionarConstante(matriz2, constante);

            mostrarMatriz(matriz1);
            mostrarMatriz(matriz2);
        }
        else if (opcao == 4)
        {
            mostrarMatriz(matriz1);
            Console.WriteLine();
            mostrarMatriz(matriz2);
        }
    }
}