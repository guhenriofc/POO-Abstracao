namespace POO_Abstracao.Classes.cs
{
    public class Credito : Cartao
    {
        private float limite = 3000;

        public override string Desconto(double valor)
        {
            return "";
        }

        public override string Juros(double valorJuros)
        {
            return "";
        }

        public void Pagar(float valor){
            
        }
    }
}