namespace KingOfKingsFrms
{
    partial class FormClientes
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
            Daodo = new TabControl();
            tabPage1 = new TabPage();
            txtClienteId = new TextBox();
            mxtTelefone = new MaskedTextBox();
            mxtCpf = new MaskedTextBox();
            btnEditar = new Button();
            button1 = new Button();
            dtpDataNasc = new DateTimePicker();
            label8 = new Label();
            btnCadastrar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            tabPage2 = new TabPage();
            txtUf = new TextBox();
            mxtCep = new MaskedTextBox();
            btninserir = new Button();
            cmbUF = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            cmbTipoEndereco = new ComboBox();
            label12 = new Label();
            txtCidade = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label1 = new Label();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            dgvEnderecos = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            clnCep = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            bntBuscar = new Button();
            Daodo.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            SuspendLayout();
            // 
            // Daodo
            // 
            Daodo.Controls.Add(tabPage1);
            Daodo.Controls.Add(tabPage2);
            Daodo.Location = new Point(12, 17);
            Daodo.Multiline = true;
            Daodo.Name = "Daodo";
            Daodo.SelectedIndex = 0;
            Daodo.Size = new Size(776, 404);
            Daodo.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.BackgroundImage = Properties.Resources.leaoFundo;
            tabPage1.Controls.Add(bntBuscar);
            tabPage1.Controls.Add(txtClienteId);
            tabPage1.Controls.Add(mxtTelefone);
            tabPage1.Controls.Add(mxtCpf);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dtpDataNasc);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btnCadastrar);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 376);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            // 
            // txtClienteId
            // 
            txtClienteId.BackColor = SystemColors.ActiveBorder;
            txtClienteId.Location = new Point(653, 347);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(100, 23);
            txtClienteId.TabIndex = 62;
            txtClienteId.Text = "0";
            // 
            // mxtTelefone
            // 
            mxtTelefone.BackColor = SystemColors.ActiveBorder;
            mxtTelefone.Location = new Point(176, 128);
            mxtTelefone.Mask = "(99) 00000-0000";
            mxtTelefone.Name = "mxtTelefone";
            mxtTelefone.Size = new Size(173, 23);
            mxtTelefone.TabIndex = 68;
            // 
            // mxtCpf
            // 
            mxtCpf.BackColor = SystemColors.ActiveBorder;
            mxtCpf.Location = new Point(355, 128);
            mxtCpf.Mask = "000.000.000-00";
            mxtCpf.Name = "mxtCpf";
            mxtCpf.Size = new Size(107, 23);
            mxtCpf.TabIndex = 67;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = Properties.Resources.EditarGbtn;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(296, 212);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(103, 38);
            btnEditar.TabIndex = 66;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.bntVoltar;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(176, 214);
            button1.Name = "button1";
            button1.Size = new Size(102, 35);
            button1.TabIndex = 65;
            button1.UseVisualStyleBackColor = true;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.CalendarMonthBackground = SystemColors.ActiveBorder;
            dtpDataNasc.Location = new Point(176, 173);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(173, 23);
            dtpDataNasc.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F);
            label8.ForeColor = Color.FromArgb(219, 179, 91);
            label8.Location = new Point(176, 66);
            label8.Name = "label8";
            label8.Size = new Size(44, 16);
            label8.TabIndex = 62;
            label8.Text = "Nome";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackgroundImage = Properties.Resources.bntCadastrar;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(421, 211);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(99, 38);
            btnCadastrar.TabIndex = 60;
            btnCadastrar.Text = " ";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 21.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(219, 179, 91);
            label6.Location = new Point(220, 17);
            label6.Name = "label6";
            label6.Size = new Size(323, 34);
            label6.TabIndex = 59;
            label6.Text = "Cadastrar  Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.ForeColor = Color.FromArgb(219, 179, 91);
            label5.Location = new Point(176, 154);
            label5.Name = "label5";
            label5.Size = new Size(127, 16);
            label5.TabIndex = 58;
            label5.Text = "Data de nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.ForeColor = Color.FromArgb(219, 179, 91);
            label4.Location = new Point(358, 64);
            label4.Name = "label4";
            label4.Size = new Size(41, 16);
            label4.TabIndex = 57;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Cursor = Cursors.SizeNWSE;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.ForeColor = Color.FromArgb(219, 179, 91);
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label3.Location = new Point(176, 109);
            label3.Name = "label3";
            label3.Size = new Size(61, 16);
            label3.TabIndex = 56;
            label3.Text = "Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.ForeColor = Color.FromArgb(219, 179, 91);
            label2.Location = new Point(353, 111);
            label2.Name = "label2";
            label2.Size = new Size(27, 16);
            label2.TabIndex = 55;
            label2.Text = "Cpf";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ActiveBorder;
            txtEmail.Location = new Point(356, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(134, 23);
            txtEmail.TabIndex = 54;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ActiveBorder;
            txtNome.Location = new Point(176, 83);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(174, 23);
            txtNome.TabIndex = 51;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.leaoFundo;
            tabPage2.Controls.Add(txtUf);
            tabPage2.Controls.Add(mxtCep);
            tabPage2.Controls.Add(btninserir);
            tabPage2.Controls.Add(cmbUF);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(cmbTipoEndereco);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(txtCidade);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtComplemento);
            tabPage2.Controls.Add(txtBairro);
            tabPage2.Controls.Add(txtLogradouro);
            tabPage2.Controls.Add(txtNumero);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 376);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Endereço";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click_1;
            // 
            // txtUf
            // 
            txtUf.BackColor = SystemColors.ActiveBorder;
            txtUf.Location = new Point(316, 232);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(100, 23);
            txtUf.TabIndex = 66;
            // 
            // mxtCep
            // 
            mxtCep.BackColor = SystemColors.ActiveBorder;
            mxtCep.Location = new Point(155, 86);
            mxtCep.Mask = "00000-000";
            mxtCep.Name = "mxtCep";
            mxtCep.Size = new Size(91, 23);
            mxtCep.TabIndex = 64;
            mxtCep.MaskInputRejected += mxtCep_MaskInputRejected;
            mxtCep.Leave += mxtCep_Leave;
            // 
            // btninserir
            // 
            btninserir.BackgroundImage = Properties.Resources.SalvarGbtn;
            btninserir.FlatStyle = FlatStyle.Flat;
            btninserir.Location = new Point(435, 312);
            btninserir.Name = "btninserir";
            btninserir.Size = new Size(103, 43);
            btninserir.TabIndex = 62;
            btninserir.UseVisualStyleBackColor = true;
            btninserir.Click += btninserir_Click;
            // 
            // cmbUF
            // 
            cmbUF.BackColor = SystemColors.ActiveBorder;
            cmbUF.FormattingEnabled = true;
            cmbUF.Items.AddRange(new object[] { "AC", "AL", "AP ", "AM", "BA ", "CE ", "DF ", "ES ", "GO", "MA ", "MT ", "MS ", "MG ", "PA", "PB", "PR", "PE", "PI ", "RJ", "RN ", "RS ", "RO ", "RR ", "SC", "SP", "SE", "TO" });
            cmbUF.Location = new Point(290, 146);
            cmbUF.Name = "cmbUF";
            cmbUF.Size = new Size(46, 23);
            cmbUF.TabIndex = 61;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Stencil", 21.75F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(219, 179, 91);
            label14.Location = new Point(307, 45);
            label14.Name = "label14";
            label14.Size = new Size(167, 34);
            label14.TabIndex = 60;
            label14.Text = "ENDEREÇO";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(219, 179, 91);
            label13.Location = new Point(59, 235);
            label13.Name = "label13";
            label13.Size = new Size(82, 15);
            label13.TabIndex = 14;
            label13.Text = "Tipo endereço";
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.BackColor = SystemColors.ActiveBorder;
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Items.AddRange(new object[] { "RESIDENCIAL", "COMERCIAL" });
            cmbTipoEndereco.Location = new Point(155, 232);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(136, 23);
            cmbTipoEndereco.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(219, 179, 91);
            label12.Location = new Point(98, 149);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 12;
            label12.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.BackColor = SystemColors.ActiveBorder;
            txtCidade.Location = new Point(155, 146);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(120, 23);
            txtCidade.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(219, 179, 91);
            label11.Location = new Point(435, 117);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 10;
            label11.Text = "N°";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(219, 179, 91);
            label10.Location = new Point(58, 206);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 9;
            label10.Text = "Complemento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(219, 179, 91);
            label9.Location = new Point(104, 175);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 8;
            label9.Text = "Bairro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(219, 179, 91);
            label7.Location = new Point(74, 114);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 7;
            label7.Text = "Logradouro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(219, 179, 91);
            label1.Location = new Point(114, 86);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 6;
            label1.Text = "CEP";
            // 
            // txtComplemento
            // 
            txtComplemento.BackColor = SystemColors.ActiveBorder;
            txtComplemento.Location = new Point(155, 203);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(261, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtBairro
            // 
            txtBairro.BackColor = SystemColors.ActiveBorder;
            txtBairro.Location = new Point(155, 175);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(261, 23);
            txtBairro.TabIndex = 4;
            // 
            // txtLogradouro
            // 
            txtLogradouro.BackColor = SystemColors.ActiveBorder;
            txtLogradouro.Location = new Point(155, 117);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(261, 23);
            txtLogradouro.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = SystemColors.ActiveBorder;
            txtNumero.Location = new Point(462, 114);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(63, 23);
            txtNumero.TabIndex = 1;
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.AllowUserToDeleteRows = false;
            dgvEnderecos.BackgroundColor = Color.Black;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { nome, clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade });
            dgvEnderecos.GridColor = SystemColors.InactiveCaptionText;
            dgvEnderecos.Location = new Point(114, 442);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.ReadOnly = true;
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.Size = new Size(602, 149);
            dgvEnderecos.TabIndex = 61;
            dgvEnderecos.CellContentClick += dgvEnderecos_CellContentClick;
            // 
            // nome
            // 
            nome.HeaderText = "Id";
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Visible = false;
            nome.Width = 160;
            // 
            // clnCep
            // 
            clnCep.HeaderText = "cep";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            // 
            // clnLogradouro
            // 
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            // 
            // clnNumero
            // 
            clnNumero.HeaderText = "Numero";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            // 
            // clnComplemento
            // 
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            // 
            // clnCidade
            // 
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            // 
            // bntBuscar
            // 
            bntBuscar.Location = new Point(506, 84);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(75, 23);
            bntBuscar.TabIndex = 69;
            bntBuscar.Text = "button2";
            bntBuscar.UseVisualStyleBackColor = true;
            bntBuscar.Click += bntBuscar_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 631);
            Controls.Add(Daodo);
            Controls.Add(dgvEnderecos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClientes";
            Text = "Form1";
            Load += Form1_Load;
            Daodo.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Daodo;
        private TabPage tabPage1;
        private MaskedTextBox mxtTelefone;
        private MaskedTextBox mxtCpf;
        private Button btnEditar;
        private Button button1;
        private DateTimePicker dtpDataNasc;
        private Label label8;
        private Button btnCadastrar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TabPage tabPage2;
        private MaskedTextBox mxtCep;
        private Button btninserir;
        private Label label14;
        private Label label13;
        private ComboBox cmbTipoEndereco;
        private Label label12;
        private TextBox txtCidade;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label1;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private DataGridView dgvEnderecos;
        private TextBox txtUf;
        private ComboBox cmbUF;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private TextBox txtClienteId;
        private Button bntBuscar;
    }
}