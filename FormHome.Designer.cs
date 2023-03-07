namespace AppFoodV2
{
    partial class FormHome
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnVendas = new Button();
            btnProdutos = new Button();
            btnClientes = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(319, 36);
            label1.TabIndex = 0;
            label1.Text = "Cantina do Tio Bill";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVendas);
            groupBox1.Controls.Add(btnProdutos);
            groupBox1.Controls.Add(btnClientes);
            groupBox1.Location = new Point(30, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 315);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gerenciar";
            // 
            // btnVendas
            // 
            btnVendas.BackColor = SystemColors.Highlight;
            btnVendas.ForeColor = Color.White;
            btnVendas.Location = new Point(250, 227);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(244, 48);
            btnVendas.TabIndex = 4;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = SystemColors.Highlight;
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Location = new Point(250, 123);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(244, 48);
            btnProdutos.TabIndex = 3;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.Highlight;
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(250, 26);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(244, 48);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cantina Tio Bill";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnVendas;
        private Button btnProdutos;
        private Button btnClientes;
    }
}