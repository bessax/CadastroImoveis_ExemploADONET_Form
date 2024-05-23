namespace CadastroImoveis.Formularios;

partial class ListaDePessoas
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        txtPesquisa = new TextBox();
        btnBuscar = new Button();
        dgvPessoas = new DataGridView();
        btnDeletar = new Button();
        btnAtualizar = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvPessoas).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(-4, 31);
        label1.Name = "label1";
        label1.Size = new Size(108, 25);
        label1.TabIndex = 0;
        label1.Text = "PESQUISAR";
        // 
        // txtPesquisa
        // 
        txtPesquisa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtPesquisa.Location = new Point(110, 31);
        txtPesquisa.Name = "txtPesquisa";
        txtPesquisa.Size = new Size(386, 33);
        txtPesquisa.TabIndex = 1;
        // 
        // btnBuscar
        // 
        btnBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnBuscar.Location = new Point(502, 30);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(104, 34);
        btnBuscar.TabIndex = 2;
        btnBuscar.Text = "[BUSCAR]";
        btnBuscar.UseVisualStyleBackColor = true;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // dgvPessoas
        // 
        dgvPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPessoas.Location = new Point(12, 78);
        dgvPessoas.Name = "dgvPessoas";
        dgvPessoas.Size = new Size(598, 238);
        dgvPessoas.TabIndex = 3;
        // 
        // btnDeletar
        // 
        btnDeletar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnDeletar.Location = new Point(516, 322);
        btnDeletar.Name = "btnDeletar";
        btnDeletar.Size = new Size(94, 32);
        btnDeletar.TabIndex = 4;
        btnDeletar.Text = "Deletar";
        btnDeletar.UseVisualStyleBackColor = true;
        btnDeletar.Click += button1_Click;
        // 
        // btnAtualizar
        // 
        btnAtualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnAtualizar.Location = new Point(413, 322);
        btnAtualizar.Name = "btnAtualizar";
        btnAtualizar.Size = new Size(97, 32);
        btnAtualizar.TabIndex = 5;
        btnAtualizar.Text = "Atualizar";
        btnAtualizar.UseVisualStyleBackColor = true;
        btnAtualizar.Click += btnAtualizar_Click;
        // 
        // ListaDePessoas
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(622, 362);
        Controls.Add(btnAtualizar);
        Controls.Add(btnDeletar);
        Controls.Add(dgvPessoas);
        Controls.Add(btnBuscar);
        Controls.Add(txtPesquisa);
        Controls.Add(label1);
        Name = "ListaDePessoas";
        Text = "[MANUTENÇÃO DE CLIENTES]";
        ((System.ComponentModel.ISupportInitialize)dgvPessoas).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtPesquisa;
    private Button btnBuscar;
    private DataGridView dgvPessoas;
    private Button btnDeletar;
    private Button btnAtualizar;
}