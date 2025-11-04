using KingoOfKingsClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfKingsclass;

namespace KingOfKingsFrms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntAcessar_Click(object sender, EventArgs e) // método para acessar o sistema
        {
            var registroDeAcesso = new ResgistroDeAcesso();
            var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);

            if (usuario.Id > 0)
            {
             //  registroDeAcesso.RegistrarAcesso();
                if (usuario.Ativo)
                {
                    Program.UsuarioLogado = usuario; 
                    FormPrincipal formPrincipal = new FormPrincipal();
                    formPrincipal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Sua conta está inativa.\nProcure o administrador.", "Conta inativa");
                }
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos ou inexistentes!", "Erro de Login");
            }



        }

       
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {


        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) // método para mostrar a senha
       
        {
            txtSenha.UseSystemPasswordChar = false;
            pictureBox1.Image = Properties.Resources.exibirSenha;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) // método para esconder a senha
        {
            txtSenha.UseSystemPasswordChar = true;
            pictureBox1.Image = Properties.Resources.ocultarSenha;
        }
    }
}
