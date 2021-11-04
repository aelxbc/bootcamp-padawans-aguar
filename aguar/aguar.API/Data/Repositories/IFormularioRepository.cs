using Aguar.API.Models;
using System.Collections.Generic;

namespace Aguar.API.Data.Repositories
{       // INTERFACE PARA ORGANIZAR O CODIGO ONDE DEFINO QUAIS CAMPOS VAMOS TRABALHAR
    public interface IFormularioRepository
    {
        //INSERIR
        void Adicionar(Formulario formulario);

        //ATUALIZAR
        void Atualizar(string id, Formulario formularioAtualizada);

        // BUSCAR TODOS
        IEnumerable<Formulario> Buscar();

        //BUSCAR ID
        Formulario Buscar(string id);

        //DELETAR
        void Remover(string id);
        
    }
}