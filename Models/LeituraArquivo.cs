using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoLinguagemCSharp.Models
{
    public class LeituraArquivo
    {

        public (bool Sucesso, string[] LinhasArquivo, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception e)
            {
                string[] message = [$"{e.Message}"];
                return (false, message, 0);
            }


        }




    }
}