namespace ByteBank {
    public class Cliente {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Cliente (string nome, string cpf, string email) {
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }

        public bool TrocarSenha (string senha) {
            if ((senha.Length > 6) && (senha.Length < 16))

            {
                this.Senha = Senha;
                return true;
            } else {
                return false;
            }
        }


    }
}