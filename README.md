# Taller1Scripting
## Preguntas teóricas

### ¿De qué tipo es el resultado al sumar 12 bytes, 3 ints, 6 floats y 3 doubles?

El resultado será del tipo de dato que tenga mayor información/capacidad. Por lo que al observar la jerarquía el resultado de la suma será de tipo double.

### ¿Para qué sirve Try Parse?, escriba un ejemplo de cómo se usa

El try Parse sirve para hacer una conversión de datos de manera más segura evitando errores en el proceso de conversion y que este detenga el programa.

Este codigo sino se introduce un entero automaticamente detiene el programa y no ofrece al usuario un feedback
~~~
            int num;
            Console.WriteLine("Ingrese un numero");
            string temp = Console.ReadLine();
            num =Convert.ToInt32(temp);
            Console.WriteLine("El numero ingresado fue "+ num);
~~~

En cambio si se hace la implementacion del try.Parse este si terminara de ejecutar el programa por completo

~~~
            int num;
            bool conversion;
            Console.WriteLine("Ingrese un numero");
            string temp = Console.ReadLine();
            conversion = int.TryParse(temp,out num);
            
            if (conversion)
            {
            Console.WriteLine("El numero ingresado fue "+ num);
            }
            else
            {
                Console.WriteLine("Por favor digite un numero entero");
            }
~~~