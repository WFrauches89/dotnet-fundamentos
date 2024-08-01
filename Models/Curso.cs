using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoLinguagemCSharp.Models
{
    public class Curso
    {
        public Curso() { }
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa p)
        {
            Alunos.Add(p);
        }

        public int GetNumberOfAlunos(List<Pessoa> alunos)
        {
            return alunos.Count;
        }

        public bool RemoverAlunos(Pessoa p)
        {
            return Alunos.Remove(p);
        }

        public void ListarAlunosNomeCompleto()
        {
            Alunos.Sort();
            for (int i = 0; i < Alunos.Count; i++)
            {
                Console.WriteLine($"N° {i + 1} - {Alunos[i].NomeCompleto} ");
            }
        }

    }
}