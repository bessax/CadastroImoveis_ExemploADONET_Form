using CadastroImoveis.DAL;
using CadastroImoveis.Entidades;
using System.Data;



namespace CadastroImoveis.Formularios;
public partial class ListaDePessoas : Form
{
    private List<Pessoa> listaPessoas = new();
    private readonly BindingSource _bindingSource;
    private DataTable _dataTable = new("Pessoas");

    public ListaDePessoas()
    {
        InitializeComponent();
        listaPessoas = PessoaCmdSQL.ReadPessoas();
        //_bindingSource = new BindingSource();
        //_bindingSource.DataSource = listaPessoas;
        MontarDataTable();
        //dgvPessoas.DataSource = _bindingSource;
        //CarregamentoDGV();
        dgvPessoas.DataSource = _dataTable;

    }

    private void MontarDataTable()
    {
        listaPessoas = PessoaCmdSQL.ReadPessoas();
        _dataTable.Columns.Add("Id", typeof(int));
        _dataTable.Columns.Add("Nome", typeof(string));
        _dataTable.Columns.Add("Endereco", typeof(string));
        _dataTable.Columns.Add("Email", typeof(string));

        foreach (var pessoa in listaPessoas)
        {
           
            var row = _dataTable.NewRow();
            row["Id"] = pessoa.Id;
            row["Nome"] = pessoa.Nome;
            row["Endereco"] = pessoa.Endereco;
            row["Email"] = pessoa.Email;
            _dataTable.Rows.Add(row);

        }
    }

    private void CarregamentoDGV()
    {
        _bindingSource.DataSource = PessoaCmdSQL.ReadPessoas();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
        //filtrar o datagridview por nome aproximado.
        string nome = txtPesquisa.Text;
        _dataTable.DefaultView.RowFilter = $"Nome like '%{nome}%'";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int idDelecao = (int)dgvPessoas.CurrentRow.Cells[0].Value;
        if (idDelecao != 0)
        {
            var resultado = PessoaCmdSQL.DeletePesssoa(idDelecao);
            if (resultado == 1)
            {
                MessageBox.Show("Pessoa deletada com sucesso!");
                CarregamentoDGV();
            }
            else
                MessageBox.Show("Erro ao deletar pessoa!");
        }

    }

    private void btnAtualizar_Click(object sender, EventArgs e)
    {
        int idUpdate = (int)dgvPessoas.CurrentRow.Cells[0].Value;
        
        var pessoaAAtualizar = new Pessoa()
        {
            Id = idUpdate,
            Nome = dgvPessoas.CurrentRow.Cells[1].Value.ToString(),
            Endereco = dgvPessoas.CurrentRow.Cells[2].Value.ToString(),
            Email = dgvPessoas.CurrentRow.Cells[3].Value.ToString()
        };

        CadastroDePessoas cadastroDePessoas = new(pessoaAAtualizar);
        cadastroDePessoas.Text = "[ATUALIZAR PESSOA]";
        cadastroDePessoas.ShowDialog();
        AtualizaDataTable();
    }

    private void AtualizaDataTable()
    {
        _dataTable.Rows.Clear();
        listaPessoas = PessoaCmdSQL.ReadPessoas();
        foreach (var pessoa in listaPessoas)
        {
            var row = _dataTable.NewRow();
            row["Id"] = pessoa.Id;
            row["Nome"] = pessoa.Nome;
            row["Endereco"] = pessoa.Endereco;
            row["Email"] = pessoa.Email;
            _dataTable.Rows.Add(row);

        }
    }
}
