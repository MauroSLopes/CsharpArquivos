using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    partial class Program
    {
        void DestrincharArquivo()
        {
            string enderecoDoArquivo = "contas.txt";

            int numeroDeBytesLidos = -1;

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024]; // 1kb

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }

                fluxoDoArquivo.Close();
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {

            var utf8 = new UTF8Encoding();

            string texto = utf8.GetString(buffer, 0, bytesLidos);

            Console.Write(texto);

            //foreach (byte b in buffer)
            //{
            //    Console.Write(b);
            //    Console.Write(" ");
            //}
        }
    }


