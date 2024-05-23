using CadastroImoveis.Entidades;
using Npgsql;

namespace CadastroImoveis.DAL;
public class PessoaCmdSQL { 

    public static List<Pessoa> ReadPessoas()
    {    
        using var con = Connection.GetConnection();
        con.Open();
        try
        {
            using var cmd = new NpgsqlCommand("SELECT * FROM pessoa", con);
            using var reader = cmd.ExecuteReader();
            List<Pessoa> pessoas = new();
            while (reader.Read())
            {
                pessoas.Add(new Pessoa
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Endereco = reader.GetString(2),
                    Email = reader.GetString(3)
                });
            }
            return pessoas;
        }
        finally
        {
            con.Close();
        }
        
    }
    public static int InsertPessoa(Pessoa pessoa)
    {
        using var con = Connection.GetConnection();
        con.Open();
        using var cmd = new NpgsqlCommand($"INSERT INTO pessoa (nome,endereco,email) VALUES ('{pessoa.Nome}','{pessoa.Endereco}','{pessoa.Email}')", con);
        return cmd.ExecuteNonQuery();
    }
    public static int DeletePesssoa(int id)
    {
        using var con = Connection.GetConnection();
        con.Open();
        using var cmd = new NpgsqlCommand($"DELETE FROM pessoa WHERE id = {id}");
        cmd.Connection = con;
        return cmd.ExecuteNonQuery();

    }
    public static int UpdatePessoa(int id, Pessoa pessoa)
    {
        using var con = Connection.GetConnection();
        con.Open();
        var cmd = new NpgsqlCommand(
            $"UPDATE pessoa SET nome = '{pessoa.Nome}',endereco ='{pessoa.Endereco}', email='{pessoa.Email}' WHERE id={id}"
            );
        cmd.Connection = con;
        return cmd.ExecuteNonQuery();
    }
}
