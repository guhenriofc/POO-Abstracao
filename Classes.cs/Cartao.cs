namespace POO_Abstracao.Classes.cs
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;
        public string numero;
        public string nomeTitular;
        public string cvv;

        public string SalvarCartao(){
            return "";
        } 
    }
}