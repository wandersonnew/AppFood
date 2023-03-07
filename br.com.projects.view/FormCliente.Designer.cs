namespace AppFoodV2.br.com.projects.view
{
    partial class FormCliente
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
            panel1 = new Panel();
            label1 = new Label();
            tabCliente = new TabControl();
            tabPage1 = new TabPage();
            txtId = new TextBox();
            IdTxt = new Label();
            cbEstado = new ComboBox();
            txtNumero = new TextBox();
            mtbCep = new MaskedTextBox();
            mtbCpf = new MaskedTextBox();
            mtbRg = new MaskedTextBox();
            mtbCelular = new MaskedTextBox();
            txtCidade = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            tabPage2 = new TabPage();
            btnSearch = new Button();
            tabelaClientes = new DataGridView();
            txtSearchCliente = new TextBox();
            label2 = new Label();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            panel1.SuspendLayout();
            tabCliente.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(132, 36);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // tabCliente
            // 
            tabCliente.Controls.Add(tabPage1);
            tabCliente.Controls.Add(tabPage2);
            tabCliente.Location = new Point(12, 76);
            tabCliente.Name = "tabCliente";
            tabCliente.SelectedIndex = 0;
            tabCliente.Size = new Size(776, 326);
            tabCliente.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(IdTxt);
            tabPage1.Controls.Add(cbEstado);
            tabPage1.Controls.Add(txtNumero);
            tabPage1.Controls.Add(mtbCep);
            tabPage1.Controls.Add(mtbCpf);
            tabPage1.Controls.Add(mtbRg);
            tabPage1.Controls.Add(mtbCelular);
            tabPage1.Controls.Add(txtCidade);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtEndereco);
            tabPage1.Controls.Add(txtBairro);
            tabPage1.Controls.Add(txtComplemento);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(label25);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 293);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro de Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(544, 17);
            txtId.Name = "txtId";
            txtId.Size = new Size(206, 27);
            txtId.TabIndex = 12;
            // 
            // IdTxt
            // 
            IdTxt.AutoSize = true;
            IdTxt.Location = new Point(480, 20);
            IdTxt.Name = "IdTxt";
            IdTxt.Size = new Size(58, 20);
            IdTxt.TabIndex = 37;
            IdTxt.Text = "Código";
            IdTxt.Click += IdTxt_Click;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbEstado.Location = new Point(544, 167);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(206, 28);
            cbEstado.TabIndex = 9;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(544, 248);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(206, 27);
            txtNumero.TabIndex = 11;
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(544, 205);
            mtbCep.Mask = "00000-000";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(206, 27);
            mtbCep.TabIndex = 10;
            // 
            // mtbCpf
            // 
            mtbCpf.Location = new Point(544, 54);
            mtbCpf.Mask = "000.000.000-00";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(206, 27);
            mtbCpf.TabIndex = 6;
            // 
            // mtbRg
            // 
            mtbRg.Location = new Point(544, 90);
            mtbRg.Mask = "0000000000.0";
            mtbRg.Name = "mtbRg";
            mtbRg.Size = new Size(206, 27);
            mtbRg.TabIndex = 7;
            // 
            // mtbCelular
            // 
            mtbCelular.Location = new Point(544, 128);
            mtbCelular.Mask = "(00) 0 0000-0000";
            mtbCelular.Name = "mtbCelular";
            mtbCelular.Size = new Size(206, 27);
            mtbCelular.TabIndex = 8;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(128, 248);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(340, 27);
            txtCidade.TabIndex = 5;
            txtCidade.TextChanged += txtCidade_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(128, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(340, 27);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(340, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(128, 128);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(340, 27);
            txtEndereco.TabIndex = 2;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(128, 167);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(340, 27);
            txtBairro.TabIndex = 3;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(128, 205);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(340, 27);
            txtComplemento.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 251);
            label14.Name = "label14";
            label14.Size = new Size(56, 20);
            label14.TabIndex = 24;
            label14.Text = "Cidade";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(474, 93);
            label15.Name = "label15";
            label15.Size = new Size(28, 20);
            label15.TabIndex = 23;
            label15.Text = "RG";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(474, 57);
            label16.Name = "label16";
            label16.Size = new Size(33, 20);
            label16.TabIndex = 22;
            label16.Text = "CPF";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(18, 93);
            label17.Name = "label17";
            label17.Size = new Size(46, 20);
            label17.TabIndex = 21;
            label17.Text = "Email";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(18, 131);
            label18.Name = "label18";
            label18.Size = new Size(71, 20);
            label18.TabIndex = 20;
            label18.Text = "Endereço";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(18, 170);
            label19.Name = "label19";
            label19.Size = new Size(49, 20);
            label19.TabIndex = 19;
            label19.Text = "Bairro";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(474, 208);
            label20.Name = "label20";
            label20.Size = new Size(34, 20);
            label20.TabIndex = 18;
            label20.Text = "CEP";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(474, 131);
            label21.Name = "label21";
            label21.Size = new Size(55, 20);
            label21.TabIndex = 17;
            label21.Text = "Celular";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(18, 208);
            label22.Name = "label22";
            label22.Size = new Size(104, 20);
            label22.TabIndex = 16;
            label22.Text = "Complemento";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(475, 170);
            label23.Name = "label23";
            label23.Size = new Size(54, 20);
            label23.TabIndex = 15;
            label23.Text = "Estado";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(475, 251);
            label24.Name = "label24";
            label24.Size = new Size(63, 20);
            label24.TabIndex = 14;
            label24.Text = "Número";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(18, 57);
            label25.Name = "label25";
            label25.Size = new Size(50, 20);
            label25.TabIndex = 13;
            label25.Text = "Nome";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSearch);
            tabPage2.Controls.Add(tabelaClientes);
            tabPage2.Controls.Add(txtSearchCliente);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 293);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(507, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(244, 48);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tabelaClientes
            // 
            tabelaClientes.AllowUserToAddRows = false;
            tabelaClientes.AllowUserToDeleteRows = false;
            tabelaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaClientes.Location = new Point(19, 82);
            tabelaClientes.Name = "tabelaClientes";
            tabelaClientes.ReadOnly = true;
            tabelaClientes.RowHeadersWidth = 51;
            tabelaClientes.RowTemplate.Height = 29;
            tabelaClientes.Size = new Size(732, 193);
            tabelaClientes.TabIndex = 2;
            tabelaClientes.CellClick += tabelaClientes_CellClick;
            // 
            // txtSearchCliente
            // 
            txtSearchCliente.Location = new Point(129, 18);
            txtSearchCliente.Name = "txtSearchCliente";
            txtSearchCliente.Size = new Size(340, 27);
            txtSearchCliente.TabIndex = 0;
            txtSearchCliente.TextChanged += txtSearchCliente_TextChanged;
            txtSearchCliente.KeyPress += txtSearchCliente_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 21);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 30;
            label2.Text = "Nome";
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.Highlight;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(16, 404);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(185, 48);
            btnNew.TabIndex = 34;
            btnNew.Text = "Novo";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(207, 404);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(185, 48);
            btnSave.TabIndex = 35;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(603, 404);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(185, 48);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Highlight;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(412, 404);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(185, 48);
            btnEdit.TabIndex = 37;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 459);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(tabCliente);
            Controls.Add(panel1);
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            Load += FormCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabCliente.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabCliente;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cbEstado;
        private TextBox txtNumero;
        private MaskedTextBox mtbCep;
        private MaskedTextBox mtbCpf;
        private MaskedTextBox mtbRg;
        private MaskedTextBox mtbCelular;
        private TextBox txtCidade;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtEndereco;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Button btnSearch;
        private DataGridView tabelaClientes;
        private TextBox txtSearchCliente;
        private Label label2;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtId;
        private Label IdTxt;
    }
}