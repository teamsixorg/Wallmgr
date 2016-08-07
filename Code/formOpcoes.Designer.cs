/*
 * Criado por SharpDevelop.
 * Usuário: Daniel
 * Data: 06/08/2016
 * Hora: 17:54
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Wallmgr
{
	partial class formOpcoes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gboxExportacao;
		private System.Windows.Forms.TextBox tboxDestinoExportacao;
		private System.Windows.Forms.Label lbelDestinoExportacao;
		private System.Windows.Forms.Button btnSelecionarDestinoExportacao;
		private System.Windows.Forms.Button btnSalvar;
		public System.Windows.Forms.Button btnVoltar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOpcoes));
			this.gboxExportacao = new System.Windows.Forms.GroupBox();
			this.btnSelecionarDestinoExportacao = new System.Windows.Forms.Button();
			this.tboxDestinoExportacao = new System.Windows.Forms.TextBox();
			this.lbelDestinoExportacao = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.gboxExportacao.SuspendLayout();
			this.SuspendLayout();
			// 
			// gboxExportacao
			// 
			this.gboxExportacao.Controls.Add(this.btnSelecionarDestinoExportacao);
			this.gboxExportacao.Controls.Add(this.tboxDestinoExportacao);
			this.gboxExportacao.Controls.Add(this.lbelDestinoExportacao);
			this.gboxExportacao.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.gboxExportacao.Location = new System.Drawing.Point(12, 12);
			this.gboxExportacao.Name = "gboxExportacao";
			this.gboxExportacao.Size = new System.Drawing.Size(471, 99);
			this.gboxExportacao.TabIndex = 0;
			this.gboxExportacao.TabStop = false;
			this.gboxExportacao.Text = " Exportação ";
			// 
			// btnSelecionarDestinoExportacao
			// 
			this.btnSelecionarDestinoExportacao.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarDestinoExportacao.Image")));
			this.btnSelecionarDestinoExportacao.Location = new System.Drawing.Point(391, 44);
			this.btnSelecionarDestinoExportacao.Name = "btnSelecionarDestinoExportacao";
			this.btnSelecionarDestinoExportacao.Size = new System.Drawing.Size(65, 35);
			this.btnSelecionarDestinoExportacao.TabIndex = 2;
			this.btnSelecionarDestinoExportacao.UseVisualStyleBackColor = true;
			this.btnSelecionarDestinoExportacao.Click += new System.EventHandler(this.BtnAlterarDestinoExportacaoClick);
			// 
			// tboxDestinoExportacao
			// 
			this.tboxDestinoExportacao.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
			this.tboxDestinoExportacao.Location = new System.Drawing.Point(15, 54);
			this.tboxDestinoExportacao.Name = "tboxDestinoExportacao";
			this.tboxDestinoExportacao.ReadOnly = true;
			this.tboxDestinoExportacao.Size = new System.Drawing.Size(370, 25);
			this.tboxDestinoExportacao.TabIndex = 1;
			// 
			// lbelDestinoExportacao
			// 
			this.lbelDestinoExportacao.Location = new System.Drawing.Point(15, 28);
			this.lbelDestinoExportacao.Name = "lbelDestinoExportacao";
			this.lbelDestinoExportacao.Size = new System.Drawing.Size(191, 23);
			this.lbelDestinoExportacao.TabIndex = 0;
			this.lbelDestinoExportacao.Text = "Destino de exportação padrão:";
			this.lbelDestinoExportacao.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSalvar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalvar.Location = new System.Drawing.Point(333, 122);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(150, 40);
			this.btnSalvar.TabIndex = 6;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarClick);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
			this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVoltar.Location = new System.Drawing.Point(177, 122);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(150, 40);
			this.btnVoltar.TabIndex = 8;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.BtnVoltarClick);
			// 
			// formOpcoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 175);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.gboxExportacao);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "formOpcoes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wallmgr - Opções";
			this.Load += new System.EventHandler(this.FormOpcoesLoad);
			this.gboxExportacao.ResumeLayout(false);
			this.gboxExportacao.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
