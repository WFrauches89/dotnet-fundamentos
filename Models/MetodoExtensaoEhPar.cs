using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoLinguagemCSharp.Models
{
    public static class MetodoExtensaoEhPar
    {
        public static bool EhPar(this int valor)
        {
            return valor % 2 == 0;
        }
    }
}