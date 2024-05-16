using CadastroImoveis.Entidades;
using Npgsql;

namespace CadastroImoveis.DAL;
public class PessoaCmdSQL { 

    public static List<Pessoa> ReadPessoas()
    {    
        using var con = Connection.GetConnection();
        con.Open();
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
}
