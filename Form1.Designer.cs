﻿namespace EditorTXT
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovaJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarRefazer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarDataHora = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarQuebraLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomAmpliar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomReduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo,
            this.mEditar,
            this.mFormatar,
            this.mExibir,
            this.mAjuda});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(784, 29);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivoNovo,
            this.mArquivoNovaJanela,
            this.toolStripSeparator1,
            this.mArquivoAbrir,
            this.mArquivoSalvar,
            this.mArquivoSalvarComo,
            this.toolStripSeparator2,
            this.mArquivoSair});
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(80, 25);
            this.mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            this.mArquivoNovo.Name = "mArquivoNovo";
            this.mArquivoNovo.Size = new System.Drawing.Size(171, 26);
            this.mArquivoNovo.Text = "Novo";
            this.mArquivoNovo.Click += new System.EventHandler(this.mArquivoNovo_Click);
            // 
            // mArquivoNovaJanela
            // 
            this.mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            this.mArquivoNovaJanela.Size = new System.Drawing.Size(171, 26);
            this.mArquivoNovaJanela.Text = "Nova Janela";
            this.mArquivoNovaJanela.Click += new System.EventHandler(this.mArquivoNovaJanela_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // mArquivoAbrir
            // 
            this.mArquivoAbrir.Name = "mArquivoAbrir";
            this.mArquivoAbrir.Size = new System.Drawing.Size(171, 26);
            this.mArquivoAbrir.Text = "Abrir";
            this.mArquivoAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // mArquivoSalvar
            // 
            this.mArquivoSalvar.Name = "mArquivoSalvar";
            this.mArquivoSalvar.Size = new System.Drawing.Size(171, 26);
            this.mArquivoSalvar.Text = "Salvar";
            this.mArquivoSalvar.Click += new System.EventHandler(this.mArquivoSalvar_Click);
            // 
            // mArquivoSalvarComo
            // 
            this.mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            this.mArquivoSalvarComo.Size = new System.Drawing.Size(171, 26);
            this.mArquivoSalvarComo.Text = "Salvar Como";
            this.mArquivoSalvarComo.Click += new System.EventHandler(this.mArquivoSalvarComo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // mArquivoSair
            // 
            this.mArquivoSair.Name = "mArquivoSair";
            this.mArquivoSair.Size = new System.Drawing.Size(171, 26);
            this.mArquivoSair.Text = "Sair";
            this.mArquivoSair.Click += new System.EventHandler(this.mArquivoSair_Click);
            // 
            // mEditar
            // 
            this.mEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditarDesfazer,
            this.mEditarRefazer,
            this.toolStripSeparator3,
            this.mEditarRecortar,
            this.mEditarCopiar,
            this.mEditarColar,
            this.mEditarExcluir,
            this.toolStripSeparator4,
            this.mEditarDataHora});
            this.mEditar.Name = "mEditar";
            this.mEditar.Size = new System.Drawing.Size(64, 25);
            this.mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            this.mEditarDesfazer.Name = "mEditarDesfazer";
            this.mEditarDesfazer.Size = new System.Drawing.Size(166, 26);
            this.mEditarDesfazer.Text = "Desfazer";
            this.mEditarDesfazer.Click += new System.EventHandler(this.mEditarDesfazer_Click);
            // 
            // mEditarRefazer
            // 
            this.mEditarRefazer.Name = "mEditarRefazer";
            this.mEditarRefazer.Size = new System.Drawing.Size(166, 26);
            this.mEditarRefazer.Text = "Refazer";
            this.mEditarRefazer.Click += new System.EventHandler(this.mEditarRefazer_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // mEditarRecortar
            // 
            this.mEditarRecortar.Name = "mEditarRecortar";
            this.mEditarRecortar.Size = new System.Drawing.Size(166, 26);
            this.mEditarRecortar.Text = "Recortar";
            this.mEditarRecortar.Click += new System.EventHandler(this.mEditarRecortar_Click);
            // 
            // mEditarCopiar
            // 
            this.mEditarCopiar.Name = "mEditarCopiar";
            this.mEditarCopiar.Size = new System.Drawing.Size(166, 26);
            this.mEditarCopiar.Text = "Copiar";
            this.mEditarCopiar.Click += new System.EventHandler(this.mEditarCopiar_Click);
            // 
            // mEditarColar
            // 
            this.mEditarColar.Name = "mEditarColar";
            this.mEditarColar.Size = new System.Drawing.Size(166, 26);
            this.mEditarColar.Text = "Colar";
            this.mEditarColar.Click += new System.EventHandler(this.mEditarColar_Click);
            // 
            // mEditarExcluir
            // 
            this.mEditarExcluir.Name = "mEditarExcluir";
            this.mEditarExcluir.Size = new System.Drawing.Size(166, 26);
            this.mEditarExcluir.Text = "Excluir";
            this.mEditarExcluir.Click += new System.EventHandler(this.mEditarExcluir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(163, 6);
            // 
            // mEditarDataHora
            // 
            this.mEditarDataHora.Name = "mEditarDataHora";
            this.mEditarDataHora.Size = new System.Drawing.Size(166, 26);
            this.mEditarDataHora.Text = "Data e Hora";
            this.mEditarDataHora.Click += new System.EventHandler(this.mEditarDataHora_Click);
            // 
            // mFormatar
            // 
            this.mFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatarQuebraLinha,
            this.mFormatarFonte});
            this.mFormatar.Name = "mFormatar";
            this.mFormatar.Size = new System.Drawing.Size(88, 25);
            this.mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebraLinha
            // 
            this.mFormatarQuebraLinha.CheckOnClick = true;
            this.mFormatarQuebraLinha.Name = "mFormatarQuebraLinha";
            this.mFormatarQuebraLinha.Size = new System.Drawing.Size(280, 26);
            this.mFormatarQuebraLinha.Text = "Quebra automática de linha";
            this.mFormatarQuebraLinha.Click += new System.EventHandler(this.mFormatarQuebraLinha_Click);
            // 
            // mFormatarFonte
            // 
            this.mFormatarFonte.Name = "mFormatarFonte";
            this.mFormatarFonte.Size = new System.Drawing.Size(280, 26);
            this.mFormatarFonte.Text = "Fonte";
            this.mFormatarFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // mExibir
            // 
            this.mExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoom,
            this.barraDeStatusToolStripMenuItem});
            this.mExibir.Name = "mExibir";
            this.mExibir.Size = new System.Drawing.Size(62, 25);
            this.mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            this.mExibirZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoomAmpliar,
            this.mExibirZoomReduzir,
            this.mExibirZoomRestaurar});
            this.mExibirZoom.Name = "mExibirZoom";
            this.mExibirZoom.Size = new System.Drawing.Size(188, 26);
            this.mExibirZoom.Text = "Zoom";
            // 
            // mExibirZoomAmpliar
            // 
            this.mExibirZoomAmpliar.Name = "mExibirZoomAmpliar";
            this.mExibirZoomAmpliar.Size = new System.Drawing.Size(180, 26);
            this.mExibirZoomAmpliar.Text = "Ampliar";
            this.mExibirZoomAmpliar.Click += new System.EventHandler(this.mExibirZoomAmpliar_Click);
            // 
            // mExibirZoomReduzir
            // 
            this.mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            this.mExibirZoomReduzir.Size = new System.Drawing.Size(180, 26);
            this.mExibirZoomReduzir.Text = "Reduzir";
            this.mExibirZoomReduzir.Click += new System.EventHandler(this.mExibirZoomReduzir_Click);
            // 
            // mExibirZoomRestaurar
            // 
            this.mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            this.mExibirZoomRestaurar.Size = new System.Drawing.Size(180, 26);
            this.mExibirZoomRestaurar.Text = "Restaurar";
            this.mExibirZoomRestaurar.Click += new System.EventHandler(this.mExibirZoomRestaurar_Click);
            // 
            // barraDeStatusToolStripMenuItem
            // 
            this.barraDeStatusToolStripMenuItem.Checked = true;
            this.barraDeStatusToolStripMenuItem.CheckOnClick = true;
            this.barraDeStatusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barraDeStatusToolStripMenuItem.Name = "barraDeStatusToolStripMenuItem";
            this.barraDeStatusToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.barraDeStatusToolStripMenuItem.Text = "Barra de status";
            this.barraDeStatusToolStripMenuItem.Click += new System.EventHandler(this.barraDeStatusToolStripMenuItem_Click);
            // 
            // mAjuda
            // 
            this.mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjudaExibir,
            this.mAjudaSobre});
            this.mAjuda.Name = "mAjuda";
            this.mAjuda.Size = new System.Drawing.Size(64, 25);
            this.mAjuda.Text = "Ajuda";
            // 
            // mAjudaExibir
            // 
            this.mAjudaExibir.Name = "mAjudaExibir";
            this.mAjudaExibir.Size = new System.Drawing.Size(218, 26);
            this.mAjudaExibir.Text = "Exibir ajuda";
            // 
            // mAjudaSobre
            // 
            this.mAjudaSobre.Name = "mAjudaSobre";
            this.mAjudaSobre.Size = new System.Drawing.Size(218, 26);
            this.mAjudaSobre.Text = "Sobre o Editor TXT";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 539);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(784, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(38, 17);
            this.statusBarLabel.Text = "100 %";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConteudo.Location = new System.Drawing.Point(0, 29);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(784, 510);
            this.txtConteudo.TabIndex = 2;
            this.txtConteudo.Text = "";
            this.txtConteudo.WordWrap = false;
            this.txtConteudo.TextChanged += new System.EventHandler(this.txtConteudo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor TXT";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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