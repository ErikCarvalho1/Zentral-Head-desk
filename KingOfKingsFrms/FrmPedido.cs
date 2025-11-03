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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FromPedido_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = $" {Program.UsuarioLogado.Nome}";
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length > 4)
            {
                var cliente = Cliente.ObterPorId(int.Parse(txtIdCliente.Text));
                if (cliente.Id > 0)
                {
                    txtNomeCliente.Text = cliente.Nome;
                }
            }
        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(Program.UsuarioLogado, Cliente.ObterPorId(int.Parse(txtIdCliente.Text)));
            pedido.Inserir();

            if (pedido.Id > 0)
            {
                txtIdPedido.Text = pedido.Id.ToString();
                grbIndentificacao.Enabled = false;
                grbItens.Enabled = true;
            }
        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {
            string codBar = txtCodBar.Text.Trim();

            if (codBar.Length > 0)
            {
                var produto = Produto.ObterPorCodBar(codBar);

                if (produto == null || produto.Id == 0)
                {
                    int id;
                    if (int.TryParse(codBar, out id))
                    {
                        produto = Produto.ObterPorId(id);
                    }
                }

                if (produto != null && produto.Id != 0)
                {
                    txtIdProd.Text = produto.Id.ToString();
                    txtDescricao.Text = produto.Descricao;
                    txtValorUnit.Text = produto.ValorUnit.ToString("R$##.00");
                    label4.Text = $"R$ {(produto.ValorUnit * produto.ClasseDesconto):##.00}";
                    txtQuantidade.Text = "";
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemPedido itemPedido = new(
                int.Parse(txtIdPedido.Text),
                Produto.ObterPorId(int.Parse(txtIdProd.Text)),
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)
            );

            itemPedido.inserir();

            if (itemPedido.Id > 0)
            {
                CarregarItens(int.Parse(txtIdPedido.Text));
            }

            if (string.IsNullOrWhiteSpace(txtQuantidade.Text) || !double.TryParse(txtQuantidade.Text, out double quantidade))
            {
                MessageBox.Show("Informe uma quantidade válida.");
                return;
            }
        }

        private void CarregarItens(int pedidoId)
        {
            var itens = ItemPedido.ObterlistaPorPedidoId(pedidoId);
            dgvItensPedido.Rows.Clear();

            int linha = 0;
            double subTotal = 0;
            double descontos = 0;

            foreach (var item in itens)
            {
                dgvItensPedido.Rows.Add();

                dgvItensPedido.Rows[linha].Cells[0].Value = $"#{(linha + 1).ToString().PadLeft(2, '0')}";
                dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto?.CodBarras ?? "N/A";
                dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto?.Descricao ?? "Sem descrição";
                dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit.ToString("C2");
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade;
                dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto.ToString("C2");

                double totalItem = item.ValorUnit * item.Quantidade - item.Desconto;

                subTotal += totalItem;
                descontos += item.Desconto;
                linha++;
            }

            txtSubTotalItens.Text = subTotal.ToString("C2");
            txtSubTotal.Text = (subTotal + descontos).ToString("C2");
            txtDescontoItens.Text = descontos.ToString("C2");
            txtTotal.Text = subTotal.ToString("C2");
        }

        private void txtIdPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var pedido = Pedido.ObterPorId(int.Parse(txtIdPedido.Text));

                if (pedido.Id > 0)
                {
                    if (pedido.Status == "A")
                    {
                        grbIndentificacao.Enabled = false;
                        txtNomeCliente.Text = $"{pedido.Cliente.Id} - {pedido.Cliente.Nome}";
                        txtUsuario.Text = $"{pedido.Usuario.Id} - {pedido.Usuario.Nome}";
                        grbItens.Enabled = true;
                        CarregarItens(pedido.Id);
                    }
                    else if (pedido.Status == "F")
                    {
                        var resposta = MessageBox.Show(
                            "O pedido está fechado.\nDeseja Reabrir? ",
                            "Pedido",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2
                        );

                        if (resposta == DialogResult.Yes)
                        {
                            pedido.Status = "A";
                            pedido.Atualizar();
                        }
                    }
                }
            }
        }

        private void txtDescontoPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTotal.Text = (double.Parse(txtSubTotalItens.Text) - double.Parse(txtDescontoPedido.Text)).ToString("##.00");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Pedido pedido = Pedido.ObterPorId(int.Parse(txtIdPedido.Text));
            pedido.Desconto = double.Parse(txtDescontoPedido.Text);
            pedido.Status = "F";

            if (pedido.Atualizar())
            {
                MessageBox.Show($"Pedido {pedido.Id} foi Fechado com sucesso.\n");

                dgvItensPedido.Rows.Clear();
                txtIdPedido.Clear();
                txtIdPedido.Focus();
                //.... limpar todos
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvItensPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
