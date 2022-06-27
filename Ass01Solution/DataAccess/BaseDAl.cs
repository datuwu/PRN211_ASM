using System.IO;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class BaseDAl
    {
        public StockDataProvider dataProvider { get; set; } = null;
        public SqlConnection connection = null;
        public BaseDAl()
        {
            var connectionString = GetConnectionString();
            dataProvider = new StockDataProvider(connectionString);

        }
        public string GetConnectionString()
        {
            string connectionString;
            IConfiguration config =new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",true,true)
                .Build();
            connectionString = config["ConnectionString:MyServer"];
            return connectionString;
        }
        public void CloseConnection()=>dataProvider.CloseConnection(connection);
    }
}
