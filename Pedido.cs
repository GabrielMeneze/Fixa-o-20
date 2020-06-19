namespace Fixa_o_20
{
    public class Pedido 
    {
        public string Itens { get; set; }
        public string Clientes { get; set; }
        public string Restaurantes { get; set; }
        public double Valor { get; set; }
        public bool PedidoPago { get; set; }

        public Pedido(string Itens, string Clientes, string Restaurantes,  double Valor)
        {
            this.Itens = Itens;
            this.Clientes = Clientes;
            this.Restaurantes = Restaurantes;
            this.Valor = Valor;
        }

        }
        
    }
