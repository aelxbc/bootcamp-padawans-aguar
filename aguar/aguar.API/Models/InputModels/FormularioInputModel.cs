
namespace Aguar.API.Models.InputModels
{
    // estrutura de dados que vem do FrontEnd  
    public class FormularioInputModel
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Detalhes { get; set; }

        public string Endereco { get; set; }

        public string Foto { get; set; }

        public bool? Concluido { get; set; }


    }
}
