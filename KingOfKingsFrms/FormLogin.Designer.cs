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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            bntAcessar = new Button();
            linkLabel1 = new LinkLabel();
            panel3 = new Panel();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.kingLeaoLogin;
            panel1.Location = new Point(34, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 77);
            panel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(163, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(164, 160);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(237, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // bntAcessar
            // 
            bntAcessar.BackColor = SystemColors.ActiveCaptionText;
            bntAcessar.BackgroundImage = Properties.Resources.bntAcessar;
            bntAcessar.Cursor = Cursors.Hand;
            bntAcessar.FlatStyle = FlatStyle.Flat;
            bntAcessar.Location = new Point(220, 195);
            bntAcessar.Name = "bntAcessar";
            bntAcessar.Size = new Size(100, 38);
            bntAcessar.TabIndex = 3;
            bntAcessar.UseVisualStyleBackColor = false;
            bntAcessar.Click += bntAcessar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(192, 192, 0);
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
            panel3.BackgroundImage = Properties.Resources.usuario_login___1_;
            panel3.Location = new Point(127, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(30, 30);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.usuario_senha;
            panel4.Controls.Add(flowLayoutPanel1);
            panel4.Location = new Point(129, 160);
            panel4.Name = "panel4";
            panel4.Size = new Size(28, 29);
            panel4.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(21, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.ocultarSenha;
            pictureBox1.Location = new Point(397, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 38);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(219, 179, 91);
            label1.Location = new Point(220, 70);
            label1.Name = "label1";
            label1.Size = new Size(101, 34);
            label1.TabIndex = 12;
            label1.Text = "Login";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(532, 337);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
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
            Load += FormLogin_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}