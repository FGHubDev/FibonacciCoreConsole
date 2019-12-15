using System;
using System.Numerics;

namespace TestCoreConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez un nombre entre 1 et 100 :");
            Console.WriteLine(Fibonacci(Console.ReadLine()));
        }

        public static string Fibonacci(string stringNumber)
        {
            try
            {
                int n = int.Parse(stringNumber);

                if (n < 1 || n > 100)
                {
                    return "-1";
                }
                else
                {
                    // Le n-ième terme de la suite de Fibonacci est la somme des deux termes précédents.
                    BigInteger[] Fib = new BigInteger[n + 1];
                    Fib[0] = 0;
                    Fib[1] = 1;

                    for (int i = 2; i <= n; i++)
                    {
                        Fib[i] = Fib[i - 1] + Fib[i - 2];
                    }

                    return Fib[n].ToString();
                }
            }
            catch (FormatException e)
            {
                if (stringNumber == "")
                {
                    throw new ArgumentNullException("Aucune valeur saisie.", e);
                }
                else
                {
                    throw new Exception("Valeur incorrecte.", e);
                }
            }
        }
    }
}
