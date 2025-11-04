namespace KingOfKingsFrms
{
    partial class FrmPedido
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            txtIdPedido = new TextBox();
            label2 = new Label();
            label1 = new Label();
            clnQuantidade = new DataGridViewTextBoxColumn();
            txtIdProd = new TextBox();
            label4 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtSubTotalItens = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtSubTotal = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDescontoItem = new TextBox();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtDescontoPedido = new TextBox();
            txtDescontoItens = new TextBox();
            txtTotal = new TextBox();
            btnFechar = new Button();
            txtCodBar = new TextBox();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnSeq = new DataGridViewTextBoxColumn();
            txtDescricao = new TextBox();
            btnAddItem = new Button();
            dgvItensPedido = new DataGridView();
            clnDescricao = new DataGridViewTextBoxColumn();
            label13 = new Label();
            grbItens = new GroupBox();
            button1 = new Button();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            txtNomeCliente = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            grbIndentificacao = new GroupBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            grbItens.SuspendLayout();
            grbIndentificacao.SuspendLayout();
            SuspendLayout();
            // 
            // clnValorUnit
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            clnValorUnit.DefaultCellStyle = dataGridViewCellStyle1;
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnDescontoItem
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            clnDescontoItem.DefaultCellStyle = dataGridViewCellStyle2;
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 70;
            // 
            // clnTotalItem
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            clnTotalItem.DefaultCellStyle = dataGridViewCellStyle3;
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 90;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.ForeColor = Color.Red;
            txtIdPedido.Location = new Point(565, -48);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(181, 43);
            txtIdPedido.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(457, -41);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 16;
            label2.Text = "Número";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(143, -48);
            label1.Name = "label1";
            label1.Size = new Size(169, 31);
            label1.TabIndex = 12;
            label1.Text = "Novo Pedido";
            // 
            // clnQuantidade
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            clnQuantidade.DefaultCellStyle = dataGridViewCellStyle4;
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 70;
            // 
            // txtIdProd
            // 
            txtIdProd.Location = new Point(22, 16);
            txtIdProd.Name = "txtIdProd";
            txtIdProd.Size = new Size(100, 23);
            txtIdProd.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(472, 87);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 15;
            label4.Text = "R$ ";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(463, 40);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Real";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(463, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 19);
            radioButton1.TabIndex = 14;
            radioButton1.Text = "Percentual";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtSubTotalItens
            // 
            txtSubTotalItens.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSubTotalItens.ForeColor = Color.Navy;
            txtSubTotalItens.Location = new Point(509, 479);
            txtSubTotalItens.Name = "txtSubTotalItens";
            txtSubTotalItens.ReadOnly = true;
            txtSubTotalItens.Size = new Size(122, 33);
            txtSubTotalItens.TabIndex = 13;
            txtSubTotalItens.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(339, 482);
            label10.Name = "label10";
            label10.Size = new Size(164, 25);
            label10.TabIndex = 12;
            label10.Text = "Subtotal  Itens R$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(463, 10);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 11;
            label9.Text = "Desconto";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(675, 243);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(118, 23);
            txtSubTotal.TabIndex = 17;
            txtSubTotal.Text = "0,00";
            txtSubTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(404, 42);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 10;
            label8.Text = "Quant.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 42);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 9;
            label7.Text = "Valor Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 42);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 8;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 42);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 7;
            label5.Text = "Código de Barras";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(463, 60);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.RightToLeft = RightToLeft.Yes;
            txtDescontoItem.Size = new Size(70, 23);
            txtDescontoItem.TabIndex = 4;
            txtDescontoItem.Text = "0";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(404, 60);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.RightToLeft = RightToLeft.Yes;
            txtQuantidade.Size = new Size(53, 23);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.Text = "1";
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(339, 60);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(59, 23);
            txtValorUnit.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(675, 386);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 20;
            label14.Text = "Total ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(675, 298);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 21;
            label12.Text = "Desconto Itens ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(675, 224);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 22;
            label11.Text = "SubTotal";
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(675, 360);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(118, 23);
            txtDescontoPedido.TabIndex = 19;
            txtDescontoPedido.Text = "0,00";
            txtDescontoPedido.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(675, 316);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(118, 23);
            txtDescontoItens.TabIndex = 18;
            txtDescontoItens.Text = "0,00";
            txtDescontoItens.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(675, 404);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(118, 29);
            txtTotal.TabIndex = 15;
            txtTotal.Text = "0,00";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(693, 453);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 42);
            btnFechar.TabIndex = 13;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(22, 60);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(110, 23);
            txtCodBar.TabIndex = 0;
            txtCodBar.TextChanged += txtCodBar_TextChanged;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 90;
            // 
            // clnSeq
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            clnSeq.DefaultCellStyle = dataGridViewCellStyle5;
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(138, 60);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(195, 23);
            txtDescricao.TabIndex = 1;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(539, 42);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 42);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "A&dicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvItensPedido.DefaultCellStyle = dataGridViewCellStyle6;
            dgvItensPedido.Location = new Point(6, 112);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.ScrollBars = ScrollBars.Vertical;
            dgvItensPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensPedido.Size = new Size(590, 173);
            dgvItensPedido.TabIndex = 0;
            dgvItensPedido.CellContentClick += dgvItensPedido_CellContentClick;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 170;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(675, 342);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 23;
            label13.Text = "Desconto";
            // 
            // grbItens
            // 
            grbItens.Controls.Add(txtIdProd);
            grbItens.Controls.Add(label4);
            grbItens.Controls.Add(radioButton2);
            grbItens.Controls.Add(radioButton1);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Enabled = false;
            grbItens.Location = new Point(8, 171);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(634, 327);
            grbItens.TabIndex = 11;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(-1, 55);
            button1.Name = "button1";
            button1.Size = new Size(87, 40);
            button1.TabIndex = 3;
            button1.Text = "Cliente";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(506, 22);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(90, 62);
            btnInserePedido.TabIndex = 1;
            btnInserePedido.Text = "Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(92, 61);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(78, 27);
            txtIdCliente.TabIndex = 0;
            txtIdCliente.TextChanged += txtIdCliente_TextChanged;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.Location = new Point(176, 61);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.ReadOnly = true;
            txtNomeCliente.Size = new Size(288, 27);
            txtNomeCliente.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(92, 22);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(372, 27);
            txtUsuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 34);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuário";
            // 
            // grbIndentificacao
            // 
            grbIndentificacao.Controls.Add(button1);
            grbIndentificacao.Controls.Add(btnInserePedido);
            grbIndentificacao.Controls.Add(txtIdCliente);
            grbIndentificacao.Controls.Add(txtNomeCliente);
            grbIndentificacao.Controls.Add(txtUsuario);
            grbIndentificacao.Controls.Add(label3);
            grbIndentificacao.Location = new Point(8, 13);
            grbIndentificacao.Name = "grbIndentificacao";
            grbIndentificacao.Size = new Size(634, 152);
            grbIndentificacao.TabIndex = 10;
            grbIndentificacao.TabStop = false;
            grbIndentificacao.Text = "Identificação";
            // 
            // Column1
            // 
            Column1.HeaderText = "Item";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Código de barras";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Descrição";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Valor unitario";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Quantidade";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Desconto";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 526);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSubTotal);
            Controls.Add(txtSubTotalItens);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtDescontoPedido);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtTotal);
            Controls.Add(btnFechar);
            Controls.Add(label13);
            Controls.Add(grbItens);
            Controls.Add(grbIndentificacao);
            Name = "FrmPedido";
            Text = "FromPedido";
            Load += FromPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            grbIndentificacao.ResumeLayout(false);
            grbIndentificacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
        private TextBox txtIdPedido;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn clnQuantidade;
        private TextBox txtIdProd;
        private Label label4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txtSubTotalItens;
        private Label label10;
        private Label label9;
        private TextBox txtSubTotal;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDescontoItem;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private Label label14;
        private Label label12;
        private Label label11;
        private TextBox txtDescontoPedido;
        private TextBox txtDescontoItens;
        private TextBox txtTotal;
        private Button btnFechar;
        private TextBox txtCodBar;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnSeq;
        private TextBox txtDescricao;
        private Button btnAddItem;
        private DataGridView dgvItensPedido;
        private DataGridViewTextBoxColumn clnDescricao;
        private Label label13;
        private GroupBox grbItens;
        private Button button1;
        private Button btnInserePedido;
        private TextBox txtIdCliente;
        private TextBox txtNomeCliente;
        private TextBox txtUsuario;
        private Label label3;
        private GroupBox grbIndentificacao;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}