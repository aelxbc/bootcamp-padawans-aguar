
namespace LogicaAguar
{
    class Usuario
    {
        //ATRIBUTOS DO USUÁRIO
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Data { get; set; }

        public string Tipo { get; set; }

        //CONSTRUTOR DO USUÁRIO
        public Usuario (string nome, string email, string endereco, string cidade, string estado, string data, string tipo)
        {
            Nome = nome;
            Email = email;
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
            Data = data;
            Tipo = tipo;
        }
    }
}
