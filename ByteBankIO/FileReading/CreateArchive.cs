using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void CriarArquivo()
    {
        string novoCaminho = "contasExportadas.csv";

        string textoParaImpressao = "666, 2564, 1215.24, Mauro";

        using (var fluxoDeArquivo = new FileStream(novoCaminho, FileMode.Create))
        {
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.WriteLine("666, 2564, 1215.24, Mauro");
            }
        }
    }
}

