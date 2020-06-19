using System;

namespace Fixa_o_20
{
    class Program 
    {

        static void Main(string[] args)
        {
             Restaurante restaurante = new Restaurante("Pizzaria Maracanã", "Rua Silvestre 72");
             Cliente cliente = new Cliente("Gabriel Oliveira", "Rua da Lagoa 112");
             Pedido pedido = new Pedido("Pizza Quatro Queijos",cliente.Nome,restaurante.Nomeres,50);
             Cartao pagar = new Cartao();
             


            System.Console.WriteLine("Informações do pedido: ");
            System.Console.WriteLine("Restaurante: {0}",restaurante.Nomeres);
            System.Console.WriteLine("Cliente: {0}",cliente.Nome);
            System.Console.WriteLine("Produto: {0}",pedido.Itens);
            System.Console.WriteLine("Local de entrega: {0}",cliente.EnderecoAtual);
            System.Console.WriteLine("Valor: {0:c}",pedido.Valor);

           System.Console.WriteLine("Aperte enter duas vezes");
            string escolha = Console.ReadLine();
            
            string cartao = Console.ReadLine();


                pagar.rscolha(escolha, cartao);
                if(pagar.Token != "" && pagar.Token != null){
               System.Console.WriteLine("Pagamento será efetuado no cartão, unica forma de pagamento disponível");

                inicio:
                System.Console.Write("Digite o nome do Titular: ");
                string NomeDoTitular = Console.ReadLine();

                System.Console.Write("Digite o numero do cartão: ");
                string NumeroDoCartao = Console.ReadLine();

                System.Console.Write("Digite a data de vencimento: ");
                string DatadeVencimento = Console.ReadLine();

                System.Console.Write("Digite o codigo de segurança: ");
                string CodigoDeSeguranca = Console.ReadLine();

                pagar.Validar(NomeDoTitular, NumeroDoCartao, DatadeVencimento, CodigoDeSeguranca);
                if(pagar.token2 != " " && pagar.token2 != null)
                {
                    System.Console.WriteLine("Pagamento Aprovado");
                }else{
                    System.Console.WriteLine("Dados incorretos, insira novamente");
                    goto inicio;
                }
                }else{
                  System.Console.Write("Dados invalidos, tente novamente");
            }
           
            
            

        }
    }
}
