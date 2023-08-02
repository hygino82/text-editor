namespace EditorTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Menu Arquivo
        private void mArquivoNovo_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
        }

        private void mArquivoNovaJanela_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            //form.Show();

            Thread t = new Thread(() => Application.Run(new Form1()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void mArquivoAbrir_Click(object sender, EventArgs e)
        {

        }

        private void mArquivoSalvar_Click(object sender, EventArgs e)
        {

        }

        private void mArquivoSalvarComo_Click(object sender, EventArgs e)
        {

        }

        private void mArquivoSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
    }
}