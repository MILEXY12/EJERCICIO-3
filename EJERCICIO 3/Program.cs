

// EJERCICIO 3

using System;

class Program
{
    static void Main()
    {
        // Creamos un objeto Random para generar números aleatorios
        Random random = new Random();

        // Generamos dos números aleatorios entre 1 y 6
        int numero1 = random.Next(1, 7);
        int numero2 = random.Next(1, 7);

        // Calculamos la suma de los números generados
        int suma = numero1 + numero2;

        // Verificamos las condiciones y mostramos el mensaje correspondiente
        if (suma < 5 || suma == 11)
        {
            Console.WriteLine("Ganaste el premio sorpresa de la trivia");
        }
        else
        {
            Console.WriteLine("Sigue intentando");
        }

        // Mostramos los números generados y su suma
        Console.WriteLine("Número 1: " + numero1);
        Console.WriteLine("Número 2: " + numero2);
        Console.WriteLine("Suma: " + suma);
    }
}

