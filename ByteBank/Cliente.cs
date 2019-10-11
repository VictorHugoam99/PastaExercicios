namespace ByteBank {
    public class Cliente {
        private string _Cpf ;
        private string _Nome ;
        private string _Email;
        private string _Senha;

        public string Senha
        {
            get  { return _Senha; }
        }
        public string Cpf
        {
            get { return Cpf; }
            set { Cpf = value;}
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public Cliente (string nome, string cpf, string email) {
            _Nome = nome;
            _Cpf = cpf;
            _Email = email;
        }

        public bool TrocarSenha (string senha) 
        {
            if ((senha.Length > 6) && (senha.Length < 16))

            {
                this._Senha = senha;
                return true;
            } else 
            {
                return false;
            }
        }


    }
}