namespace AppFoodV2.br.com.projects.view
{
    partial class FormVenda
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            txtNome = new TextBox();
            label25 = new Label();
            mtbCpf = new MaskedTextBox();
            label16 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            txtId = new TextBox();
            IdTxt = new Label();
            textBox1 = new TextBox();
            txtDescricao = new TextBox();
            txtPreco = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label2 = new Label();
            btnAddItem = new Button();
            btnRemoverItem = new Button();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            btnPagar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(138, 36);
            label1.TabIndex = 0;
            label1.Text = "Vendas";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 70);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(mtbCpf);
            groupBox1.Controls.Add(label16);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 122);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(88, 68);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(379, 27);
            txtNome.TabIndex = 25;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(18, 71);
            label25.Name = "label25";
            label25.Size = new Size(50, 20);
            label25.TabIndex = 26;
            label25.Text = "Nome";
            // 
            // mtbCpf
            // 
            mtbCpf.Location = new Point(88, 26);
            mtbCpf.Mask = "000.000.000-00";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(206, 27);
            mtbCpf.TabIndex = 23;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 29);
            label16.Name = "label16";
            label16.Size = new Size(33, 20);
            label16.TabIndex = 24;
            label16.Text = "CPF";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(IdTxt);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(txtDescricao);
            groupBox2.Controls.Add(txtPreco);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(483, 250);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 176);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 49;
            label3.Text = "Qtd.";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(127, 174);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(340, 27);
            numericUpDown1.TabIndex = 48;
            // 
            // txtId
            // 
            txtId.Location = new Point(127, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(206, 27);
            txtId.TabIndex = 46;
            // 
            // IdTxt
            // 
            IdTxt.AutoSize = true;
            IdTxt.Location = new Point(20, 29);
            IdTxt.Name = "IdTxt";
            IdTxt.Size = new Size(58, 20);
            IdTxt.TabIndex = 47;
            IdTxt.Text = "Código";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 27);
            textBox1.TabIndex = 40;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(127, 95);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(340, 27);
            txtDescricao.TabIndex = 41;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(127, 133);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(340, 27);
            txtPreco.TabIndex = 42;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(20, 101);
            label17.Name = "label17";
            label17.Size = new Size(74, 20);
            label17.TabIndex = 45;
            label17.Text = "Descrição";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(20, 139);
            label18.Name = "label18";
            label18.Size = new Size(77, 20);
            label18.TabIndex = 44;
            label18.Text = "Preço (R$)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 65);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 43;
            label2.Text = "Nome";
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = SystemColors.Highlight;
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(30, 483);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(219, 48);
            btnAddItem.TabIndex = 35;
            btnAddItem.Text = "Adicionar Item";
            btnAddItem.UseVisualStyleBackColor = false;
            // 
            // btnRemoverItem
            // 
            btnRemoverItem.BackColor = SystemColors.Highlight;
            btnRemoverItem.ForeColor = Color.White;
            btnRemoverItem.Location = new Point(260, 483);
            btnRemoverItem.Name = "btnRemoverItem";
            btnRemoverItem.Size = new Size(219, 48);
            btnRemoverItem.TabIndex = 36;
            btnRemoverItem.Text = "Remover Item";
            btnRemoverItem.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(501, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(437, 310);
            dataGridView1.TabIndex = 37;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(501, 473);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(437, 66);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Total:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(36, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(368, 27);
            textBox3.TabIndex = 50;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(379, 27);
            textBox2.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 71);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 26;
            label5.Text = "Nome";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = SystemColors.Highlight;
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(519, 103);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(195, 48);
            btnPagar.TabIndex = 52;
            btnPagar.Text = "Pagamento";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Highlight;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(720, 104);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(195, 48);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 551);
            Controls.Add(btnPagar);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(btnRemoverItem);
            Controls.Add(btnAddItem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVenda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MaskedTextBox mtbCpf;
        private Label label16;
        private TextBox txtNome;
        private Label label25;
        private TextBox txtId;
        private Label IdTxt;
        private TextBox textBox1;
        private TextBox txtDescricao;
        private TextBox txtPreco;
        private Label label17;
        private Label label18;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button btnAddItem;
        private Button btnRemoverItem;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Button btnPagar;
        private Button btnCancelar;
    }
}