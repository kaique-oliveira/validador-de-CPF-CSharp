using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDeCpf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o CPF:");
            string cpf = Console.ReadLine();

            ValidadorCpf validar = new ValidadorCpf(cpf);

            bool v = validar.validarCpf();

            if (v)
            {
                Console.WriteLine("Valido");
            }
            else
            {
                Console.WriteLine("Invalido");
            }

            Console.ReadKey();
        }
    }
}
