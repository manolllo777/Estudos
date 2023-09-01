using System;
using System.Collections.Generic;

namespace CriacaoMenuCadastroProdutos
{

    class mercadoBemBarato //Declarei uma classe contendo NomeProduto, Preço, Fabricante e Estoque
    {
        public string NomeProduto { get; set; }
        public string Fabricante { get; set; }
        public double Peso { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criei um Array (Vetor) contendo a classe nova e declarei uma variavel chamada listaProdutos
            List<mercadoBemBarato> listaProdutos = new List<mercadoBemBarato>();
            int menuPrincipal = -1;
            /*
            Usei o While como metodo de repetição dizendo que enquanto a entrada não for zero ele não para o 
            Loopin
            */
            while (menuPrincipal != 0)
            {
                Console.WriteLine("\n[1] Novo Produto");
                Console.WriteLine("[2] Listar Produtos");
                Console.WriteLine("[3] Remover Produto");
                Console.WriteLine("[4] Entrada Estoque");
                Console.WriteLine("[5] Saída Estoque");
                Console.WriteLine("[0] Sair");
                menuPrincipal = Convert.ToInt32(Console.ReadLine());

                //Menu numero 1
                if (menuPrincipal == 1)
                {
                    mercadoBemBarato novoProduto = new mercadoBemBarato();

                    Console.WriteLine("\nDigite nome do produto: \n");
                    novoProduto.NomeProduto = Console.ReadLine();

                    Console.WriteLine("\nDigite fabricante do produto: \n");
                    novoProduto.Fabricante = Console.ReadLine();

                    Console.WriteLine("Digite o preço do produto: \n");
                    novoProduto.Preco = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite o peso do produto: \n");
                    novoProduto.Peso = Convert.ToDouble(Console.ReadLine());

                    //No caso do estoque, declarei ele como sendo inicialmente zero
                    novoProduto.Estoque = 0;

                    //Fis a entrada na lista informando q tudo que estiver dentro de novoProduto será copiado
                    listaProdutos.Add(novoProduto);

                    Console.WriteLine("\nAdicionado com sucesso\n");

                }
                //Menu numero 2
                else if (menuPrincipal == 2)
                {
                    //criei um foreach e fiz a formatação correta
                    int pos = 1;
                    foreach (mercadoBemBarato listar in listaProdutos)
                    {
                        Console.WriteLine($"{pos++}. {listar.NomeProduto}, {listar.Fabricante},  " +
                            $"Kg{listar.Peso}, R${listar.Preco}, ({listar.Estoque} no estoque)");
                    }
                }
                //Menu numero 3
                else if (menuPrincipal == 3)
                {

                    Console.WriteLine("Informe a posição do produto: ");
                    int pos = Convert.ToInt32(Console.ReadLine());
                    listaProdutos.RemoveAt(pos - 1);
                }
                //Menu numero 4
                else if (menuPrincipal == 4)
                {
                    Console.WriteLine("Digite a posição do produto: ");
                    int pos = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade de entrada no estoque: ");
                    int entrada = Convert.ToInt32(Console.ReadLine());

                    mercadoBemBarato adicaoEstoque = listaProdutos[pos - 1];
                    adicaoEstoque.Estoque += entrada;

                    Console.WriteLine("\nEntrada realizada com sucesso! \n");
                }
                //Menu numero 5
                else if (menuPrincipal == 5)
                {
                    Console.WriteLine("Digite a posição do produto: ");
                    int pos = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade: ");
                    int saida = Convert.ToInt32(Console.ReadLine());

                    mercadoBemBarato subtracaoEstoque = listaProdutos[pos - 1];
                    subtracaoEstoque.Estoque -= saida;
                }
                //Menu saída 0
                else if (menuPrincipal != 0)
                {
                    Console.WriteLine("Fim do processo!");
                    Console.ReadLine();
                }
            }
        }
    }
}
