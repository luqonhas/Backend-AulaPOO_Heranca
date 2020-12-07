using System;
using Backend_AulaPOO_Heranca.Classes;
namespace Backend_AulaPOO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // instanciando subclasse PessoaFisica:
            PessoaFisica pfisica1 = new PessoaFisica();
            
            Console.Write("Digite o seu nome: ");
            pfisica1.nome = Console.ReadLine();

            Console.WriteLine(pfisica1.DarBoasVindas(pfisica1.nome));

            // Console.Write("Digite o seu CPF: ");
            // pfisica1.cpf = Console.ReadLine();

            pfisica1.cpf = "473.655.038-40";

            Console.WriteLine(pfisica1.ValidarCPF(pfisica1.cpf));
        }
    }
}
