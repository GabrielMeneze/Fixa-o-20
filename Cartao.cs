namespace Fixa_o_20
{
    public class Cartao 
    {
        
        public string cartao { get; set; }
        public string escolha;
        public string Token;
        public string token2 { get; set; }
        public string NomeDoTitular = "Gabriel Carvalho";
        public string NumeroDoCartao = "550986789786";
        public string DatadeVencimento = "07/27";
        protected string CodigoDeSeguranca = "897";


        public bool rscolha(string Cartao, string escolha){
            if(escolha == Cartao){
                Token = ".";
                return true;
            }else{
                return false;
            }
        }

        public bool Validar(string NomeDoTitular, string NumeroDoCartao, string DatadeVencimento, string CodigoDeSeguranca)
        {
            if(this.NomeDoTitular == NomeDoTitular && this.NumeroDoCartao == NumeroDoCartao && this.DatadeVencimento == DatadeVencimento && this.CodigoDeSeguranca == CodigoDeSeguranca)
        {
             token2 = "lll";
              return true;
        }else{
            return false;
        }
     }
        
    }
    
}