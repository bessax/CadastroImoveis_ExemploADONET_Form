using Npgsql;
using System.Configuration;

namespace CadastroImoveis.DAL;
public static class Connection
{
  static private string connectionString = string.Empty;
  public static NpgsqlConnection GetConnection()
    {
        connectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;

        return new NpgsqlConnection(connectionString);
    }
}
