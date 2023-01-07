using System;

namespace HeapSort
{
    public class Programa
    {
        
        public static void Main()
        {
            int[] arr = { 55, 25, 89,-18,-23, 34, 12, 19, 78, 95, 1, 100, 23215, 65, 12, 3, 1, 2, 1, 2 };
            
            int i;
            Console.WriteLine("que tipo de ordenamiento desea: ");
            string tipo= Console.ReadLine();
            Console.WriteLine("cuantos numeros debetener el vector: ");
            int cantidad = int.Parse(Console.ReadLine());
            int[] vector=new int[cantidad];
            for (i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"ingrese el numero para la posicion {i}: ");
                int unidad = int.Parse(Console.ReadLine());
                vector[i] = unidad;
            }
            
            implementacion heapSort = new implementacion();
            heapSort.MostrarArrays(vector,tipo);
        }
    }
}