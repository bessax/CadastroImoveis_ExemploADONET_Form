using CadastroImoveis.Formularios;

namespace CadastroImoveis;

public partial class Principal : Form
{
    public Principal()
    {
        InitializeComponent();
    }

    private void listarPessoasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new ListaDePessoas();
        form.MdiParent = this;
        form.Show();
    }
}
