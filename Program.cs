using System;
using System.Diagnostics;
namespace OrdenamientoBusquedaG4
{
    class Program
    {
        static void Main()
        {
            int[] A = { 10, 2, 20, 5, 40, 30, 100, 45};

            Console.WriteLine("Ingresa el número a buscar: ");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine(" El valor {0} se encuentra en la posición: {1}  ",X,BusquedaDirecta(A,X));


            /*
            int[] A = new int[50000];
            Random aleatorio = new Random();

            for(int i=0; i < A.Length; i++)
            {
                A[i] = (int)(aleatorio.NextDouble() * 1000);
            }
            Stopwatch sw = new Stopwatch();

            sw.Start();
            //Comienza a medir el tiempo de ejecución de las instrucciones
            Burbuja(A);
            sw.Stop();

            Console.WriteLine(" Tiempo de ejecución de Burbuja: {0} [ms]", sw.ElapsedMilliseconds);
            /*
            foreach(int v in A)
            {
                Console.Write(" {0} ", v);
            }
            */
            Console.WriteLine();
            Console.ReadLine();

        } 

        static void Burbuja(int [] A)
        {
            int N = A.Length;
            int Aux;

            for(int i=0; i < N; i++)
            {
                for(int j=0; j < N-1; j++  )
                {
                    if (A[j] > A[j + 1])
                    {
                        Aux = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = Aux;
                    }

                }
            }
        }

        static int BusquedaDirecta(int []A, int X )
        {
            int N = A.Length;

            for(int i=0; i < N; i++  )
            {
                if( X== A[i]  )
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
