using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppVector
{
    class clsVector
    {
        private int[] vector;
        private int lg;

        //EL CONSTRURTOR
        public clsVector() 
        { 
        vector= new int [100];
        lg = 0;
        }

        //EL METODOS "PROCEDIMIENTO Y FUNCIONES"
        public void adicionar(int valor) 
        {
            vector[lg] = valor;
            lg = lg + 1;
        }

        //OBTENER EL VALOR EN LA POSICION "pos"obtener el valor en la posicion po
        public int obtenervalor(int pos) 
        {
            return vector[pos];
        }

        // LONGITUD DEL VECTOR
        public int longitud(){
            return lg;
        }

        // INVERTIR LOS ELEMENTOS DEL VECTOR
        public void invertir()
        {
            int fin = lg - 1;
            int mitad = lg / 2;
            int i = 0;
            int aux = 0;
            while (i < mitad)
            {
                aux = vector[fin - i];
                vector[fin - i] = vector[i];
                vector[i] = aux;
                i++;
            }
        }

        // CANTIDAD DE ELEMENTOS PARES
        public int cantPares() 
        {
            int cont = 0;
            for(int i=0; i <lg; i++)
            {
            if (vector[i] % 2==0)
                cont++;
            }
            return cont;
        }

        // ORDENAR LOS ELEMENTOS LOS VECTORES DE MENOR A MAYOR
        public void OrdenarMenorAmayor() 
        {
            int aux = 0;
            for (int i = 0; i < lg; i++) 
            {
                for (int j = i; j < lg; j++) 
                {
                    if (vector[i] > vector[j]) 
                    {
                        aux = vector[j];
                        vector[j] = vector[i];
                        vector[i] = aux;
                    }
                }
            }
        }

        // ELIMINAR EL ELEMENTO EN LA POSICION "P"
        public void EliminarElementoPos(int p) 
        {
            for (int i = p - 1; i < lg; i++) 
            {
                vector[i] = vector[i + 1];
            }
            lg = lg - 1;
        }

        // Invertir cada elemento del vector
        public void invertirVect()
        {
            for (int i = 0; i < lg; i++)
            {
                vector[i] = invertirVector(vector[i]);
            }
        }

        // Método para invertir un número
        private int invertirVector(int num)
        {
            int invertirNum = 0;
            while (num > 0)
            {
                int res = num % 10;
                invertirNum = (invertirNum * 10) + res;
                num = num / 10;
            }
            return invertirNum;
        }
   
        //METODO PARA VERIFICAR SI UN NUMERO ES "CAPICUA"
        public int ContarCapicuas()
        {
        int capicuas = 0; 
        for (int i = 0; i < lg; i++)
            {
            int num = vector[i];
            int ori = num;
            int rev = 0;
            while (num > 0)
            {
            int res = num % 10;
            rev = (rev * 10) + res;
            num = num / 10;
            }
            if (ori == rev)
            {
            capicuas++; 
            }
            }
            return capicuas;
        }
    
        // METODO PARA OBTENER LA CANTIDAD DE NUMEROS PRIMOS EN EL VALOR
        public int ContarPrimos()
        {
            int primosCount = 0; 
            for (int i = 0; i < lg; i++)
            {
            int num = vector[i];
            if (num > 1 && EsPrimo(num)) 
            {
                primosCount++; 
            }
            }
            return primosCount; 
        }

        // METODO PARA VERIFICAR SI UN NUMERO ES PRIMO
        private bool EsPrimo(int num)
        {
            if (num <= 1)
            {
            return false;
            }
            for (int i = 2; i < num; i++) 
            {
            if (num % i == 0) 
            {
                return false;
            }
            }
            return true; 
        }
    }
}
  




