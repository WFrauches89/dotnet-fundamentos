using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }
        public void Dividir(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(double x, double y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = ConvertToRadians(angulo);
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 3)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = ConvertToRadians(angulo);
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 3)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = ConvertToRadians(angulo);
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 3)}");
        }
        public void RaizQuadrada(double number)
        {
            double raiz = Math.Sqrt(number);
            Console.WriteLine($"Raiz quadrada de {number} = {Math.Round(raiz)}");
        }

        private static double ConvertToRadians(double angulo)
        {
            return angulo * (Math.PI / 180);
        }
    }
}