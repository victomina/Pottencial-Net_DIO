using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetosInVisualStudioCode.Models
{
    public class LeituraArquivoTupla
    {
        public void LerArquivo(string caminho)
        {   
            string[] linhas = File.ReadAllLines(caminho);
        }
    }
}