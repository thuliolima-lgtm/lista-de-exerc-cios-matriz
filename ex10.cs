using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Digite a quantidade de redes: ");
        n = int.Parse(Console.ReadLine());

        int[,] redes = new int[n, 4];

        int maiorX = 0;
        int maiorY = 0;

        // Lê as coordenadas das redes
        for (int i = 0; i < n; i++)
        {
            Console.Write("Xi: ");
            redes[i, 0] = int.Parse(Console.ReadLine());

            Console.Write("Xf: ");
            redes[i, 1] = int.Parse(Console.ReadLine());

            Console.Write("Yi: ");
            redes[i, 2] = int.Parse(Console.ReadLine());

            Console.Write("Yf: ");
            redes[i, 3] = int.Parse(Console.ReadLine());

            // Guarda os maiores valores
            if (redes[i, 1] > maiorX)
            {
                maiorX = redes[i, 1];
            }

            if (redes[i, 3] > maiorY)
            {
                maiorY = redes[i, 3];
            }
        }

        int[,] mar = new int[maiorY, maiorX];

        // Percorre cada rede
        for (int i = 0; i < n; i++)
        {
            int xi = redes[i, 0];
            int xf = redes[i, 1];
            int yi = redes[i, 2];
            int yf = redes[i, 3];

            // Percorre a área da rede
            for (int y = yi; y < yf; y++)
            {
                for (int x = xi; x < xf; x++)
                {
                    // Marca somente se ainda não estiver marcado
                    mar[y, x] = 1;
                }
            }
        }

        int area = 0;

        // Conta as posições cobertas
        for (int i = 0; i < maiorY; i++)
        {
            for (int j = 0; j < maiorX; j++)
            {
                if (mar[i, j] == 1)
                {
                    area = area + 1;
                }
            }
        }

        Console.WriteLine("Área aproveitada: " + area);
    }
}