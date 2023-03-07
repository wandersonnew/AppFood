namespace AppFoodV2.br.com.projects.view
{
    partial class FormProduto
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
            tabProduto = new TabControl();
            tabPage1 = new TabPage();
            txtId = new TextBox();
            IdTxt = new Label();
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            txtPreco = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label25 = new Label();
            tabPage2 = new TabPage();
            btnSearch = new Button();
            tabelaProdutos = new DataGridView();
            txtSearchProduto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnNew = new Button();
            tabProduto.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaProdutos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabProduto
            // 
            tabProduto.Controls.Add(tabPage1);
            tabProduto.Controls.Add(tabPage2);
            tabProduto.Location = new Point(12, 100);
            tabProduto.Name = "tabProduto";
            tabProduto.SelectedIndex = 0;
            tabProduto.Size = new Size(776, 277);
            tabProduto.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(IdTxt);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtDescricao);
            tabPage1.Controls.Add(txtPreco);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label25);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 244);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro de Produto";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(128, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(206, 27);
            txtId.TabIndex = 38;
            // 
            // IdTxt
            // 
            IdTxt.AutoSize = true;
            IdTxt.Location = new Point(21, 24);
            IdTxt.Name = "IdTxt";
            IdTxt.Size = new Size(58, 20);
            IdTxt.TabIndex = 39;
            IdTxt.Text = "Código";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(128, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(340, 27);
            txtNome.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(128, 90);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(340, 27);
            txtDescricao.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(128, 128);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(340, 27);
            txtPreco.TabIndex = 2;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(21, 96);
            label17.Name = "label17";
            label17.Size = new Size(74, 20);
            label17.TabIndex = 21;
            label17.Text = "Descrição";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(21, 134);
            label18.Name = "label18";
            label18.Size = new Size(77, 20);
            label18.TabIndex = 20;
            label18.Text = "Preço (R$)";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(21, 60);
            label25.Name = "label25";
            label25.Size = new Size(50, 20);
            label25.TabIndex = 13;
            label25.Text = "Nome";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSearch);
            tabPage2.Controls.Add(tabelaProdutos);
            tabPage2.Controls.Add(txtSearchProduto);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 244);
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
            // tabelaProdutos
            // 
            tabelaProdutos.AllowUserToAddRows = false;
            tabelaProdutos.AllowUserToDeleteRows = false;
            tabelaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaProdutos.Location = new Point(19, 82);
            tabelaProdutos.Name = "tabelaProdutos";
            tabelaProdutos.ReadOnly = true;
            tabelaProdutos.RowHeadersWidth = 51;
            tabelaProdutos.RowTemplate.Height = 29;
            tabelaProdutos.Size = new Size(732, 193);
            tabelaProdutos.TabIndex = 2;
            tabelaProdutos.CellClick += tabelaProdutos_CellClick;
            // 
            // txtSearchProduto
            // 
            txtSearchProduto.Location = new Point(129, 18);
            txtSearchProduto.Name = "txtSearchProduto";
            txtSearchProduto.Size = new Size(340, 27);
            txtSearchProduto.TabIndex = 0;
            txtSearchProduto.KeyPress += txtSearchProduto_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 24);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 30;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(150, 36);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Highlight;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(410, 379);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(185, 48);
            btnEdit.TabIndex = 41;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(601, 379);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(185, 48);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(205, 379);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(185, 48);
            btnSave.TabIndex = 39;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.Highlight;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(14, 379);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(185, 48);
            btnNew.TabIndex = 38;
            btnNew.Text = "Novo";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 441);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(tabProduto);
            Controls.Add(panel1);
            Name = "FormProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProduto";
            Load += FormProduto_Load;
            tabProduto.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaProdutos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabProduto;
        private TabPage tabPage1;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private TextBox txtPreco;
        private Label label17;
        private Label label18;
        private Label label25;
        private TabPage tabPage2;
        private Button btnSearch;
        private DataGridView tabelaProdutos;
        private TextBox txtSearchProduto;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private TextBox txtId;
        private Label IdTxt;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnNew;
    }
}