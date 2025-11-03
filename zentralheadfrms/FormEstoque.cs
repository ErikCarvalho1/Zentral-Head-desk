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
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }



        private void FormEstoque_Load(object sender, EventArgs e)
        {
            var lista = Estoque.ObterLista();
            int linha = 0;
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.Rows.Clear();
            foreach (var item in lista)
            {
                dgvEstoque.Rows.Add();
                dgvEstoque.Rows[linha].Cells[0].Value = item.Id;
                dgvEstoque.Rows[linha].Cells[1].Value = item.ProdutoId;
                dgvEstoque.Rows[linha].Cells[2].Value = item.NomeProduto;
                dgvEstoque.Rows[linha].Cells[3].Value = item.Quantidade;
                dgvEstoque.Rows[linha].Cells[4].Value = item.DataUltimoMovimento;
                linha++;
            }
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {

            string id = txtProdutoId.Text.Trim();
            string quantidade = txtQuantidade.Text.Trim();
            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(quantidade))
            {
                MessageBox.Show("Preencha o ID e a quantidade.");
                return;
            }

            bool encontrou = false;

            foreach (DataGridViewRow row in dgvEstoque.Rows)
            {
                if (row.IsNewRow) continue;

                
                var cellId = row.Cells["Id"].Value;

                if (cellId != null && cellId.ToString() == id)
                {
                    row.Cells["Quantidade"].Value = quantidade;
                    row.Cells["DataMovimento"].Value = dataAtual;

                    encontrou = true;
                    break;
                }
            }

            if (!encontrou)
            {
                MessageBox.Show("Produto com esse ID não foi encontrado.");
            }
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {


            string termo = txtNome.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(termo))
            {
                foreach (DataGridViewRow row in dgvEstoque.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            string novaQuantidade = txtQuantidade.Text.Trim();
            bool encontrou = false;

            foreach (DataGridViewRow row in dgvEstoque.Rows)
            {
                if (row.IsNewRow) continue;


                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(termo))
                    {
                        row.Visible = true;
                        encontrou = true;
                        break;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

            if (!encontrou)
            {
                MessageBox.Show("Nenhum item encontrado.");
            }


        }

        private void txtAdicionarEstoque_ValueChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string idAlvo = txtProdutoId.Text.Trim();
            string novaQuantidade = txtQuantidade.Text.Trim();

            foreach (DataGridViewRow row in dgvEstoque.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == idAlvo)
                {
                    row.Cells[0].Value = novaQuantidade;
                    break;
                }
            }
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


          
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEstoqueId.Text))
            {
                MessageBox.Show("Selecione um lançamento para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            if (!int.TryParse(txtEstoqueId.Text, out int estoqueId))
            {
                MessageBox.Show("ID do estoque inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtProdutoId.Text, out int produtoId))
            {
                MessageBox.Show("ID do produto inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtQuantidade.Text, out double quantidade))
            {
                MessageBox.Show("Quantidade inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Estoque estoque = new Estoque
                {
                    Id = estoqueId,
                    ProdutoId = produtoId,
                    Quantidade = quantidade,
                    DataUltimoMovimento = dateUltimoMovimento.Value
                };

                estoque.Atualizar(); 

                MessageBox.Show("Estoque atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProdutoId_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void dgvEstoque_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEstoque.Rows[e.RowIndex];
                txtEstoqueId.Text = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : string.Empty;
                txtProdutoId.Text = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty;
                txtNome.Text = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
                txtQuantidade.Text = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty;

                if (row.Cells[4].Value != null && DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime data))
                {
                    dateUltimoMovimento.Value = data;
                }
                else
                {
                    dateUltimoMovimento.Value = DateTime.Now;
                }
            }
        }
    }

}
















