using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03AtividadeComVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Conrado";
            string nome1 = "Pedrita";
            int idade = 19;
            int idade1 = 15;
            int num = 187;
            int num1 = 5;
            int cafes = num + num1;
            int tomados = 200;
            int faltaTomar = tomados - num;
            int faltaTomar1 = tomados - num1;
            Boolean cliente = false;
            Boolean cliente1 = true;

            Console.WriteLine("Aula 03 - Atividade com variáveis\n\n\n");

            Console.WriteLine("Olá!");
            Console.WriteLine("Bem vindo ao sistema de usuários do Conradito");
            Console.WriteLine("abaixo estão as informações dos usuários cadastrados no nosso sistema:\n\n");


            Console.WriteLine("----Lista de usuários:");
            Console.WriteLine($"1- Nome: { nome} Idade: {idade} É cliente: {cliente}");
            Console.WriteLine($"2- Nome: {nome1} Idade: {idade1} É cliente:  {cliente1}");


            Console.WriteLine("\n\n----Quantidade de cafés");
            Console.WriteLine ($"O cliente {nome} já tomou {num} cafés!");
            Console.WriteLine($"O cliente {nome1} já tomou {num1} cafés!");


            Console.WriteLine("\n\n----Soma de cafés tomados");
            Console.WriteLine($"Juntos, os cliente {nome} e {nome1} tomaram {cafes} cafés!");

            Console.WriteLine("\n\n----Quantos cafés falta para chegar em 200?");
            Console.WriteLine($"Faltam {faltaTomar} para {nome}");
            Console.WriteLine($"Faltam {faltaTomar1} para {nome1}");

            Console.WriteLine("\n\n\n----Fim do sistema de consultas");
            Console.WriteLine("-Obrigado e volta sempre");

            Console.ReadKey();
        }
    }
}
