namespace KingOfKingsFrms
{
    partial class FormCupom
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtTitulo = new TextBox();
            label6 = new Label();
            txtlimiteParaMesmoUser = new TextBox();
            label7 = new Label();
            txtCodigo = new TextBox();
            dateDataInicio = new DateTimePicker();
            dateExpiracao = new DateTimePicker();
            label8 = new Label();
            label4 = new Label();
            txtCupomTipo = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            cmbTipoDesconto = new ComboBox();
            txtDesconto = new TextBox();
            txtValorMaximoDesconto = new TextBox();
            txtPedidoMinimo = new TextBox();
            checkBoxAtivo = new CheckBox();
            btnEditar = new Button();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            btnSair = new Button();
            dgvCupom = new DataGridView();
            ClnTitulo = new DataGridViewTextBoxColumn();
            clnId = new DataGridViewTextBoxColumn();
            ClnCupomTipo = new DataGridViewTextBoxColumn();
            clnLimiteParaMesmoUsuario = new DataGridViewTextBoxColumn();
            clnCodigo = new DataGridViewTextBoxColumn();
            clnDataInicio = new DataGridViewTextBoxColumn();
            clnDataEnspiração = new DataGridViewTextBoxColumn();
            clnValorpedido = new DataGridViewTextBoxColumn();
            clnValorMaximo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnTipoDesconto = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            txtDescricao = new TextBox();
            label12 = new Label();
            txtBuscar = new TextBox();
            label13 = new Label();
            txtId = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCupom).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(219, 179, 91);
            label1.Location = new Point(410, 26);
            label1.Name = "label1";
            label1.Size = new Size(319, 34);
            label1.TabIndex = 0;
            label1.Text = "Cupom de Desconto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(55, 92);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "&Titulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(219, 179, 91);
            label3.Location = new Point(55, 136);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "&Codigo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.FromArgb(219, 179, 91);
            label5.Location = new Point(254, 136);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 4;
            label5.Text = "Data de &inicio";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(56, 110);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(182, 23);
            txtTitulo.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.FromArgb(219, 179, 91);
            label6.Location = new Point(254, 92);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 8;
            label6.Text = "C&upom Tipo ";
            // 
            // txtlimiteParaMesmoUser
            // 
            txtlimiteParaMesmoUser.Location = new Point(476, 110);
            txtlimiteParaMesmoUser.Name = "txtlimiteParaMesmoUser";
            txtlimiteParaMesmoUser.Size = new Size(182, 23);
            txtlimiteParaMesmoUser.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.FromArgb(219, 179, 91);
            label7.Location = new Point(485, 92);
            label7.Name = "label7";
            label7.Size = new Size(151, 15);
            label7.TabIndex = 10;
            label7.Text = "&Limite para mesmo usuário";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(55, 154);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(182, 23);
            txtCodigo.TabIndex = 11;
            // 
            // dateDataInicio
            // 
            dateDataInicio.Location = new Point(254, 154);
            dateDataInicio.Name = "dateDataInicio";
            dateDataInicio.Size = new Size(200, 23);
            dateDataInicio.TabIndex = 12;
            // 
            // dateExpiracao
            // 
            dateExpiracao.Location = new Point(476, 154);
            dateExpiracao.Name = "dateExpiracao";
            dateExpiracao.Size = new Size(200, 23);
            dateExpiracao.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.FromArgb(219, 179, 91);
            label8.Location = new Point(476, 136);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 14;
            label8.Text = "Data de &expiração";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(219, 179, 91);
            label4.Location = new Point(55, 189);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 15;
            label4.Text = "&Valor pedido minimo";
            // 
            // txtCupomTipo
            // 
            txtCupomTipo.FormattingEnabled = true;
            txtCupomTipo.Location = new Point(254, 110);
            txtCupomTipo.Name = "txtCupomTipo";
            txtCupomTipo.Size = new Size(200, 23);
            txtCupomTipo.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F);
            label9.ForeColor = Color.FromArgb(219, 179, 91);
            label9.Location = new Point(254, 189);
            label9.Name = "label9";
            label9.Size = new Size(147, 15);
            label9.TabIndex = 17;
            label9.Text = "V&alor máximo de desconto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F);
            label10.ForeColor = Color.FromArgb(219, 179, 91);
            label10.Location = new Point(437, 189);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 18;
            label10.Text = "&Desconto";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F);
            label11.ForeColor = Color.FromArgb(219, 179, 91);
            label11.Location = new Point(580, 189);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 19;
            label11.Text = "&Tipo desconto";
            // 
            // cmbTipoDesconto
            // 
            cmbTipoDesconto.FormattingEnabled = true;
            cmbTipoDesconto.Items.AddRange(new object[] { "Percentual", "Real" });
            cmbTipoDesconto.Location = new Point(580, 207);
            cmbTipoDesconto.Name = "cmbTipoDesconto";
            cmbTipoDesconto.Size = new Size(169, 23);
            cmbTipoDesconto.TabIndex = 20;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(437, 207);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(137, 23);
            txtDesconto.TabIndex = 21;
            // 
            // txtValorMaximoDesconto
            // 
            txtValorMaximoDesconto.Location = new Point(254, 207);
            txtValorMaximoDesconto.Name = "txtValorMaximoDesconto";
            txtValorMaximoDesconto.Size = new Size(147, 23);
            txtValorMaximoDesconto.TabIndex = 22;
            // 
            // txtPedidoMinimo
            // 
            txtPedidoMinimo.Location = new Point(55, 207);
            txtPedidoMinimo.Name = "txtPedidoMinimo";
            txtPedidoMinimo.Size = new Size(147, 23);
            txtPedidoMinimo.TabIndex = 23;
            // 
            // checkBoxAtivo
            // 
            checkBoxAtivo.AutoSize = true;
            checkBoxAtivo.BackColor = Color.Transparent;
            checkBoxAtivo.ForeColor = Color.FromArgb(219, 179, 91);
            checkBoxAtivo.Location = new Point(682, 250);
            checkBoxAtivo.Name = "checkBoxAtivo";
            checkBoxAtivo.Size = new Size(57, 19);
            checkBoxAtivo.TabIndex = 5;
            checkBoxAtivo.Text = "Ativar";
            checkBoxAtivo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.ForeColor = Color.FromArgb(219, 179, 91);
            btnEditar.Location = new Point(127, 450);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 25;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Black;
            btnCadastrar.ForeColor = Color.FromArgb(219, 179, 91);
            btnCadastrar.Location = new Point(218, 450);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 26;
            btnCadastrar.Text = "&Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Black;
            btnExcluir.ForeColor = Color.FromArgb(219, 179, 91);
            btnExcluir.Location = new Point(317, 450);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 27;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Black;
            btnSair.FlatAppearance.BorderColor = Color.FromArgb(219, 179, 91);
            btnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(219, 179, 91);
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 179, 91);
            btnSair.ForeColor = Color.FromArgb(219, 179, 91);
            btnSair.Location = new Point(410, 450);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 28;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += button5_Click;
            // 
            // dgvCupom
            // 
            dgvCupom.BackgroundColor = Color.Black;
            dgvCupom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCupom.Columns.AddRange(new DataGridViewColumn[] { ClnTitulo, clnId, ClnCupomTipo, clnLimiteParaMesmoUsuario, clnCodigo, clnDataInicio, clnDataEnspiração, clnValorpedido, clnValorMaximo, clnDesconto, clnTipoDesconto, clnDescricao });
            dgvCupom.GridColor = Color.FromArgb(219, 179, 91);
            dgvCupom.Location = new Point(7, 268);
            dgvCupom.Name = "dgvCupom";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(219, 179, 91);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCupom.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCupom.RowHeadersVisible = false;
            dgvCupom.Size = new Size(1103, 157);
            dgvCupom.TabIndex = 29;
            // 
            // ClnTitulo
            // 
            ClnTitulo.HeaderText = "Titulo";
            ClnTitulo.Name = "ClnTitulo";
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.Visible = false;
            // 
            // ClnCupomTipo
            // 
            ClnCupomTipo.HeaderText = "Cupom Tipo";
            ClnCupomTipo.Name = "ClnCupomTipo";
            // 
            // clnLimiteParaMesmoUsuario
            // 
            clnLimiteParaMesmoUsuario.HeaderText = "Limite de uso";
            clnLimiteParaMesmoUsuario.Name = "clnLimiteParaMesmoUsuario";
            // 
            // clnCodigo
            // 
            clnCodigo.HeaderText = "Codigo";
            clnCodigo.Name = "clnCodigo";
            // 
            // clnDataInicio
            // 
            clnDataInicio.HeaderText = "Data inicio";
            clnDataInicio.Name = "clnDataInicio";
            // 
            // clnDataEnspiração
            // 
            clnDataEnspiração.HeaderText = "Data Expiração";
            clnDataEnspiração.Name = "clnDataEnspiração";
            // 
            // clnValorpedido
            // 
            clnValorpedido.HeaderText = "Valor pedido Minimo";
            clnValorpedido.Name = "clnValorpedido";
            // 
            // clnValorMaximo
            // 
            clnValorMaximo.HeaderText = "Valor Max Desconto";
            clnValorMaximo.Name = "clnValorMaximo";
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            // 
            // clnTipoDesconto
            // 
            clnTipoDesconto.HeaderText = "Tipo Desconto";
            clnTipoDesconto.Name = "clnTipoDesconto";
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(115, 239);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(548, 23);
            txtDescricao.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9F);
            label12.ForeColor = Color.FromArgb(219, 179, 91);
            label12.Location = new Point(51, 242);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 31;
            label12.Text = "&Descriçao";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(56, 66);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(137, 23);
            txtBuscar.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9F);
            label13.ForeColor = Color.FromArgb(219, 179, 91);
            label13.Location = new Point(56, 48);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 33;
            label13.Text = "&Buscar";
            // 
            // txtId
            // 
            txtId.Location = new Point(55, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(38, 23);
            txtId.TabIndex = 34;
            txtId.Text = "Id";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.ForeColor = Color.FromArgb(219, 179, 91);
            btnBuscar.Location = new Point(46, 450);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 35;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // FormCupom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Leao_alter;
            ClientSize = new Size(1169, 503);
            Controls.Add(btnBuscar);
            Controls.Add(txtId);
            Controls.Add(label13);
            Controls.Add(txtBuscar);
            Controls.Add(label12);
            Controls.Add(txtDescricao);
            Controls.Add(dgvCupom);
            Controls.Add(btnSair);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEditar);
            Controls.Add(txtPedidoMinimo);
            Controls.Add(txtValorMaximoDesconto);
            Controls.Add(txtDesconto);
            Controls.Add(cmbTipoDesconto);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtCupomTipo);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(dateExpiracao);
            Controls.Add(dateDataInicio);
            Controls.Add(txtCodigo);
            Controls.Add(label7);
            Controls.Add(txtlimiteParaMesmoUser);
            Controls.Add(label6);
            Controls.Add(txtTitulo);
            Controls.Add(checkBoxAtivo);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCupom";
            Text = "Cupom";
            Load += FormCupom_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCupom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtTitulo;
        private Label label6;
        private TextBox txtlimiteParaMesmoUser;
        private Label label7;
        private TextBox txtCodigo;
        private DateTimePicker dateDataInicio;
        private DateTimePicker dateExpiracao;
        private Label label8;
        private Label label4;
        private ComboBox txtCupomTipo;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox cmbTipoDesconto;
        private TextBox txtDesconto;
        private TextBox txtValorMaximoDesconto;
        private TextBox txtPedidoMinimo;
        private CheckBox checkBoxAtivo;
        private Button btnAtualizar;
        private Button btnEditar;
        private Button btnCadastrar;
        private Button btnExcluir;
        private Button btnSair;
        private DataGridView dgvCupom;
        private TextBox txtDescricao;
        private Label label12;
        private TextBox txtBuscar;
        private Label label13;
        private DataGridViewTextBoxColumn ClnTitulo;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn ClnCupomTipo;
        private DataGridViewTextBoxColumn clnLimiteParaMesmoUsuario;
        private DataGridViewTextBoxColumn clnCodigo;
        private DataGridViewTextBoxColumn clnDataInicio;
        private DataGridViewTextBoxColumn clnDataEnspiração;
        private DataGridViewTextBoxColumn clnValorpedido;
        private DataGridViewTextBoxColumn clnValorMaximo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnTipoDesconto;
        private DataGridViewTextBoxColumn clnDescricao;
        private TextBox txtId;
        private Button btnBuscar;
    }
}