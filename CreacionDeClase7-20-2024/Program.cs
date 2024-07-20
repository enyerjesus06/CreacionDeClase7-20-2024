

using CreacionDeClase7_20_2024;

public class Program
{

    static void Main(string[] args)
    {
        PersonaClass persona = new PersonaClass("Enyer Jesus Espino Medina", 18, "Santo Domingo");
        Console.WriteLine("Información de la persona:");
        persona.MostrarInformacion();
        Console.WriteLine();


        EstudianteClass Estudiante = new EstudianteClass(
            "Enyer Jesus Espino Medina",
             18,
            "Santo Domingo",
            "Desarrollo de Software", "2024-0199",
            "Instituto Tecnologico de Las Americas (ITLA)");

        Console.WriteLine("Información del estudiante:");
        Estudiante.MostrarInformacion();
        Console.WriteLine();

        Console.ReadLine();



    }
}
