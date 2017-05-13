using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorNome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            int tamanho = nome.Length;
            Console.WriteLine("Seu nome possui {0} caracteres", tamanho);
        }
    }
}
