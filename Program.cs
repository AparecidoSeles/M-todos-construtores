using System;
using Metodos_construtores.classes;

namespace Metodos_construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            //ULTLIZANDO PRIMEIRO  MÉTODO
            //INSERINDO TODOS OS ATRIBUTOS

            Produto p = new Produto();
            p.Codigo = 1;
            p.Nome = "Coca";
            p.Descricao = "Refrigerante";
            p.Estoque = 30;


            System.Console.WriteLine();   // Pular linha
            Console.WriteLine($"Produto {p.Codigo}, Nome: {p.Nome}, Descrição: {p.Descricao}, Estoque: {p.Estoque}");

            System.Console.WriteLine();   // Pular linha

            //ULTLIZANDO SEGUNDO  MÉTODO
            //INSERINDO APENAS O VALOR
            Produto p2 = new Produto(5);    
            p2.Nome = "Pepsi";
           
            Console.WriteLine($"Código inserido {p2.Codigo} , Nome: {p2.Nome}");

            //ULTLIZANDO TERCEIRO MÉTODO
            //INSERINDO APENAS O VALOR

            Produto p3 = new Produto(10, "Antartica" ,"Refrigarnte" , 1000);

            System.Console.WriteLine();   // Pular linha
            Console.WriteLine($"Código {p3.Codigo}, Nome {p3.Nome}; Sobrenome: {p3.Descricao}, Estoque: {p3.Estoque}");
        }
    }
}
