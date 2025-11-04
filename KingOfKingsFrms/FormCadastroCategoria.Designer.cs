namespace KingOfKingsFrms
{
    partial class FormCadastroCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCategoria));
            dataGridView1 = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnCodigo = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnID, clnCodigo, clnDescricao });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(76, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(398, 158);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnID
            // 
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Width = 50;
            // 
            // clnCodigo
            // 
            clnCodigo.HeaderText = "Codigo";
            clnCodigo.Name = "clnCodigo";
            clnCodigo.ReadOnly = true;
            clnCodigo.Width = 150;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(219, 179, 91);
            label1.Location = new Point(157, 134);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Categorias";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.FromArgb(219, 179, 91);
            button1.Location = new Point(76, 190);
            button1.Name = "button1";
            button1.Size = new Size(98, 41);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(176, 190);
            button2.Name = "button2";
            button2.Size = new Size(101, 41);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(393, 189);
            button3.Name = "button3";
            button3.Size = new Size(101, 41);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(283, 190);
            button4.Name = "button4";
            button4.Size = new Size(104, 40);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F);
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(295, 26);
            label2.Name = "label2";
            label2.Size = new Size(159, 41);
            label2.TabIndex = 8;
            label2.Text = "Categorias";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(226, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(219, 179, 91);
            label3.Location = new Point(163, 102);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Pesquisar";
            // 
            // FormCadastroCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastroCategoria";
            Text = "FormCadastroCategoria";
            Load += FormCadastroCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnCodigo;
        private DataGridViewTextBoxColumn clnDescricao;
        private TextBox textBox2;
        private Label label3;
    }
}