namespace EditorTXT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuBar = new MenuStrip();
            mArquivo = new ToolStripMenuItem();
            mArquivoNovo = new ToolStripMenuItem();
            mArquivoNovaJanela = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mArquivoAbrir = new ToolStripMenuItem();
            mArquivoSalvar = new ToolStripMenuItem();
            mArquivoSalvarComo = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mArquivoSair = new ToolStripMenuItem();
            mEditar = new ToolStripMenuItem();
            mEditarDesfazer = new ToolStripMenuItem();
            mEditarRefazer = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mEditarRecortar = new ToolStripMenuItem();
            mEditarCopiar = new ToolStripMenuItem();
            mEditarColar = new ToolStripMenuItem();
            mEditarExcluir = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            mEditarDataHora = new ToolStripMenuItem();
            mFormatar = new ToolStripMenuItem();
            mFormatarQuebraLinha = new ToolStripMenuItem();
            mFormatarFonte = new ToolStripMenuItem();
            mExibir = new ToolStripMenuItem();
            mExibirZoom = new ToolStripMenuItem();
            mExibirZoomAmpliar = new ToolStripMenuItem();
            mExibirZoomReduzir = new ToolStripMenuItem();
            mExibirZoomRestaurar = new ToolStripMenuItem();
            barraDeStatusToolStripMenuItem = new ToolStripMenuItem();
            mAjuda = new ToolStripMenuItem();
            mAjudaExibir = new ToolStripMenuItem();
            mAjudaSobre = new ToolStripMenuItem();
            statusBar = new StatusStrip();
            statusBarLabel = new ToolStripStatusLabel();
            txtConteudo = new RichTextBox();
            menuBar.SuspendLayout();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuBar.Items.AddRange(new ToolStripItem[] { mArquivo, mEditar, mFormatar, mExibir, mAjuda });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(784, 29);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            mArquivo.DropDownItems.AddRange(new ToolStripItem[] { mArquivoNovo, mArquivoNovaJanela, toolStripSeparator1, mArquivoAbrir, mArquivoSalvar, mArquivoSalvarComo, toolStripSeparator2, mArquivoSair });
            mArquivo.Name = "mArquivo";
            mArquivo.Size = new Size(80, 25);
            mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            mArquivoNovo.Image = Properties.Resources.baseline_description_black_24dp;
            mArquivoNovo.Name = "mArquivoNovo";
            mArquivoNovo.ShortcutKeys = Keys.Control | Keys.N;
            mArquivoNovo.Size = new Size(272, 26);
            mArquivoNovo.Text = "Novo";
            mArquivoNovo.Click += mArquivoNovo_Click;
            // 
            // mArquivoNovaJanela
            // 
            mArquivoNovaJanela.Image = Properties.Resources.baseline_note_add_black_24dp;
            mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            mArquivoNovaJanela.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            mArquivoNovaJanela.Size = new Size(272, 26);
            mArquivoNovaJanela.Text = "Nova Janela";
            mArquivoNovaJanela.Click += mArquivoNovaJanela_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(269, 6);
            // 
            // mArquivoAbrir
            // 
            mArquivoAbrir.Image = Properties.Resources.baseline_folder_black_24dp;
            mArquivoAbrir.Name = "mArquivoAbrir";
            mArquivoAbrir.ShortcutKeys = Keys.Control | Keys.O;
            mArquivoAbrir.Size = new Size(272, 26);
            mArquivoAbrir.Text = "Abrir";
            mArquivoAbrir.Click += mArquivoAbrir_Click;
            // 
            // mArquivoSalvar
            // 
            mArquivoSalvar.Image = Properties.Resources.baseline_save_black_24dp;
            mArquivoSalvar.Name = "mArquivoSalvar";
            mArquivoSalvar.ShortcutKeys = Keys.Control | Keys.S;
            mArquivoSalvar.Size = new Size(272, 26);
            mArquivoSalvar.Text = "Salvar";
            mArquivoSalvar.Click += mArquivoSalvar_Click;
            // 
            // mArquivoSalvarComo
            // 
            mArquivoSalvarComo.Image = Properties.Resources.baseline_save_as_black_24dp;
            mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            mArquivoSalvarComo.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            mArquivoSalvarComo.Size = new Size(272, 26);
            mArquivoSalvarComo.Text = "Salvar Como";
            mArquivoSalvarComo.Click += mArquivoSalvarComo_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(269, 6);
            // 
            // mArquivoSair
            // 
            mArquivoSair.Image = Properties.Resources.baseline_logout_black_24dp;
            mArquivoSair.Name = "mArquivoSair";
            mArquivoSair.ShortcutKeys = Keys.Alt | Keys.F4;
            mArquivoSair.Size = new Size(272, 26);
            mArquivoSair.Text = "Sair";
            mArquivoSair.Click += mArquivoSair_Click;
            // 
            // mEditar
            // 
            mEditar.DropDownItems.AddRange(new ToolStripItem[] { mEditarDesfazer, mEditarRefazer, toolStripSeparator3, mEditarRecortar, mEditarCopiar, mEditarColar, mEditarExcluir, toolStripSeparator4, mEditarDataHora });
            mEditar.Name = "mEditar";
            mEditar.Size = new Size(64, 25);
            mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            mEditarDesfazer.Name = "mEditarDesfazer";
            mEditarDesfazer.ShortcutKeys = Keys.Control | Keys.Z;
            mEditarDesfazer.Size = new Size(236, 26);
            mEditarDesfazer.Text = "Desfazer";
            mEditarDesfazer.Click += mEditarDesfazer_Click;
            // 
            // mEditarRefazer
            // 
            mEditarRefazer.Name = "mEditarRefazer";
            mEditarRefazer.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
            mEditarRefazer.Size = new Size(236, 26);
            mEditarRefazer.Text = "Refazer";
            mEditarRefazer.Click += mEditarRefazer_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(233, 6);
            // 
            // mEditarRecortar
            // 
            mEditarRecortar.Image = Properties.Resources.baseline_content_cut_black_24dp;
            mEditarRecortar.Name = "mEditarRecortar";
            mEditarRecortar.ShortcutKeys = Keys.Control | Keys.X;
            mEditarRecortar.Size = new Size(236, 26);
            mEditarRecortar.Text = "Recortar";
            mEditarRecortar.Click += mEditarRecortar_Click;
            // 
            // mEditarCopiar
            // 
            mEditarCopiar.Image = Properties.Resources.baseline_content_copy_black_24dp;
            mEditarCopiar.Name = "mEditarCopiar";
            mEditarCopiar.ShortcutKeys = Keys.Control | Keys.C;
            mEditarCopiar.Size = new Size(236, 26);
            mEditarCopiar.Text = "Copiar";
            mEditarCopiar.Click += mEditarCopiar_Click;
            // 
            // mEditarColar
            // 
            mEditarColar.Image = Properties.Resources.baseline_content_paste_go_black_24dp;
            mEditarColar.Name = "mEditarColar";
            mEditarColar.ShortcutKeys = Keys.Control | Keys.V;
            mEditarColar.Size = new Size(236, 26);
            mEditarColar.Text = "Colar";
            mEditarColar.Click += mEditarColar_Click;
            // 
            // mEditarExcluir
            // 
            mEditarExcluir.Image = Properties.Resources.baseline_clear_black_24dp;
            mEditarExcluir.Name = "mEditarExcluir";
            mEditarExcluir.ShortcutKeys = Keys.Delete;
            mEditarExcluir.Size = new Size(236, 26);
            mEditarExcluir.Text = "Excluir";
            mEditarExcluir.Click += mEditarExcluir_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(233, 6);
            // 
            // mEditarDataHora
            // 
            mEditarDataHora.Image = Properties.Resources.baseline_calendar_today_black_24dp;
            mEditarDataHora.Name = "mEditarDataHora";
            mEditarDataHora.ShortcutKeys = Keys.F5;
            mEditarDataHora.Size = new Size(236, 26);
            mEditarDataHora.Text = "Data e Hora";
            mEditarDataHora.Click += mEditarDataHora_Click;
            // 
            // mFormatar
            // 
            mFormatar.DropDownItems.AddRange(new ToolStripItem[] { mFormatarQuebraLinha, mFormatarFonte });
            mFormatar.Name = "mFormatar";
            mFormatar.Size = new Size(88, 25);
            mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebraLinha
            // 
            mFormatarQuebraLinha.CheckOnClick = true;
            mFormatarQuebraLinha.Name = "mFormatarQuebraLinha";
            mFormatarQuebraLinha.Size = new Size(280, 26);
            mFormatarQuebraLinha.Text = "Quebra automática de linha";
            mFormatarQuebraLinha.Click += mFormatarQuebraLinha_Click;
            // 
            // mFormatarFonte
            // 
            mFormatarFonte.Name = "mFormatarFonte";
            mFormatarFonte.Size = new Size(280, 26);
            mFormatarFonte.Text = "Fonte";
            mFormatarFonte.Click += mFormatarFonte_Click;
            // 
            // mExibir
            // 
            mExibir.DropDownItems.AddRange(new ToolStripItem[] { mExibirZoom, barraDeStatusToolStripMenuItem });
            mExibir.Name = "mExibir";
            mExibir.Size = new Size(62, 25);
            mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            mExibirZoom.DropDownItems.AddRange(new ToolStripItem[] { mExibirZoomAmpliar, mExibirZoomReduzir, mExibirZoomRestaurar });
            mExibirZoom.Name = "mExibirZoom";
            mExibirZoom.Size = new Size(188, 26);
            mExibirZoom.Text = "Zoom";
            // 
            // mExibirZoomAmpliar
            // 
            mExibirZoomAmpliar.Name = "mExibirZoomAmpliar";
            mExibirZoomAmpliar.ShortcutKeys = Keys.Control | Keys.Oemplus;
            mExibirZoomAmpliar.Size = new Size(261, 26);
            mExibirZoomAmpliar.Text = "Ampliar";
            mExibirZoomAmpliar.Click += mExibirZoomAmpliar_Click;
            // 
            // mExibirZoomReduzir
            // 
            mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            mExibirZoomReduzir.ShortcutKeys = Keys.Control | Keys.OemMinus;
            mExibirZoomReduzir.Size = new Size(261, 26);
            mExibirZoomReduzir.Text = "Reduzir";
            mExibirZoomReduzir.Click += mExibirZoomReduzir_Click;
            // 
            // mExibirZoomRestaurar
            // 
            mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            mExibirZoomRestaurar.ShortcutKeys = Keys.Control | Keys.D0;
            mExibirZoomRestaurar.Size = new Size(261, 26);
            mExibirZoomRestaurar.Text = "Restaurar";
            mExibirZoomRestaurar.Click += mExibirZoomRestaurar_Click;
            // 
            // barraDeStatusToolStripMenuItem
            // 
            barraDeStatusToolStripMenuItem.Checked = true;
            barraDeStatusToolStripMenuItem.CheckOnClick = true;
            barraDeStatusToolStripMenuItem.CheckState = CheckState.Checked;
            barraDeStatusToolStripMenuItem.Name = "barraDeStatusToolStripMenuItem";
            barraDeStatusToolStripMenuItem.Size = new Size(188, 26);
            barraDeStatusToolStripMenuItem.Text = "Barra de status";
            barraDeStatusToolStripMenuItem.Click += barraDeStatusToolStripMenuItem_Click;
            // 
            // mAjuda
            // 
            mAjuda.DropDownItems.AddRange(new ToolStripItem[] { mAjudaExibir, mAjudaSobre });
            mAjuda.Name = "mAjuda";
            mAjuda.Size = new Size(64, 25);
            mAjuda.Text = "Ajuda";
            // 
            // mAjudaExibir
            // 
            mAjudaExibir.Image = Properties.Resources.baseline_info_black_24dp;
            mAjudaExibir.Name = "mAjudaExibir";
            mAjudaExibir.ShortcutKeys = Keys.F1;
            mAjudaExibir.Size = new Size(218, 26);
            mAjudaExibir.Text = "Exibir ajuda";
            mAjudaExibir.Click += mAjudaExibir_Click;
            // 
            // mAjudaSobre
            // 
            mAjudaSobre.Name = "mAjudaSobre";
            mAjudaSobre.Size = new Size(218, 26);
            mAjudaSobre.Text = "Sobre o Editor TXT";
            mAjudaSobre.Click += mAjudaSobre_Click;
            // 
            // statusBar
            // 
            statusBar.Items.AddRange(new ToolStripItem[] { statusBarLabel });
            statusBar.Location = new Point(0, 539);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(784, 22);
            statusBar.TabIndex = 1;
            statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            statusBarLabel.Name = "statusBarLabel";
            statusBarLabel.Size = new Size(38, 17);
            statusBarLabel.Text = "100 %";
            // 
            // txtConteudo
            // 
            txtConteudo.Dock = DockStyle.Fill;
            txtConteudo.Location = new Point(0, 29);
            txtConteudo.Name = "txtConteudo";
            txtConteudo.Size = new Size(784, 510);
            txtConteudo.TabIndex = 2;
            txtConteudo.Text = "";
            txtConteudo.WordWrap = false;
            txtConteudo.TextChanged += txtConteudo_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(txtConteudo);
            Controls.Add(statusBar);
            Controls.Add(menuBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuBar;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor TXT";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem mArquivo;
        private ToolStripMenuItem mEditar;
        private ToolStripMenuItem mFormatar;
        private ToolStripMenuItem mExibir;
        private ToolStripMenuItem mAjuda;
        private ToolStripMenuItem mArquivoNovo;
        private ToolStripMenuItem mArquivoNovaJanela;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mArquivoAbrir;
        private ToolStripMenuItem mArquivoSalvarComo;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mArquivoSair;
        private ToolStripMenuItem mEditarDesfazer;
        private ToolStripMenuItem mEditarRefazer;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mEditarRecortar;
        private ToolStripMenuItem mEditarCopiar;
        private ToolStripMenuItem mEditarColar;
        private ToolStripMenuItem mEditarExcluir;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mEditarDataHora;
        private ToolStripMenuItem mFormatarQuebraLinha;
        private ToolStripMenuItem mFormatarFonte;
        private ToolStripMenuItem mExibirZoom;
        private ToolStripMenuItem mExibirZoomAmpliar;
        private ToolStripMenuItem mExibirZoomReduzir;
        private ToolStripMenuItem mExibirZoomRestaurar;
        private ToolStripMenuItem barraDeStatusToolStripMenuItem;
        private ToolStripMenuItem mAjudaExibir;
        private ToolStripMenuItem mAjudaSobre;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusBarLabel;
        private RichTextBox txtConteudo;
        private ToolStripMenuItem mArquivoSalvar;
    }
}