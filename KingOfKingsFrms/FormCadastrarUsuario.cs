using KingOfKingsClass;
using KingoOfKingsClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingOfKingsFrms
{
    public partial class FormCadastrarUsuario : Form
    {
        public FormCadastrarUsuario()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntVoltar_Click(object sender, EventArgs e) // método para voltar para o form de login
        {
            FormPrincipal formPrincipal = new();
            formPrincipal.Show();
            this.Hide();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            CarregaNivel();
            CarregaGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntCadastrar_Click_1(object sender, EventArgs e) // método para cadastrar o usuário
        {
            if (txtId.Text == string.Empty)
            {
                // INSERIR
                if (txtNome.Text != string.Empty && txtEmail.Text != string.Empty && txtSenha.Text != string.Empty && cmbNivel.SelectedItem != null)
                {
                    Nivel nivelSelecionado = (Nivel)cmbNivel.SelectedItem;

                    Usuario usuario = new(txtNome.Text, txtEmail.Text, txtSenha.Text, nivelSelecionado, true);
                    usuario.Inserir();

                    if (usuario.Id > 0)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        //btnGravar.Enabled = false;
                    }
                }

                CarregaGrid();     // Método que você deve ter para atualizar a grade
                LimpaControles();  // Método para limpar os campos
            }
            else
            {
                // ATUALIZAR
                if (cmbNivel.SelectedItem != null)
                {
                    Nivel nivelSelecionado = (Nivel)cmbNivel.SelectedItem;
                    cmbNivel.DataSource = Nivel.ObterLista();
                    cmbNivel.DisplayMember = "Nome";
                    cmbNivel.ValueMember = "Id";

                    Usuario usuario = new(
                                int.Parse(txtId.Text),
                                txtNome.Text,
                                txtEmail.Text,
                                txtSenha.Text,
                                nivelSelecionado,
                                true
                            );

                    if (usuario.Atualizar())
                    {
                        MessageBox.Show("Usuário atualizado com sucesso!");
                        //btnGravar.Enabled = false;
                    }
                }
            }
        }

        private void cmbTipo_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CarregaGrid()
        {
            var Lista = Usuario.ObterLista();

            // Verifica se retornou dados
            if (Lista == null || Lista.Count == 0)
            {
                MessageBox.Show("Nenhum usuário encontrado.");
                return;
            }

            dgvUsuarios.Rows.Clear();

            foreach (var item in Lista)
            {
                int linha = dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[linha].Cells[0].Value = item.Id;
                dgvUsuarios.Rows[linha].Cells[1].Value = item.Nome;
                dgvUsuarios.Rows[linha].Cells[2].Value = item.Email;
                dgvUsuarios.Rows[linha].Cells[3].Value = item.Nivel != null ? item.Nivel.Nome : "Sem nível";
            }


        }
        public void LimpaControles()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cmbNivel.SelectedIndex = -1;

        }
        private void CarregaNivel()
        {
            List<Nivel> lista = Nivel.ObterLista(); // Este método precisa retornar List<Nivel>
         
            cmbNivel.DataSource = lista;
            cmbNivel.DisplayMember = "Nome"; // o que aparece visualmente
            cmbNivel.ValueMember = "Id";     // valor usado para identificação
            cmbNivel.SelectedIndex = -1;     // nada selecionado inicialmente
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSenha.ReadOnly = false;
            cmbNivel.Enabled = true;
            bntEditar.Enabled = false;
            bntEditar.Enabled = true;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // recuperando o indice da linha do gride 
            int linha = dgvUsuarios.CurrentRow.Index;
            // recuperando o id do nivel na coluna, oculda, ID (0)
            int id = Convert.ToInt32(dgvUsuarios.Rows[linha].Cells[0].Value);
            var usuario = Usuario.ObterporId(id);

            // //obter  o objeto nivel

            // preenche os campos com os dados do usuario
            txtId.Text = usuario.Id.ToString();
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtSenha.Text = usuario.Senha;
            cmbNivel.SelectedValue = usuario.Nivel.Id;
            //desabilita os campos
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            cmbNivel.Enabled = false;
            bntEditar.Enabled = true;
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {

        }
    }

}
