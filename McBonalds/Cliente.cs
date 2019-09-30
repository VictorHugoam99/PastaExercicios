using System;

namespace McBonalds
{
    public class Cliente
    {
        //Propriedades
        public string Nome;         //Nome do cliente
        public string Endereco;     //Endereço do cliente
        public string Telefone;     //Telefone do cliente
        public string Senha;        //Senha de acesso do Cliente ao sistema
        public string Email;        // Email do cliente e nome de usuário do sistema
        public DateTime DataNascimento;     //Data de nascimento do cliente

        //Construtores
        public Cliente(string nome, string telefone, string email){
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }


    }
}