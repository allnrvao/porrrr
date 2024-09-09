using prueba1.classes;

namespace prueba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            string nombre = null;
            Person person = new Person();
            Console.Write("escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Esribe tu edad: ");
            edad = int.Parse(Console.ReadLine());

            person.name = nombre;
            person.age = edad;

            person.Introduce(nombre, edad);

        }
    }
}
