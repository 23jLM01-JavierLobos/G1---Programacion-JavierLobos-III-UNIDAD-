using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DATOS ACADEMICOS \nNombre: Javier Lobos" +
            "\nIV Bachillerato CCLL" +
            "\nClave 17");

        int[] edadPersonas= new int[7];
        int cantidadPersonasMayores=0;
        int cantidadPersonasMenores = 0;
        int cantidadPersonasIngresadas = 0;

        for (int i = 0; i < edadPersonas.Length; i++)
        {
            Console.Write("Ingrese la edad de la persona " + (i +1)+ " : ");

            edadPersonas[i] = Convert.ToInt32(Console.ReadLine());

            if (edadPersonas[i]>=18)
            {
                cantidadPersonasMayores++;
            }
            else
            {
                cantidadPersonasMenores++;
            }
            cantidadPersonasIngresadas = cantidadPersonasMayores + cantidadPersonasMenores;
        }
        Console.WriteLine();
        Console.WriteLine("Cantidad de personas mayores de edad: " + 
            cantidadPersonasMayores);

        Console.WriteLine();
        Console.WriteLine("Cantidad de personas menores de edad: " +
            cantidadPersonasMenores);

        Console.WriteLine();
        Console.WriteLine("Cantidad de personas ingresadas: " +
            cantidadPersonasIngresadas);
    }
}
