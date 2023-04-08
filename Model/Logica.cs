using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Model
{
    public class Logica
    {

        public void calcularLogica(){
            int i = 0, a = 1;

            Console.Write("a) ");
            while(i != 5){
               Console.Write($"{a} ");
               a += 2;
               i++;
            }

            Console.Write("\nb) ");
            a = 2;
            i = 0;  
            while(i != 7){
               Console.Write($"{a} ");
               a += a;
               i++;
            }

            Console.Write("\nc) ");
            a = 0;
            i = 0; 
            int auxC = 1; 
            while(i != 8){
               Console.Write($"{a} ");
               a += auxC;
               auxC += 2;
               i++;
            }

            Console.Write("\nd) ");
            a = 2;
            i = 0; 
            while(i != 5){
               Console.Write($"{Math.Pow(a, 2)} ");
               a += 2;
               i++;
            }

            Console.Write("\ne) ");
            a = 0;
            int b = 1, temp = 0;
            i = 0; 
            while(i != 7){
                temp = b;
                b = a + b;
                a = temp;
                Console.Write($"{a} ");
                i++;
            }

            Console.Write("\nf) ");        
            Console.Write($"2, 10, 12, 16, 17, 18, 19, 200 ");   
            
        }
    }
}