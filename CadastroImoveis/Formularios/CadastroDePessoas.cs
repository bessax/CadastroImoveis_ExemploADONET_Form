using CadastroImoveis.DAL;
using CadastroImoveis.Entidades;

namespace CadastroImoveis.Formularios;
public partial class CadastroDePessoas : Form
{
    private Pessoa? pessoaAAtualizar;
    public CadastroDePessoas(Pessoa pessoa)
    {
        InitializeComponent();
        pessoaAAtualizar = pessoa;
        txtNome.Text = pessoa.Nome;
        txtEndereco.Text = pessoa.Endereco;
        txtEmail.Text = pessoa.Email;
    }
    public CadastroDePessoas()
    {
        InitializeComponent();
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
                if (pessoaAAtualizar is null) 
                { 
                    var resultado = PessoaCmdSQL.InsertPessoa
                    (
                        new Pessoa()
                        {
                            Nome = txtNome.Text,
                            Endereco = txtEndereco.Text,
                            Email = txtEmail.Text
                        }
                     );
                    if (resultado == 1)
                        MessageBox.Show("Pessoa cadastrada com sucesso!");
                    else
                        MessageBox.Show("Erro ao cadastrar pessoa!");
            } 
            else{
                var resultado = PessoaCmdSQL.UpdatePessoa(pessoaAAtualizar.Id,
                                       new Pessoa()
                                       {
                                           Nome = txtNome.Text,
                                           Endereco = txtEndereco.Text,
                                           Email = txtEmail.Text
                                       });
            if(resultado == 1)
                        MessageBox.Show("Pessoa atualizada com sucesso!");
                    else
                MessageBox.Show("Erro ao atualizar pessoa!");
        }
        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        LimparCampos();
    }

    private void LimparCampos()
    {
        foreach (var item in Controls)
        {
            if (item is TextBox)
            {
                ((TextBox)item).Text = string.Empty;
            }
        }
    }
}
