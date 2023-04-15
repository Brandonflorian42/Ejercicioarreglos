void matriz()
{
    Console.Write("Por favor, Ingresar la cantidad de alumnos: ");
    int cantidadAlumnos = Convert.ToInt32(Console.ReadLine());

    String[] nombre = new String[cantidadAlumnos];
    int[,] notas = new int[cantidadAlumnos, 2];

    for (int i = 0; i < cantidadAlumnos; i++)
    {
        Console.Write("Ingrese el nombre del alumno " + (i + 1) + ": ");
        nombre[i] = Console.ReadLine();

        Console.Write("Ingrese la primer nota del alumno " + (i + 1) + ": ");
        notas[i, 0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la segunda nota del alumno " + (i + 1) + ": ");
        notas[i, 1] = Convert.ToInt32(Console.ReadLine());
    }

    int notaMasAlta = notas[0, 0];
    int notaMasBaja = notas[0, 0];
    String nombreNotaMasAlta = nombre[0];
    String nombreNotaMasBaja = nombre[0];

    for (int i = 0; i < notas.GetLength(0); i++)
    {
        for (int j = 0; j < notas.GetLength(1); j++)
        {
            if (notas[i, j] > notaMasAlta)
            {
                notaMasAlta = notas[i, j];
                nombreNotaMasAlta = nombre[i];
            }

            if (notas[i, j] < notaMasBaja)
            {
                notaMasBaja = notas[i, j];
                nombreNotaMasBaja = nombre[i];
            }
        }
    }

    Console.WriteLine("La nota más alta es: " + notaMasAlta + ", y le pertenece a: " + nombreNotaMasAlta);
    Console.WriteLine("La nota más baja es: " + notaMasBaja + ", y le pertenece a: " + nombreNotaMasBaja);
}
matriz();