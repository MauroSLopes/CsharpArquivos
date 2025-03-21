using ByteBankIO;

partial class Program
    {
        static void LerArquivo()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var leitor = new StreamReader(fluxoDeArquivo);

                //var linha = leitor.ReadLine();

                //var texto = leitor.ReadToEnd();

                //var numero = leitor.Read();

                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();

                    var conta = ConverterStringParaContaCorrente(linha);

                    Console.WriteLine(conta.ToString());
                }

            }
            Console.ReadLine();
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');

            int agencia = int.Parse(campos[0]);
            int numero = int.Parse(campos[1]);
            double saldo = double.Parse(campos[2].Replace(".", ","));
            string titular = campos[3];

            var clienteTitular = new Cliente();
            clienteTitular.Nome = titular;


            var resultado = new ContaCorrente(agencia, numero);
            resultado.Depositar(saldo);
            resultado.Titular = clienteTitular;

            return resultado;
        }
    }

