namespace Fixa_o_20
{
    public class Restaurante
    {
        public string Nomeres { get; set; }
        public string EnderecoRes { get; set; }

        public Restaurante(string Nomeres, string EnderecoRes)
        {
            this.Nomeres = Nomeres;
            this.EnderecoRes = EnderecoRes;
        }
    }
}