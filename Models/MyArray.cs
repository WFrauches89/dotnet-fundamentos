using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoLinguagemCSharp.Models
{
    public class MyArray<T>
    {

        private static int capacity = 10;
        private T[] array = new T[capacity];
        private int contador = 0;

        public void AdicionarNaLista(T genericElement)
        {
            if (contador + 1 <= capacity)
            {
                array[contador] = genericElement;
            }
            contador++;

        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}