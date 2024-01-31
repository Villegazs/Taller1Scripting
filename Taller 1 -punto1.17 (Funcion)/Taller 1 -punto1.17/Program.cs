namespace Taller_1__punto1._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = {
                {2, 3, 1, 5, 0, 3},
                {1, 2, 1, 2, 6, 6},
                {4, 6, 9, 3, 1, 5},
                {2, 8, 4, 4, 2, 1},
                {7, 1, 2, 6, 7, 3}
            };
            
            Console.WriteLine("Matriz original:");
            ImprimirMatriz(matriz);

            InvertirColumnas(matriz);

            Console.WriteLine("\n" + "Matriz con columnas invertidas:");
            ImprimirMatriz(matriz);

            static void InvertirColumnas(int[,] matriz)
            {
                int filas = matriz.GetLength(0); // Dimension 1 matriz
                int columnas = matriz.GetLength(1); //Dimension 2 matriz

                for (int i = 0; i < filas; i++)
                {
                    int columnaInicio = 0;
                    int columnaFin = columnas - 1;

                    
                    while (columnaInicio < columnaFin)
                    {
                        int temp = matriz[i, columnaInicio]; // Variable para intercambiar columna inicio con fin
                        matriz[i, columnaInicio] = matriz[i, columnaFin]; // Fin con inicio
                        matriz[i, columnaFin] = temp; // Asignacion de variable para el intercambio columna final
                        columnaInicio++;
                        columnaFin--;
                    }
                }
            }
            
            static void ImprimirMatriz(int[,] matriz)
            {
                int filas = matriz.GetLength(0);
                int columnas = matriz.GetLength(1);

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
