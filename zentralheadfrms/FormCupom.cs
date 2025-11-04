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
    public partial class FormCupom : Form
    {
        public FormCupom()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCupom_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //if (txtId.Text == string.Empty)
            //{
            //    // INSERIR
            //    if (txtTitulo.Text != string.Empty && txtCodigo.Text != string.Empty &&
            //        txtCupomTipo.Text != string.Empty && dateDataInicio.Text != string.Empty &&
            //        dateExpiracao.Text != string.Empty && txtPedidoMinimo.Text != string.Empty &&
            //        txtValorMaximoDesconto.Text != string.Empty && txtPedidoMinimo.Text != string.Empty &&
            //        txtDesconto.Text != string.Empty && txtDescricao.Text != string.Empty &&
            //        cmbTipoDesconto.Text != string.Empty)
                    
            //    {
            //        Cupom CupomSelecionado = (Cupom)cmbTipoDesconto.SelectedItem;

            //        Cupom cupom = new(txtTitulo.Text, txtCodigo.Text, txtCupomTipo.Text, dateDataInicio.Text, dateExpiracao.Text, txtPedidoMinimo.Text, txtValorMaximoDesconto.Text, txtPedidoMinimo.Text, txtDesconto.Text, txtDescricao.Text, cmbTipoDesconto.Text);
            //        Cupom.Inserir();

            //        if (Cupom.Id > 0)
            //        {
            //            MessageBox.Show("Usuário cadastrado com sucesso!");
            //            //btnGravar.Enabled = false;
            //        }
            //    }

            //    CarregaGrid();     // Método que você deve ter para atualizar a grade
            //    LimpaControles();  // Método para limpar os campos
            //}
        }
    }
}
