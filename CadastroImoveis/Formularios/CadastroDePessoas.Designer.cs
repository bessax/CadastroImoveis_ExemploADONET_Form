namespace CadastroImoveis.Formularios;

partial class CadastroDePessoas
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
        txtId = new TextBox();
        label2 = new Label();
        txtNome = new TextBox();
        label3 = new Label();
        txtEndereco = new TextBox();
        label4 = new Label();
        txtEmail = new TextBox();
        btnSalvar = new Button();
        btnCancelar = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(23, 26);
        label1.Name = "label1";
        label1.Size = new Size(100, 21);
        label1.TabIndex = 0;
        label1.Text = "Identificador:";
        // 
        // txtId
        // 
        txtId.Enabled = false;
        txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtId.Location = new Point(126, 23);
        txtId.Name = "txtId";
        txtId.Size = new Size(149, 29);
        txtId.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(68, 61);
        label2.Name = "label2";
        label2.Size = new Size(56, 21);
        label2.TabIndex = 2;
        label2.Text = "Nome:";
        // 
        // txtNome
        // 
        txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNome.Location = new Point(126, 58);
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(438, 29);
        txtNome.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(47, 96);
        label3.Name = "label3";
        label3.Size = new Size(77, 21);
        label3.TabIndex = 4;
        label3.Text = "Endereço:";
        label3.TextAlign = ContentAlignment.TopRight;
        // 
        // txtEndereco
        // 
        txtEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtEndereco.Location = new Point(126, 93);
        txtEndereco.Multiline = true;
        txtEndereco.Name = "txtEndereco";
        txtEndereco.Size = new Size(438, 91);
        txtEndereco.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(67, 193);
        label4.Name = "label4";
        label4.Size = new Size(57, 21);
        label4.TabIndex = 6;
        label4.Text = "E-mail:";
        label4.TextAlign = ContentAlignment.TopRight;
        // 
        // txtEmail
        // 
        txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtEmail.Location = new Point(126, 190);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(438, 29);
        txtEmail.TabIndex = 7;
        // 
        // btnSalvar
        // 
        btnSalvar.Location = new Point(489, 225);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(75, 23);
        btnSalvar.TabIndex = 8;
        btnSalvar.Text = "SALVAR";
        btnSalvar.UseVisualStyleBackColor = true;
        btnSalvar.Click += btnSalvar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(408, 225);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(75, 23);
        btnCancelar.TabIndex = 9;
        btnCancelar.Text = "CANCELAR";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += btnCancelar_Click;
        // 
        // CadastroDePessoas
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(593, 268);
        Controls.Add(btnCancelar);
        Controls.Add(btnSalvar);
        Controls.Add(txtEmail);
        Controls.Add(label4);
        Controls.Add(txtEndereco);
        Controls.Add(label3);
        Controls.Add(txtNome);
        Controls.Add(label2);
        Controls.Add(txtId);
        Controls.Add(label1);
        Name = "CadastroDePessoas";
        Text = "[CADASTRO DE PESSOAS]";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtId;
    private Label label2;
    private TextBox txtNome;
    private Label label3;
    private TextBox txtEndereco;
    private Label label4;
    private TextBox txtEmail;
    private Button btnSalvar;
    private Button btnCancelar;
}