namespace Ejercicio4arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el tamaño del vector");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] numerorandom = new int[longitud];

            Random random = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int numeroguardar = random.Next(1, 1000);
                numerorandom[i] = numeroguardar;

                
            }
            Array.Sort(numerorandom);
            for (int i = 0;i < longitud; i++)
            {
                Console.WriteLine(numerorandom[i]);
            }
        }
    }

}