using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlPessoa pessoa = new ControlPessoa();
            pessoa.Operacao();

            Console.ReadLine();
        }//Fim do método
    }//Fim da classe
}//Fim do projeto
