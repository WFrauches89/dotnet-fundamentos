using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoLinguagemCSharp.Models
{
    public class ExceptionsModels
    {
        public void Metodo1(string chamada)
        {
            if (chamada.Equals("a"))
            {
                try
                {
                    Metodo2();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Pegou no Metodo 1 a exception 5 - " + ex.Message);
                }
            }
            else
            {
                Metodo3();
            }

        }
        public void Metodo2()
        {
            Metodo4();
        }
        public void Metodo3()
        {
            try
            {
                Metodo6();
            }
            catch (FileLoadException ex)
            {
                Console.WriteLine("Pegou no Metodo 3 a exception 6 - " + ex.Message);
            }
        }
        public void Metodo4()
        {
            Metodo5();
        }
        public void Metodo5()
        {

            throw new Exception("Ocorreu a exceção");
        }
        public void Metodo6()
        {
            Metodo7();
        }
        public void Metodo7()
        {
            throw new FileLoadException("Ocorreu a exceção no método 6");
        }
    }
}