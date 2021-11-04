using System;



// criaçao do medelo do formulario 
namespace Aguar.API.Models
{
    public class Formulario
    {
        // Estrutura do formulario 
        public Formulario(string nome,string email, string detalhes,string endereco,string foto)
        {
            Id = Guid.NewGuid().ToString();
            Nome = nome;
            Email = email;
            Detalhes = detalhes;
            Endereco = endereco;
            Foto = foto;
            Concluido = false;
            DataCadastro = DateTime.Now;
            DataConclusao = null;
        }

        public string Id { get; private set; }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Detalhes { get; private set; }

        public string Endereco { get; private set; }

        public string Foto { get; private set; }

        public bool Concluido { get; private set; }

        public DateTime DataCadastro { get; private set; }

        public DateTime? DataConclusao { get; private set; }

        // para atualizar o formulario 
        public void AtualizarFormulario(string nome, string email, string detalhes, string endereco, string foto, bool? concluido = false)
        {

            Nome = nome;

            Email = email;
           
            Detalhes = detalhes;

            Endereco = endereco;

            Foto = foto;

            Concluido = concluido ?? false;

            DataConclusao = Concluido ? DateTime.Now : null;


        }
       

    }
}
