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
                dgvEstoque.Rows[linha].Cells[1].Value = item.NomeProduto;
                dgvEstoque.Rows[linha].Cells[2].Value = item.Quantidade;
                dgvEstoque.Rows[linha].Cells[3].Value = item.DataUltimoMovimento;





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

                // Compara o valor da célula da coluna "Id" com o ID digitado
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
                if (row.IsNewRow) continue; // Pula a linha vazia de inserção

                // Verifica se alguma célula da linha contém o termo buscado
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



        
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEstoque.Rows[e.RowIndex];

                txtEstoqueId.Text = row.Cells[0].Value.ToString();
                txtProdutoId.Text = row.Cells[1].Value.ToString();
                txtQuantidade.Text =row.Cells[2].Value.ToString();
                dateUltimoMovimento.Value = Convert.ToDateTime(row.Cells[3].Value);
            }
        


            //int linha = dgvEstoque.CurrentRow.Index;

            //// Recupera o ID do estoque a partir da coluna oculta (0)
            //int id = Convert.ToInt32(dgvEstoque.Rows[linha].Cells[0].Value);

            //// Busca o objeto Estoque pelo ID
            //var estoque = Estoque.ObterPorId(id);

            //// Preenche os campos com os dados do estoque
            //txtEstoqueId.Text = estoque.Id.ToString();
            //txtProdutoId.Text = estoque.ProdutoId.ToString();
            //txtQuantidade.Text = estoque.Quantidade.ToString();

            //dateUltimoMovimento.Value = estoque.DataUltimoMovimento;

            //// Desabilita os campos, se necessário
            //txtProdutoId.ReadOnly = true;
            //txtQuantidade.Enabled = false;
            //dateUltimoMovimento.Enabled = false;
            //bntEditar.Enabled = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEstoqueId.Text == string.Empty)
            {
                if (txtNome.Text != string.Empty && txtQuantidade.Text != string.Empty && dateUltimoMovimento.Text != string.Empty)
                {
                    Estoque estoque = new(
                    txtNome.Text,
                    double.Parse(txtQuantidade.Text),
                    dateUltimoMovimento.Value);
                    estoque.Inserir();

                    if (estoque.Id > 0)
                    {
                        MessageBox.Show("Estoque Cadastrado");
                    }

                }

            }
            //else
            //{
            //        Estoque estoque = new(
            //        txtNome.Text,
            //        double.Parse(txtQuantidade.Text),
            //        dateUltimoMovimento.Value);
            //        estoque.Atualizar();
            //    MessageBox.Show("Usuário atualizado com sucesso!");




            //}



            //string nome = txtNome.Text.Trim();
            //string txtQtd = txtQuantidade.Text.Trim();

            //if (double.TryParse(txtQtd, out double quantidade) && quantidade > 0)
            //{
            //    DateTime data = dateUltimoMovimento.Value;   // DateTimePicker


            //    var estoque = new Estoque(nome, quantidade, data);

            //    try
            //    {
            //        estoque.Inserir();
            //        MessageBox.Show("Produto inserido com sucesso!");
            //    }
            //    catch (InvalidOperationException ex) // produto não encontrado
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    catch (Exception ex)                // outros erros
            //    {
            //        MessageBox.Show("Erro: " + ex.Message);
            //    }
            // }
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEstoqueId.Text))
            {
                MessageBox.Show("Selecione um lançamento para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação dos dados antes de converter
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

                estoque.Atualizar(); // Método que atualiza no banco

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
    }

}
















