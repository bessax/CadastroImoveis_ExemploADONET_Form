namespace CadastroImoveis;

partial class Principal
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip1 = new MenuStrip();
        manutençãoToolStripMenuItem = new ToolStripMenuItem();
        pessoasToolStripMenuItem = new ToolStripMenuItem();
        listarPessoasToolStripMenuItem = new ToolStripMenuItem();
        cadastrarToolStripMenuItem = new ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { manutençãoToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(800, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // manutençãoToolStripMenuItem
        // 
        manutençãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pessoasToolStripMenuItem });
        manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
        manutençãoToolStripMenuItem.Size = new Size(86, 20);
        manutençãoToolStripMenuItem.Text = "Manutenção";
        // 
        // pessoasToolStripMenuItem
        // 
        pessoasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarPessoasToolStripMenuItem, cadastrarToolStripMenuItem });
        pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
        pessoasToolStripMenuItem.Size = new Size(180, 22);
        pessoasToolStripMenuItem.Text = "Pessoas";
        // 
        // listarPessoasToolStripMenuItem
        // 
        listarPessoasToolStripMenuItem.Name = "listarPessoasToolStripMenuItem";
        listarPessoasToolStripMenuItem.Size = new Size(180, 22);
        listarPessoasToolStripMenuItem.Text = "Listar Pessoas";
        listarPessoasToolStripMenuItem.Click += listarPessoasToolStripMenuItem_Click;
        // 
        // cadastrarToolStripMenuItem
        // 
        cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
        cadastrarToolStripMenuItem.Size = new Size(180, 22);
        cadastrarToolStripMenuItem.Text = "Cadastrar";
        cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
        // 
        // Principal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(menuStrip1);
        IsMdiContainer = true;
        MainMenuStrip = menuStrip1;
        Name = "Principal";
        Text = "Form1";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem manutençãoToolStripMenuItem;
    private ToolStripMenuItem pessoasToolStripMenuItem;
    private ToolStripMenuItem listarPessoasToolStripMenuItem;
    private ToolStripMenuItem cadastrarToolStripMenuItem;
}
