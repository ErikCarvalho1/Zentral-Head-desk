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
    public partial class formPedido : Form
    {
        public formPedido()
        {
            InitializeComponent();
        }

        private void formPedido_Load(object sender, EventArgs e)

        {
            if (Program.UsuarioLogado != null)
            {
               
                txtUsuario.Text = Program.UsuarioLogado.Nome;
                txtUsuario.ReadOnly = true;
            }
            if (Program.CLientelogado != null)
            {

                txtNomeCliente.Text = Program.CLientelogado.Nome;
                txtNomeCliente.ReadOnly = true;

                txtIdCliente.Text = Program.CLientelogado.Id.ToString();
                txtIdCliente.ReadOnly = true;
            }

           
        }

        private void btnInserePedido_Click(object sender, EventArgs e)
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

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {
            if (txtCodBar.Text.Length > 6)
            {
                var produto = Produto.ObterPorCodBar(txtCodBar.Text);
                if (produto.Id == 0)
                {
                    produto = Produto.ObterPorId(int.Parse(txtCodBar.Text));

                }
                txtIdProd.Text = produto.Id.ToString();
                txtDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.ValorUnit.ToString("R$##.00");
                label4.Text = $"R$ {produto.ValorUnit * produto.ClasseDesconto}";
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
                dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBarras;
                dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit;
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade;
                dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto;
                descontos += item.Desconto;
                double totalItem = item.ValorUnit * item.Quantidade - item.Desconto;
                dgvItensPedido.Rows[linha].Cells[6].Value = totalItem;
                subTotal += totalItem; // subtotal = subtotal + totalitem
                linha++;
            }
            txtSubTotalItens.Text = subTotal.ToString();
            txtSubTotal.Text = (subTotal + descontos).ToString();
            txtDescontoItens.Text = descontos.ToString();
            txtTotal.Text = subTotal.ToString();
        }

        private void txtIdPedido_TextChanged(object sender, KeyEventArgs e)
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
                            "O pedido está fechado.\nDeseja Reabrir? ", // texto da mensagem 
                            "Pedido", MessageBoxButtons.YesNo, // botões da mensagem 
                            MessageBoxIcon.Question, //ícone da mensagem
                            MessageBoxDefaultButton.Button2 // define qual botão aparecerá ativo na caixa
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

        private void txtDescontoPedido_TextChanged(object sender, KeyEventArgs e)
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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

            

            
        }

        private void txtIdPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

