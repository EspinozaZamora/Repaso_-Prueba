using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_çPrueba
{
    class Program
    {
        const int MAX = 100;
        static void Main(string[] args)
        {
            int[] vector = new int[MAX];
            LlenarVector(vector);
            ordenarVecor(vector);
            ImprimirVector(vector);
            Console.WriteLine("-Valor Maximo: {0} ", vector[0]);
            Console.WriteLine("-Valor Minimo: {0} ", vector[MAX-1]);
            Console.WriteLine("-Sumatoria: {0} ", Sumatoria(vector));
            Console.WriteLine("-Promedio: {0} ", Promedio(vector));
            Console.WriteLine("-Total Decenas: {0} ", ContarDecenas(vector));
            Console.WriteLine("-Des. Estándar: {0} ", DesvEstandar(vector));

            Console.ReadKey();

        }
        public static double DesvEstandar(int[] x)
        {
            double res = 0;
            double prom = Promedio(x);
            for(int i = 0; i < MAX; i++)
            {
               res = res + (x[i] - prom * (x[i] - prom)); 
            }
            return Math.Sqrt(res / (MAX - 1));
        }
        public static int ContarDecenas(int[] x)
        {
            int c = 0;
            for(int i = 0; i < MAX; i++)
            {
                if (x[i] >= 10 && x[i] <= 90)
                {
                    if (x[i] % 10 == 0)
                        c++;
                }
            }
            return c;
        }

        public static int Sumatoria(int[] x)
        {
            int suma = 0;
            for (int i = 0; i < MAX; i++)
                suma = suma + x[i];

            return suma;
        }
        public static double Promedio(int[] x)
        {
            double suma = Sumatoria(x);
            return (suma / MAX);
        }
        public static void LlenarVector(int[] x)
        {
            Random r = new Random();
            for (int i = 0; i < MAX; i++)
            {
                int numero = r.Next(1, 1000);
                    x[i] = numero;
            }

        }
        public static void ImprimirVector(int[] x)
        {
            Console.WriteLine("Elementos del vector: ");
            for(int i=0; i < MAX; i++)
            {
                Console.Write(" {0}        ", x[i]);
            }
            Console.WriteLine();
        }
        public static void ordenarVecor(int[] x)
        {
            int aux = 0;
            for(int i = 0; i < MAX; i++)
                for (int j = i + 1; j < MAX; j++)
                {
                    if (x[i] < x[j])
                    {// intercambio
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }
                }


        }
    }
}
