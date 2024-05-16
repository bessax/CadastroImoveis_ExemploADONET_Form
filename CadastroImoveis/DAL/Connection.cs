using Npgsql;

namespace CadastroImoveis.DAL;
public static class Connection
{
  public static NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=exemploBD;User Id=postgres;Password=root;");
    }
}
