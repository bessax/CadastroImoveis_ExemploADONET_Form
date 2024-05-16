using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroImoveis.Entidades;
public class Imovel
{
    public int Id { get; set; }
    public int IdPessoa { get; set; }
    public string? Endereco { get; set; }
    public int Quartos { get; set; }
    public int Garagem { get; set; }
    public double Aluguel { get; set; }
    public bool Alugado { get; set; }

    public override string ToString()
    {
        return "Id: " + Id + ", IdPessoa: " + IdPessoa + ", Endereco: " + Endereco + ", Quartos: " + Quartos + ", Garagem: " + Garagem + ", Aluguel: " + Aluguel + ", Alugado: " + Alugado;
    }
}
