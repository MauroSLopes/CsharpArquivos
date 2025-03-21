using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void EscritaBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        {
            using (var escritor = new BinaryWriter(fs)) {
                escritor.Write(123);
                escritor.Write(546544);
                escritor.Write(400.50);
                escritor.Write("Mauro");
            }
        }
    }

    static void LerBinario()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
        {
            using (var leitor = new BinaryReader(fs))
            {
                int agencia = leitor.ReadInt32();
                int numeroConta = leitor.ReadInt32();
                double saldo = leitor.ReadDouble();
                string nome = leitor.ReadString();

                Console.WriteLine($"Agencia: {agencia}\nNumero da Conta: {numeroConta}\nSaldo: {saldo}" +
                    $"\nTitular: {nome}");
            }
    } }
}
