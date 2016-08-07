using System;

namespace Wallmgr
{
	partial class formHome
	{
		public  System.ComponentModel.IContainer components = null;
		public  System.Windows.Forms.Button btnSelecionar;
		public  System.Windows.Forms.Button btnLimpar;
		public  System.Windows.Forms.Button btnVer;
		public  System.Windows.Forms.Button btnRemover;
		public  System.Windows.Forms.Button btnAdicionar;
		public  System.Windows.Forms.Button btnIniciar;
		public  System.Windows.Forms.Button btnSair;
		public  System.Windows.Forms.Button btnOpcoes;
		public  System.Windows.Forms.Button btnRestaurarDiretorio;
		public  System.Windows.Forms.Button btnFerramentas;
		public  System.Windows.Forms.ColumnHeader clmID;
		public  System.Windows.Forms.ColumnHeader clmArquivo;
		public  System.Windows.Forms.ColumnHeader clmExtensao;
		public  System.Windows.Forms.GroupBox gboxExportacao;
		public  System.Windows.Forms.GroupBox gboxImagens;
		public  System.Windows.Forms.Label lbelPastaDestino;
		public  System.Windows.Forms.ListView lvImagens;
		public  System.Windows.Forms.StatusStrip sstHome;
		public  System.Windows.Forms.TextBox tboxPastaDestino;
		public  System.Windows.Forms.ToolStripStatusLabel tslbArquivo;
		public  System.Windows.Forms.ToolStripStatusLabel tslbTamanho;
		public  System.Windows.Forms.ToolStripStatusLabel tslbResolucao;
		public  System.Windows.Forms.ToolStripStatusLabel tslbSep1;
		public  System.Windows.Forms.ToolStripStatusLabel tslbSep2;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
			this.gboxExportacao = new System.Windows.Forms.GroupBox();
			this.btnRestaurarDiretorio = new System.Windows.Forms.Button();
			this.btnSelecionar = new System.Windows.Forms.Button();
			this.tboxPastaDestino = new System.Windows.Forms.TextBox();
			this.lbelPastaDestino = new System.Windows.Forms.Label();
			this.gboxImagens = new System.Windows.Forms.GroupBox();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnVer = new System.Windows.Forms.Button();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.lvImagens = new System.Windows.Forms.ListView();
			this.clmID = new System.Windows.Forms.ColumnHeader();
			this.clmArquivo = new System.Windows.Forms.ColumnHeader();
			this.clmExtensao = new System.Windows.Forms.ColumnHeader();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.sstHome = new System.Windows.Forms.StatusStrip();
			this.tslbArquivo = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslbSep1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslbTamanho = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslbSep2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslbResolucao = new System.Windows.Forms.ToolStripStatusLabel();
			this.btnOpcoes = new System.Windows.Forms.Button();
			this.btnFerramentas = new System.Windows.Forms.Button();
			this.gboxExportacao.SuspendLayout();
			this.gboxImagens.SuspendLayout();
			this.sstHome.SuspendLayout();
			this.SuspendLayout();
			// 
			// gboxExportacao
			// 
			this.gboxExportacao.Controls.Add(this.btnRestaurarDiretorio);
			this.gboxExportacao.Controls.Add(this.btnSelecionar);
			this.gboxExportacao.Controls.Add(this.tboxPastaDestino);
			this.gboxExportacao.Controls.Add(this.lbelPastaDestino);
			this.gboxExportacao.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gboxExportacao.Location = new System.Drawing.Point(12, 12);
			this.gboxExportacao.Name = "gboxExportacao";
			this.gboxExportacao.Size = new System.Drawing.Size(618, 90);
			this.gboxExportacao.TabIndex = 0;
			this.gboxExportacao.TabStop = false;
			this.gboxExportacao.Text = " Exportação ";
			// 
			// btnRestaurarDiretorio
			// 
			this.btnRestaurarDiretorio.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestaurarDiretorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurarDiretorio.Image")));
			this.btnRestaurarDiretorio.Location = new System.Drawing.Point(537, 39);
			this.btnRestaurarDiretorio.Name = "btnRestaurarDiretorio";
			this.btnRestaurarDiretorio.Size = new System.Drawing.Size(65, 35);
			this.btnRestaurarDiretorio.TabIndex = 3;
			this.btnRestaurarDiretorio.UseVisualStyleBackColor = true;
			this.btnRestaurarDiretorio.Click += new System.EventHandler(this.BtnRestaurarDiretorioClick);
			// 
			// btnSelecionar
			// 
			this.btnSelecionar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionar.Image")));
			this.btnSelecionar.Location = new System.Drawing.Point(466, 39);
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.Size = new System.Drawing.Size(65, 35);
			this.btnSelecionar.TabIndex = 2;
			this.btnSelecionar.UseVisualStyleBackColor = true;
			this.btnSelecionar.Click += new System.EventHandler(this.BtnSelecionarClick);
			// 
			// tboxPastaDestino
			// 
			this.tboxPastaDestino.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tboxPastaDestino.Location = new System.Drawing.Point(15, 49);
			this.tboxPastaDestino.Name = "tboxPastaDestino";
			this.tboxPastaDestino.Size = new System.Drawing.Size(447, 25);
			this.tboxPastaDestino.TabIndex = 1;
			// 
			// lbelPastaDestino
			// 
			this.lbelPastaDestino.Location = new System.Drawing.Point(15, 28);
			this.lbelPastaDestino.Name = "lbelPastaDestino";
			this.lbelPastaDestino.Size = new System.Drawing.Size(100, 18);
			this.lbelPastaDestino.TabIndex = 0;
			this.lbelPastaDestino.Text = "Pasta destino:";
			this.lbelPastaDestino.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// gboxImagens
			// 
			this.gboxImagens.Controls.Add(this.btnLimpar);
			this.gboxImagens.Controls.Add(this.btnVer);
			this.gboxImagens.Controls.Add(this.btnRemover);
			this.gboxImagens.Controls.Add(this.btnAdicionar);
			this.gboxImagens.Controls.Add(this.lvImagens);
			this.gboxImagens.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.gboxImagens.Location = new System.Drawing.Point(12, 108);
			this.gboxImagens.Name = "gboxImagens";
			this.gboxImagens.Size = new System.Drawing.Size(618, 238);
			this.gboxImagens.TabIndex = 1;
			this.gboxImagens.TabStop = false;
			this.gboxImagens.Text = " Imagens ";
			// 
			// btnLimpar
			// 
			this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
			this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpar.Location = new System.Drawing.Point(467, 183);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(135, 40);
			this.btnLimpar.TabIndex = 4;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
			// 
			// btnVer
			// 
			this.btnVer.Enabled = false;
			this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
			this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVer.Location = new System.Drawing.Point(467, 125);
			this.btnVer.Name = "btnVer";
			this.btnVer.Size = new System.Drawing.Size(135, 40);
			this.btnVer.TabIndex = 3;
			this.btnVer.Text = "Ver";
			this.btnVer.UseVisualStyleBackColor = true;
			this.btnVer.Click += new System.EventHandler(this.BtnVerClick);
			// 
			// btnRemover
			// 
			this.btnRemover.Enabled = false;
			this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
			this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemover.Location = new System.Drawing.Point(467, 79);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(135, 40);
			this.btnRemover.TabIndex = 2;
			this.btnRemover.Text = "Remover";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Click += new System.EventHandler(this.BtnRemoverClick);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
			this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdicionar.Location = new System.Drawing.Point(467, 33);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(135, 40);
			this.btnAdicionar.TabIndex = 1;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionarClick);
			// 
			// lvImagens
			// 
			this.lvImagens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.clmID,
			this.clmArquivo,
			this.clmExtensao});
			this.lvImagens.FullRowSelect = true;
			this.lvImagens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvImagens.Location = new System.Drawing.Point(13, 33);
			this.lvImagens.MultiSelect = false;
			this.lvImagens.Name = "lvImagens";
			this.lvImagens.Size = new System.Drawing.Size(448, 190);
			this.lvImagens.TabIndex = 0;
			this.lvImagens.UseCompatibleStateImageBehavior = false;
			this.lvImagens.View = System.Windows.Forms.View.Details;
			this.lvImagens.SelectedIndexChanged += new System.EventHandler(this.LvImagensSelectedIndexChanged);
			// 
			// clmID
			// 
			this.clmID.Text = "ID";
			this.clmID.Width = 49;
			// 
			// clmArquivo
			// 
			this.clmArquivo.Text = "Arquivo";
			this.clmArquivo.Width = 279;
			// 
			// clmExtensao
			// 
			this.clmExtensao.Text = "Extensão";
			this.clmExtensao.Width = 119;
			// 
			// btnIniciar
			// 
			this.btnIniciar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
			this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIniciar.Location = new System.Drawing.Point(480, 352);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(150, 40);
			this.btnIniciar.TabIndex = 5;
			this.btnIniciar.Text = "Iniciar";
			this.btnIniciar.UseVisualStyleBackColor = true;
			this.btnIniciar.Click += new System.EventHandler(this.BtnIniciarClick);
			// 
			// btnSair
			// 
			this.btnSair.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
			this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSair.Location = new System.Drawing.Point(12, 352);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(150, 40);
			this.btnSair.TabIndex = 7;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// sstHome
			// 
			this.sstHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tslbArquivo,
			this.tslbSep1,
			this.tslbTamanho,
			this.tslbSep2,
			this.tslbResolucao});
			this.sstHome.Location = new System.Drawing.Point(0, 400);
			this.sstHome.Name = "sstHome";
			this.sstHome.Size = new System.Drawing.Size(642, 22);
			this.sstHome.TabIndex = 8;
			this.sstHome.Text = "statusStrip1";
			// 
			// tslbArquivo
			// 
			this.tslbArquivo.Name = "tslbArquivo";
			this.tslbArquivo.Size = new System.Drawing.Size(0, 17);
			// 
			// tslbSep1
			// 
			this.tslbSep1.Name = "tslbSep1";
			this.tslbSep1.Size = new System.Drawing.Size(0, 17);
			// 
			// tslbTamanho
			// 
			this.tslbTamanho.Name = "tslbTamanho";
			this.tslbTamanho.Size = new System.Drawing.Size(0, 17);
			// 
			// tslbSep2
			// 
			this.tslbSep2.Name = "tslbSep2";
			this.tslbSep2.Size = new System.Drawing.Size(0, 17);
			// 
			// tslbResolucao
			// 
			this.tslbResolucao.Name = "tslbResolucao";
			this.tslbResolucao.Size = new System.Drawing.Size(0, 17);
			// 
			// btnOpcoes
			// 
			this.btnOpcoes.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpcoes.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcoes.Image")));
			this.btnOpcoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOpcoes.Location = new System.Drawing.Point(168, 352);
			this.btnOpcoes.Name = "btnOpcoes";
			this.btnOpcoes.Size = new System.Drawing.Size(150, 40);
			this.btnOpcoes.TabIndex = 9;
			this.btnOpcoes.Text = "Opções";
			this.btnOpcoes.UseVisualStyleBackColor = true;
			this.btnOpcoes.Click += new System.EventHandler(this.BtnOpcoesClick);
			// 
			// btnFerramentas
			// 
			this.btnFerramentas.Enabled = false;
			this.btnFerramentas.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFerramentas.Image = ((System.Drawing.Image)(resources.GetObject("btnFerramentas.Image")));
			this.btnFerramentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFerramentas.Location = new System.Drawing.Point(324, 352);
			this.btnFerramentas.Name = "btnFerramentas";
			this.btnFerramentas.Size = new System.Drawing.Size(150, 40);
			this.btnFerramentas.TabIndex = 10;
			this.btnFerramentas.Text = "Ferramentas";
			this.btnFerramentas.UseVisualStyleBackColor = true;
			// 
			// formHome
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(642, 422);
			this.Controls.Add(this.btnFerramentas);
			this.Controls.Add(this.btnOpcoes);
			this.Controls.Add(this.sstHome);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnIniciar);
			this.Controls.Add(this.gboxImagens);
			this.Controls.Add(this.gboxExportacao);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "formHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wallmgr - Gerenciador e categorizadore de imagens";
			this.Load += new System.EventHandler(this.FormHomeLoad);
			this.gboxExportacao.ResumeLayout(false);
			this.gboxExportacao.PerformLayout();
			this.gboxImagens.ResumeLayout(false);
			this.sstHome.ResumeLayout(false);
			this.sstHome.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
