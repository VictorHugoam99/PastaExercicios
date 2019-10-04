namespace ByteBank {
    public class ContaCorrente {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente (int Agencia, int Numero, Cliente Titular) 
        {
                this.Agencia = Agencia;
                this.Numero = Numero;
                this.Titular = Titular;
                this.Saldo = 0.0;
        }

        public bool DepositarSaldo (double deposito)
        {
            if (deposito > 0) {
                this.Saldo = Saldo + deposito;
                return true;
            } else {
                return false;
            }
        }

        public bool Saque (double valor) 
        {
            if( this.Saldo >= valor){
                this.Saldo -= valor;
                return true;
            } else {
                return false;
            }
        }

    public bool transferencia(ContaCorrente contaDestino, double valor)
    {
        if(this.Saque(valor)){
            contaDestino.DepositarSaldo(valor);
            return true;
        }else {
            return false;
        }
    }

    }
}