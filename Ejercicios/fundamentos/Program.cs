using fundamentos.Models;

namespace fundamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Coca cola", 1000);
            Cerveza cerveza = new Cerveza(500, "Cerveza");
            int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};
            int numero = numeros[0];
            
            for (int i = 0; i<numeros.Length; i++)
            {
                Console.WriteLine("iteracion: " + i + " - " + numeros[i]);
            }

            foreach(var numero in numeros){
                Console.WriteLine(numero);
            }
        }
    } 
}
  