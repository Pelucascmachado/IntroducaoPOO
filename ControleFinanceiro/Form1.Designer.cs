namespace ControleFinanceiro
{
    partial class frmCliente
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
            lblNome = new Label();
            btnInserir = new Button();
            lblCPF = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            btnExcluir = new Button();
            lstClientes = new ListBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(280, 62);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // btnInserir
            // 
            btnInserir.Enabled = false;
            btnInserir.Location = new Point(280, 139);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(280, 95);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 2;
            lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(324, 59);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(324, 92);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 4;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(361, 139);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(288, 190);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(147, 94);
            lstClientes.TabIndex = 6;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstClientes);
            Controls.Add(btnExcluir);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(lblCPF);
            Controls.Add(btnInserir);
            Controls.Add(lblNome);
            Name = "frmCliente";
            Text = "Controle de Clientes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Button btnInserir;
        private Label lblCPF;
        private TextBox txtNome;
        private TextBox txtCpf;
        private Button btnExcluir;
        private ListBox lstClientes;
    }
}
