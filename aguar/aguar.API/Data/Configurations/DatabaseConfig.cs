

namespace Aguar.API.Data.Configurations
{ 
    //DEFINE NOME BANCO QUE API RETORNA  
    public class DatabaseConfig : IDatabaseConfig
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}
