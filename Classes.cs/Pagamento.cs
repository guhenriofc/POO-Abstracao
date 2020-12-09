using System;

namespace POO_Abstracao.Classes.cs
{
    public abstract class Pagamento
    {
        private DateTime data;
        protected float valor;

        public string Cancelar(){
            return "";
        }

        public abstract string Desconto(double valor);

        public abstract string Juros(double valorJuros);
        
        
    }
}