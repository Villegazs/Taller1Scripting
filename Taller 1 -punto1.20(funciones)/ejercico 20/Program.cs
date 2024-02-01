using System.Collections.Generic;
using System.Globalization;

namespace ejercico_20
{

  internal class Program
  {
            static void Main(string[] args)
            {
        
              int[,] numbers = new int [5,4];
              Fillnumbers(numbers);
              Console.WriteLine("ingrese el nuemero que desea buscar");
              int numSearch=Convert.ToInt32(Console.ReadLine());
              List < Tuple<int, int> > indexFound= SearchIndex(numbers, numSearch);
              Console.WriteLine("el numero "+ numSearch+" se encontro en las pocisiones");
              for (int i = 0; i < indexFound.Count; i++)
              {
                Console.WriteLine($" {indexFound[i].Item1},{indexFound[i].Item2}");
              }

            //ReadNumbers(numbers);

            }


            static int[,] Fillnumbers(int[,] matrix)
            {
                Random random = new Random();
                
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                    matrix[i, j] =random.Next(10);
                    }
                }

                return matrix;
            }

        static List<Tuple<int, int>> SearchIndex(int[,] matrixSI, int num)
        {

            int rows = matrixSI.GetLength(0);
            int cols = matrixSI.GetLength(1);
            List<Tuple<int, int>> index = new List<Tuple<int, int>>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrixSI[i, j] == num)
                    {
                        index.Add(new Tuple<int, int>(i, j));

                    }
                }
            }

            return index ;

        }

        static void ReadNumbers(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " en la pocicion "+i+","+j+"\n");
                }
                Console.WriteLine();
            }
           
        }
  }
}
