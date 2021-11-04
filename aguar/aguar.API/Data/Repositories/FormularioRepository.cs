using System.Collections.Generic;
using MongoDB.Driver;
using Aguar.API.Models;
using Aguar.API.Data.Configurations;

// estrutura do banco de dados Neme da coleção e funcoes onde posso:INSERIR , BUSCAR TODOS , BUSCAR ID , ATUALIZAR E DELETAR

namespace Aguar.API.Data.Repositories
{
    public class FormularioRepository : IFormularioRepository
    {
        private readonly IMongoCollection<Formulario> _formulario;

        public FormularioRepository(IDatabaseConfig databaseConfig)
        {
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);

            _formulario = database.GetCollection<Formulario>("formulario");
        }

        //INSERIR

        public void Adicionar(Formulario formulario)
        {
            _formulario.InsertOne(formulario);
        }

        //ATUALIZAR

        public void Atualizar(string id, Formulario formularioAtualizada)
        {
            _formulario.ReplaceOne(formulario => formulario.Id == id, formularioAtualizada);
        }

        // BUSCAR TODOS

        public IEnumerable<Formulario> Buscar()
        {
            return _formulario.Find(formulario => true).ToList();
        }

        //BUSCAR ID
        public Formulario Buscar(string id)
        {
            return _formulario.Find(formulario => formulario.Id == id).FirstOrDefault();
        }

        //DELETAR

        public void Remover(string id)
        {
            _formulario.DeleteOne(formulario => formulario.Id == id);
        }
    }
}

