using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Model
{
    public class StringInvert
    {
        private String aux = "";

        public void inverterString(string s1){
            Console.WriteLine($"String Normal: {s1}");
            for(int i = s1.Length-1; i >= 0; i--){
                aux += s1[i];
            }
            Console.WriteLine($"String Invertida: {aux}");
        }
    }
}