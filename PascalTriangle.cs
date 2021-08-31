using System;

namespace PascalTriangle
{
    class PascalTriangle{

        static void Main(string [] args){

            Console.Write("N° rows: ");
            int maxNumberPT = Int32.Parse(Console.ReadLine());
            
            int numberSpacesPerDigits = combination(maxNumberPT - 1, ((maxNumberPT -1)/2) + 1).ToString().Length;
            // rows && columns
            for(int i=1; i <= maxNumberPT; i++){
                string spaces = new string(' ', (maxNumberPT - i) * numberSpacesPerDigits);
                Console.Write(spaces);
                for(int j=1; j <= i; j++){
                    long resultComb = combination(i-1, j-1);
                    Console.Write(resultComb + new string(' ', numberSpacesPerDigits * 2 - resultComb.ToString().Length));
                }
                Console.WriteLine();
            }
        }

        public static long factoryNumber(int n){
            long fact = 1;

            for(int i=n; i > 0; i--){
                fact *= i;
            }

            return fact;
        }

        public static long combination(int n, int k){
            long comb = factoryNumber(n)/(factoryNumber(k)*factoryNumber(n-k));
            return comb;
        }
    }
}