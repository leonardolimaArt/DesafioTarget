using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Model
{
    public class Soma
    {
        private int indice = 13, somaT = 0, k = 0;

        public int Indice { get => indice; set => indice = value; }
        public int SomaT { get => somaT; set => somaT = value; }
        public int K1 { get => k; set => k = value; }

        public int calcularSoma(){

            while(k < indice){
                k += 1;
                somaT += 1;
            }
            return somaT;
        }
    }  
}
