using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad3
{
    public class Recursividad
    {
         int[] vec = { 312, 614, 88, 22, 54 };  //Datos ingresados en el vector para ser procesados para la recursividad ordenando de mayor a menor 
 
        void Ordenar(int[] v, int cant)          
        {             
            if (cant > 1)              
        {                 
                for (int f = 0; f < cant - 1; f++)                 
        {                     
                    if (v[f] > v[f + 1])                     
                    {                         
                        int aux = v[f];
                        v[f] = v[f + 1]; v[f + 1] = aux;
                    }
        } Ordenar(v, cant - 1);
        }
        }

        void Procesar() 
        { 
            Ordenar(vec, vec.Length); 
        }
        void Imprimir() 
        { 
            for (int f = 0; f < vec.Length; f++)                 
                Console.WriteLine(vec[f] + "  "); 
            Console.WriteLine(); 
        } 
 
 
        static void Main(string[] args)
        {
            Recursividad r = new Recursividad(); 
            r.Imprimir(); 
            r.Procesar(); 
            r.Imprimir(); 
            Console.ReadKey(); 
        }
    }
}
