namespace Taller1___punto_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int posicion = 0;
            
            var rand = new Random();

            char[] arr = new char[2000];
            char[] letras = new char[] {'a','b', 'c','d','e' };

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]= letras[rand.Next(0,4)];
            }

            while (posicion<2000) {
                for (int i = 0; i < n; i++)
                {
                    if (posicion < 2000)
                    {
                        Console.Write(arr[posicion]);
                        posicion++;
                    }
                }
                n += 2;
                Console.Write("\n");
            }
        }
    }
}