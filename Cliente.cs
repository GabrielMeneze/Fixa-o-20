namespace Fixa_o_20
{
    public class Cliente
    {

        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }

        public Cliente(string Nome, string EnderecoAtual)
        {
            this.Nome = Nome;
            this.EnderecoAtual = EnderecoAtual;
        }
    }
}