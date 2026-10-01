using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Digite a quantidade de raios: ");
        n = int.Parse(Console.ReadLine());

        // Matriz para marcar os quadrantes que já receberam raio
        int[,] matriz = new int[5, 8];

        int repetiu = 0;

        // Lê as coordenadas dos raios
        for (int i = 0; i < n; i++)
        {
            int x;
            int y;

            Console.Write("Digite X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite Y: ");
            y = int.Parse(Console.ReadLine());

            // Verifica se esse quadrante já foi usado
            if (matriz[y, x] == 1)
            {
                repetiu = 1;
            }
            else
            {
                // Marca o quadrante como ocupado
                matriz[y, x] = 1;
            }
        }

        // Mostra 1 se houve repetição ou 0 se não houve
        Console.WriteLine(repetiu);
    }
}