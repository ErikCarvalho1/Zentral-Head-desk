
using KingoOfKingsClass;
using KingOfKingsclass;
namespace KingOfKingsFrms
    

{
    public partial class FormPrincipal : Form
    {
        public void FormClose() // método para fechar o form ativo
        {
            if (frmaAtivo != null)
            {
                frmaAtivo.Close();
            }
        }
        public Form frmaAtivo;// guarda o form atual no painel
        public FormPrincipal()
        {
            InitializeComponent();
        }
        public void FormPainel(Form frm) // método para abrir o form no painel
        {
            FormClose();
            frmaAtivo = frm;
            frm.TopLevel = false;
            pnlPrincipal.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();

        }

        private void bntHistorico_Click(object sender, EventArgs e)
        {

        }

        private void bntCadastrar_Click(object sender, EventArgs e) // método para abrir o form de cadastro 
        {
            FormPainel(new FormCadastrarUsuario());
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bntUsuarios_Click(object sender, EventArgs e) // método para abrir o form de usuários
        {
            FormPainel(new FormCadastrarUsuario());
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            var registro = new ResgistroDeAcesso();
            // registro.RegistrarSaida();
            Application.Exit();

        }

        private void eddeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeUsuariosEVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPainel(new FormCadastrarUsuario());
        }

        private void cadastroDeCupomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPainel(new FormCupom());
        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPainel(new FormClientes());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPainel(new FormCadastroCategoria());
        }

        private void listarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPainel(new FormListarProduto());
        }

        private void cadastroDeProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPainel(new FrmProduto());
        }

        private void lIstarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPainel(new FormEstoque());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormPainel(new formPedido());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormPainel(new FormEstoque());
        }
    }
}
