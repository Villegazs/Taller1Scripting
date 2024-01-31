namespace Taller1___punto_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float promedio = 0;
            float ingresado = 0;
            int n = 0;
            int cant = 0;
            float acumulado = 0;

            Console.WriteLine("¿Cuantos números desea ingresar?");
            string temp = Console.ReadLine();
            Int32.TryParse(temp, out n);
            Int32.TryParse(temp, out cant);

            while (n > 0)
            {
                Console.WriteLine("Escriba el número que desee:"); 
                temp = Console.ReadLine(); 
                float.TryParse(temp, out ingresado);
                acumulado += ingresado;
                n -= 1;
            }
            promedio = acumulado / cant;
            Console.WriteLine("El promedio final es: " +  promedio);
        }
    }
}