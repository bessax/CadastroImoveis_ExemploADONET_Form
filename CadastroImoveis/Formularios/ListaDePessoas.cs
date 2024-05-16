using CadastroImoveis.DAL;
using CadastroImoveis.Entidades;

namespace CadastroImoveis.Formularios;
public partial class ListaDePessoas : Form
{
    private List<Pessoa> listaPessoas = new();
    private readonly BindingSource _bindingSource;

    public ListaDePessoas()
    {
        InitializeComponent();

        _bindingSource = new BindingSource();
        _bindingSource.DataSource = listaPessoas;
        dgvPessoas.DataSource = _bindingSource;
        CarregamentoDGV();
    }
    private void CarregamentoDGV()
    {
        _bindingSource.DataSource = PessoaCmdSQL.ReadPessoas();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {

    }
}
