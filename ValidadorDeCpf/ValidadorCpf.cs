using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidadorDeCpf
{
    internal class ValidadorCpf
    {
        private string Cpf { get; set; }

        public ValidadorCpf(string cpf)
        {
            Cpf = Regex.Replace(cpf, @"[^\d]", "");
        }

        public bool validarCpf()
        {

            if (!Regex.Match(Cpf, @"(\d)\1{8}").Success)
            {
                int multiplicado = 0;
                int multiplicador = 10;
                string primeiroNum;
                string segundoNum;

                for (int index = 0; index < 9; index++)
                {
                    multiplicado += (multiplicador * int.Parse(Cpf.Substring(index, 1)));
                    multiplicador--;
                }

                primeiroNum = (((multiplicado * 10) % 11) == 10 ? 0 : ((multiplicado * 10) % 11)).ToString();


                multiplicado = 0;
                multiplicador = 11;

                for (int index = 0; index < 10; index++)
                {
                    multiplicado += (multiplicador * int.Parse(Cpf.Substring(index, 1)));
                    multiplicador--;
                }

                segundoNum = (((multiplicado * 10) % 11) == 10 ? 0 : ((multiplicado * 10) % 11)).ToString();

                string finalCpf = Cpf.Substring(9, 2);



                if (finalCpf == (primeiroNum + segundoNum))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
