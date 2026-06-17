using System;

class Program
{
    static void Main()
    {
        int n;
        string[] datos = new string[8];

        datos[0] = "Cafe";
        datos[1] = "Morado";
        datos[2] = "Corinto";
        datos[3] = "Rojo";
        datos[4] = "Verde";
        datos[5] = "Verde Oscuro";
        datos[6] = "Violeta";
        datos[7] = "Negro";

        Console.Write("Elige un número del 1 al 8: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("El color de esa casilla es: " + datos[n - 1]);
    }
}
