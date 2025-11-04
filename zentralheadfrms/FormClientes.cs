using ComercialTDSClass;
using KingOfKingsClass;
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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            mxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Cliente cliente = new(
                    txtNome.Text,
                    mxtCpf.Text,
                    mxtTelefone.Text,
                    txtEmail.Text,
                    dtpDataNasc.Value
                );
            cliente.Inserir();

            if (cliente.Id > 0)
            {
                txtClienteId.Text = cliente.Id.ToString();
                MessageBox.Show($"Cliente {cliente.GetHashCode()} cadastrado com sucesso");
            }
        }

        private void btninserir_Click(object sender, EventArgs e)
        {

            string tipoEnd = cmbTipoEndereco.SelectedItem.ToString();
            tipoEnd = tipoEnd.Substring(0, 3);
            mxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Endereco endereco = new(
                    int.Parse(txtClienteId.Text),
                    mxtCep.Text,
                    txtLogradouro.Text,
                    txtNumero.Text,
                    txtComplemento.Text,
                    txtBairro.Text,
                    txtCidade.Text,
                    txtUf.Text,
                    tipoEnd
                );

            endereco.Inserir();
            CarregaGrid(int.Parse(txtClienteId.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mxtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mxtCep_Leave(object sender, EventArgs e)
        {
            mxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mxtCep.Text.Length == 8)
            {
                WebCEP webCEP = new(mxtCep.Text);
                txtLogradouro.Text = webCEP.TipoLagradouro + " " + webCEP.Lagradouro;
                txtBairro.Text = webCEP.Bairro;
                txtCidade.Text = webCEP.Cidade;
                txtUf.Text = webCEP.UF;
                txtNumero.Focus();

            }
        }
        private void CarregaGrid(int clienteId)
        {
            var listaEnderecos = Endereco.ObterListaPorClienteId(clienteId);
            int count = 0;
            // Preenche o DataGridView com todos os endereços
            dgvEnderecos.Rows.Clear();
            foreach (var endereco in listaEnderecos)
            {
                int rowIndex = dgvEnderecos.Rows.Add();
                dgvEnderecos.Rows[count].Cells[0].Value = endereco.Cep;
                dgvEnderecos.Rows[count].Cells[1].Value = endereco.Logradouro;
                dgvEnderecos.Rows[count].Cells[2].Value = endereco.Numero;
                dgvEnderecos.Rows[count].Cells[3].Value = endereco.Complemento;
                dgvEnderecos.Rows[count].Cells[4].Value = endereco.Bairro;
                dgvEnderecos.Rows[count].Cells[5].Value = endereco.Cidade;
                dgvEnderecos.Rows[count].Cells[6].Value = endereco.Uf;
                dgvEnderecos.Rows[count].Cells[7].Value = endereco.TipoEndereco;
                count++;
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {

        }



        private void dgvEnderecos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClienteId.Text))
            {
                MessageBox.Show("Selecione um cliente para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                mxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                Cliente cliente = new Cliente(
                    int.Parse(txtClienteId.Text),
                    txtNome.Text,
                    mxtCpf.Text,
                    mxtTelefone.Text,
                    txtEmail.Text,
                    dtpDataNasc.Value
                );

                cliente.Atualizar(); // Supondo que esse método atualize o cliente no banco

                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            mxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mxtCpf.Text;

            var cliente = Cliente.ObterPorCpf(cpf);
            if (cliente != null)
            {
                txtClienteId.Text = cliente.Id.ToString();
                txtNome.Text = cliente.Nome;
                mxtTelefone.Text = cliente.Telefone;
                txtEmail.Text = cliente.Email;
                dtpDataNasc.Value = cliente.DataNascimento;

                // Carregar endereços no grid
               
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
