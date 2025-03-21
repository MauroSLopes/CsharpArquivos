using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void UsandoStreamEntrada()
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput())
        {
            using (var fs = new FileStream("entradoDoConsole.txt", FileMode.Create))
            {
                var bytes = new byte[1024];
                
                while (true)
                {

                    var bytesLidos = fluxoDeEntrada.Read(bytes, 0, 1024);
                    fs.Write(bytes, 0, bytesLidos);
                    fs.Flush();
                    Console.WriteLine(bytesLidos);
                }
            }
           
        }
    }
}
