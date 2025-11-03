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
    public partial class FormListarProduto : Form
    {
        public FormListarProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProdutos_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormListarProduto_Load(object sender, EventArgs e)
        {
            var lista = Produto.ObterLista();
            int linha = 0;
            dgvProduto.Rows.Clear();
            foreach (var item in lista)
            {
                dgvProduto.Rows.Add();
                dgvProduto.Rows[linha].Cells[0].Value = item.Id;
                dgvProduto.Rows[linha].Cells[1].Value = item.Descricao;
                dgvProduto.Rows[linha].Cells[2].Value = item.CodBarras;
                dgvProduto.Rows[linha].Cells[3].Value = item.ValorUnit;
                linha++;
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string termo = txtProdutos.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(termo))
            {
                foreach (DataGridViewRow row in dgvProduto.Rows)
                {
                    row.Visible = true;
                }

            }
            else
            {
                foreach (DataGridViewRow row in dgvProduto.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (string.IsNullOrWhiteSpace(termo))
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = row.Cells["column2"].Value != null &&
                            
                            row.Cells["column2"].Value.ToString().ToLower().Contains(termo);

                           
                            row.Visible = row.Cells["column3"].Value != null &&

                           row.Cells["column3"].Value.ToString().ToLower().Contains(termo);
                        }
                    }
                }
            }
        }
    }
}
            
        
    



