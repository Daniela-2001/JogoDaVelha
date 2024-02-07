internal class Program
{
    private static void Main(string[] args)
    {
        string[,] matriz = new string[3,3];

        //Alimentando a matriz 

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = "0";
            }
        }

        //Imprimir a matriz 
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine($" [{matriz[i, j]}] ");
            }

            Console.WriteLine();
        }
    }
}