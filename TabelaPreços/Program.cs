using System;

namespace TabelaPreços
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preço;
            double total = 0;


            Console.WriteLine("Insira o código e a quantidade do item que deseja!");
            Console.WriteLine("1 - Cachorro Quente 4,00 euros\n 2 - X-Salada 4,50 euros\n 3 - X-Bacon 5,00 euros\n 4 - Torrada Simples 2,00 euros\n 5 - Refrigerante 1,50 euros\n");

            Console.WriteLine("Código");            
            codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantidade");            
            quantidade = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Cachorro Quente: "  +  " Quantidade: " + quantidade);
                    preço = 4.00;
                    total = quantidade * preço;
                    break;

                case 2:
                    Console.WriteLine("X-Salada: " + " Quantidade: " + quantidade);
                    preço = 4.50;
                    total = quantidade * preço;
                    break;

                case 3:
                    Console.WriteLine("X-Bacon: " + " Quantidade: " + quantidade);
                    preço = 5.00;
                    total = quantidade * preço;
                    break;

                case 4:
                    Console.WriteLine("Torrada Simples: " + " Quantidade: " + quantidade);
                    preço = 2.00;
                    total = quantidade * preço;
                    break;

                case 5:
                    Console.WriteLine("Refrigerante: " + " Quantidade: " + quantidade);
                    preço = 1.50;
                    total = quantidade * preço;
                    break;
            }

            if(codigo > 5)
            {
                Console.WriteLine("Digite um numero entre 1 e 5!");
            }

            Console.WriteLine("Total a pagar: " + total.ToString("C") + "\n");
        }
    }
}
