namespace KingOfKingsFrms
{
    partial class FormLogin
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            bntAcessar = new Button();
            linkLabel1 = new LinkLabel();
            panel3 = new Panel();
            panel4 = new Panel();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.zentralC_;
            panel1.Location = new Point(188, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 40);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(173, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 23);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "Usuario";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(173, 160);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(237, 23);
            txtSenha.TabIndex = 2;
            txtSenha.Text = "Senha";
            // 
            // bntAcessar
            // 
            bntAcessar.BackColor = Color.White;
            bntAcessar.Cursor = Cursors.Hand;
            bntAcessar.FlatStyle = FlatStyle.Flat;
            bntAcessar.Location = new Point(188, 189);
            bntAcessar.Name = "bntAcessar";
            bntAcessar.Size = new Size(190, 27);
            bntAcessar.TabIndex = 3;
            bntAcessar.Text = "Acessar";
            bntAcessar.UseVisualStyleBackColor = false;
            bntAcessar.Click += bntAcessar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabel1.Location = new Point(494, 313);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(26, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sair";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.usuarioNovo__1_;
            panel3.Location = new Point(126, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(41, 37);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.senhaNovo;
            panel4.Location = new Point(126, 153);
            panel4.Name = "panel4";
            panel4.Size = new Size(41, 39);
            panel4.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(416, 164);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 12;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(532, 337);
            Controls.Add(panel4);
            Controls.Add(checkBox1);
            Controls.Add(panel3);
            Controls.Add(linkLabel1);
            Controls.Add(bntAcessar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button bntAcessar;
        private LinkLabel linkLabel1;
        private Panel panel3;
        private Panel panel4;
        private CheckBox checkBox1;
    }
}