namespace POO_Abstracao.Classes.cs
{
    public class Debito : Cartao
    {
        private float saldo = 600;

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