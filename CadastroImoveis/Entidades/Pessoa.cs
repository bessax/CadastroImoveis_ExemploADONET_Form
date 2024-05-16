using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroImoveis.Entidades;
public class Pessoa
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Endereco{ get; set; }
    public string? Email { get; set; }

    override public string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}, Endereco: {Endereco}, Email: {Email}";
    }   
}
