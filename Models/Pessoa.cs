using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoLinguagemCSharp.Models
{
    public class Pessoa : IComparable<Pessoa>
    {
        public Pessoa() { }
        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        public int CompareTo(Pessoa other)
        {
            if (other == null) return 1;
            return this.NomeCompleto.CompareTo(other.NomeCompleto);
        }
        private string _nome;
        private string _sobrenome;
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }

        }
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age must be positive");
                }
                _idade = value;
            }
        }

        public string Sobrenome
        {
            get => _sobrenome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _sobrenome = value;
            }
        }

        public string NomeCompleto
        {
            get => $"{Nome} {Sobrenome}".ToUpper();
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} e Idade: {Idade}");
        }

    }
}