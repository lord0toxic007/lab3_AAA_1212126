using System;

class Program
{
    static void Main(string[] args)
    {

        string nombreEstudiante;
        string nombreCurso;
        string mensaje;

        Console.Write("Ingrese el nombre del estudiante: ");
        nombreEstudiante = Console.ReadLine();

        Console.Write("Ingrese el nombre del curso: ");
        nombreCurso = Console.ReadLine();

        Console.Write("Ingrese un mensaje personalizado: ");
        mensaje = Console.ReadLine();


        Console.WriteLine();
        Console.WriteLine("Nombre del estudiante: " + nombreEstudiante);
        Console.WriteLine("Nombre del curso: " + nombreCurso);
        Console.WriteLine("Mensaje: " + mensaje);

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}

