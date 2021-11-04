namespace Aguar.API.Data.Configurations
{ 
    //DEFINE NOME BANCO QUE API RETORNA  
    public interface IDatabaseConfig
    {
        string DatabaseName { get; set; }

        string ConnectionString { get; set; }


    }
}