using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Model
{
    public class Fibbo
    {
        private int a = 0, b = 1, temp = 0;
        private List<int> listaFibbo = new List<int>();

        public void calcularFibbo(int limit){
            Console.Write($"Sequencia: {a} ");
            while (a < limit)
            {
                temp = b;
                b = a + b;
                a = temp;
                Console.Write($"{a} ");
            }
            if(a <= limit){
                Console.WriteLine($"\nO número {limit} pertence a sequencia de Fibbonaci");
            }else{
                Console.WriteLine($"\nO número {limit} não pertence a sequencia de Fibbonaci");
            }
        }
    }
}