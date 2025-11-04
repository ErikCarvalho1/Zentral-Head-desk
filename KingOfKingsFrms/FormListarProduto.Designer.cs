namespace KingOfKingsFrms
{
    partial class FormListarProduto
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
            dgvProduto = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtProdutos = new TextBox();
            Produtos = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            SuspendLayout();
            // 
            // dgvProduto
            // 
            dgvProduto.BackgroundColor = Color.White;
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4 });
            dgvProduto.Location = new Point(227, 137);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.RowHeadersVisible = false;
            dgvProduto.Size = new Size(389, 304);
            dgvProduto.TabIndex = 0;
            dgvProduto.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.Visible = false;
            Column1.Width = 160;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nome";
            Column3.Name = "Column3";
            Column3.Width = 185;
            // 
            // Column2
            // 
            Column2.HeaderText = "Codbarras";
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "Valor unitario";
            Column4.Name = "Column4";
            // 
            // txtProdutos
            // 
            txtProdutos.Location = new Point(248, 106);
            txtProdutos.Name = "txtProdutos";
            txtProdutos.Size = new Size(311, 23);
            txtProdutos.TabIndex = 2;
            txtProdutos.TextChanged += txtProdutos_TextChanged;
            // 
            // Produtos
            // 
            Produtos.AutoSize = true;
            Produtos.BackColor = Color.White;
            Produtos.ForeColor = Color.Black;
            Produtos.Location = new Point(187, 109);
            Produtos.Name = "Produtos";
            Produtos.Size = new Size(55, 15);
            Produtos.TabIndex = 3;
            Produtos.Text = "Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Bernard MT Condensed", 21.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(330, 35);
            label2.Name = "label2";
            label2.Size = new Size(183, 34);
            label2.TabIndex = 18;
            label2.Text = "Listar Produtos";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(565, 101);
            button1.Name = "button1";
            button1.Size = new Size(96, 30);
            button1.TabIndex = 19;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormListarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(887, 517);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Produtos);
            Controls.Add(txtProdutos);
            Controls.Add(dgvProduto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListarProduto";
            Text = "FormProduto";
            Load += FormListarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduto;
        private TextBox txtProdutos;
        private Label Produtos;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
    }
}