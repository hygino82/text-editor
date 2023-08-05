using System.IO;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

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
            mArquivoSalvar.Enabled = true;
            this.Text = Application.ProductName;
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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Abrir";
            dialog.Filter = "rich text file|*.rtf|texto|*.txt|todos|*.*";

            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                if (File.Exists(dialog.FileName))
                {
                    FileInfo file = new FileInfo(dialog.FileName);
                    this.Text = Application.ProductName + " - " + file.Name;

                    Gerenciador.FolderPath = file.DirectoryName + "\\";
                    Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                    Gerenciador.FileExt = file.Extension;

                    StreamReader stream = null;

                    try
                    {
                        stream = new StreamReader(file.FullName, true);
                        txtConteudo.Text = stream.ReadToEnd();
                        mArquivoSalvar.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Formato de arquivo n�o suportado.\n" + ex.Message);
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
            }
        }

        private void mArquivoSalvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.FilePath))
            {
                SalvarArquivo(Gerenciador.FilePath);
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Salvar...";
                dialog.Filter = "rich text file|*.rtf|texto|*.txt|todos|*.*";
                dialog.CheckFileExists = false;
                dialog.CheckPathExists = true;

                var result = dialog.ShowDialog();

                if (result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    SalvarArquivo(dialog.FileName);
                }
            }
        }

        private void mArquivoSalvarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Salvar como...";
            dialog.Filter = "rich text file|*.rtf|texto|*.txt|todos|*.*";
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;

            var result = dialog.ShowDialog();

            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                SalvarArquivo(dialog.FileName);
            }
        }

        private void SalvarArquivo(string path)
        {
            //Objeto respons�vel por escrever o arquivo
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(path, false);
                writer.Write(txtConteudo.Text);

                FileInfo file = new FileInfo(path);
                Gerenciador.FolderPath = file.DirectoryName + "\\";
                Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                Gerenciador.FileExt = file.Extension;

                this.Text = Application.ProductName + " - " + file.Name;
                mArquivoSalvar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar o arquivo:\n" + ex.Message);
            }
            finally
            {
                writer.Close();
            }
        }

        private void mArquivoSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {
            mArquivoSalvar.Enabled = true;
        }
        #endregion

        #region Menu Editar

        private void mEditarDesfazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Undo();
        }

        private void mEditarRefazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Redo();
        }

        private void mEditarRecortar_Click(object sender, EventArgs e)
        {
            txtConteudo.Cut();
        }

        private void mEditarCopiar_Click(object sender, EventArgs e)
        {
            txtConteudo.Copy();
        }

        private void mEditarColar_Click(object sender, EventArgs e)
        {
            txtConteudo.Paste();
        }

        private void mEditarExcluir_Click(object sender, EventArgs e)
        {
            txtConteudo.Text = txtConteudo.Text.Remove(txtConteudo.SelectionStart, txtConteudo.SelectedText.Length);
        }

        private void mEditarDataHora_Click(object sender, EventArgs e)
        {
            int index = txtConteudo.SelectionStart;
            string dataHora = DateTime.Now.ToString();

            if (txtConteudo.SelectionStart == txtConteudo.Text.Length)
            {
                txtConteudo.Text += dataHora;
                txtConteudo.SelectionStart = index + dataHora.Length;
                return;
            }

            string temp = "";

            for (int i = 0; i < txtConteudo.Text.Length; i++)
            {
                if (i == txtConteudo.SelectionStart)
                {
                    temp += dataHora;
                    temp += txtConteudo.Text[i];

                }
                else
                {
                    temp += txtConteudo.Text[i];
                }
            }
            txtConteudo.Text = temp;
            txtConteudo.SelectionStart = index + dataHora.Length;
        }
        #endregion

        #region Menu Formatar
        private void mFormatarQuebraLinha_Click(object sender, EventArgs e)
        {
            txtConteudo.WordWrap = mFormatarQuebraLinha.Checked;
        }

        private void mFormatarFonte_Click(object sender, EventArgs e)
        {
            FontDialog fonte = new FontDialog();
            fonte.ShowColor = true;
            fonte.ShowEffects = true;

            fonte.Font = txtConteudo.Font;
            fonte.Color = txtConteudo.ForeColor;

            DialogResult result = fonte.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtConteudo.Font = fonte.Font;
                txtConteudo.ForeColor = fonte.Color;
            }
        }
        #endregion
    }
}