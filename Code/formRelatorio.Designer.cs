/*
 * Criado por SharpDevelop.
 * Usuário: Daniel
 * Data: 01/08/2016
 * Hora: 23:00
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Wallmgr
{
	partial class formRelatorio
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.Button btnVoltar;
		public System.Windows.Forms.Button btnExportar;
		public System.Windows.Forms.ListView lvRelatorio;
		private System.Windows.Forms.ColumnHeader clmID;
		private System.Windows.Forms.ColumnHeader clmEstado;
		private System.Windows.Forms.ColumnHeader clmArquivo;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelatorio));
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnExportar = new System.Windows.Forms.Button();
			this.lvRelatorio = new System.Windows.Forms.ListView();
			this.clmID = new System.Windows.Forms.ColumnHeader();
			this.clmEstado = new System.Windows.Forms.ColumnHeader();
			this.clmArquivo = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// btnVoltar
			// 
			this.btnVoltar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
			this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVoltar.Location = new System.Drawing.Point(556, 382);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(150, 40);
			this.btnVoltar.TabIndex = 9;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.BtnVoltarClick);
			// 
			// btnExportar
			// 
			this.btnExportar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
			this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExportar.Location = new System.Drawing.Point(712, 382);
			this.btnExportar.Name = "btnExportar";
			this.btnExportar.Size = new System.Drawing.Size(150, 40);
			this.btnExportar.TabIndex = 11;
			this.btnExportar.Text = "Exportar";
			this.btnExportar.UseVisualStyleBackColor = true;
			this.btnExportar.Click += new System.EventHandler(this.BtnExportarClick);
			// 
			// lvRelatorio
			// 
			this.lvRelatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.clmID,
			this.clmEstado,
			this.clmArquivo});
			this.lvRelatorio.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvRelatorio.FullRowSelect = true;
			this.lvRelatorio.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvRelatorio.Location = new System.Drawing.Point(12, 12);
			this.lvRelatorio.Name = "lvRelatorio";
			this.lvRelatorio.Size = new System.Drawing.Size(850, 364);
			this.lvRelatorio.TabIndex = 12;
			this.lvRelatorio.UseCompatibleStateImageBehavior = false;
			this.lvRelatorio.View = System.Windows.Forms.View.Details;
			// 
			// clmID
			// 
			this.clmID.Text = "ID";
			this.clmID.Width = 50;
			// 
			// clmEstado
			// 
			this.clmEstado.Text = "Estado";
			this.clmEstado.Width = 500;
			// 
			// clmArquivo
			// 
			this.clmArquivo.Text = "Arquivo";
			this.clmArquivo.Width = 300;
			// 
			// formRelatorio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(876, 434);
			this.Controls.Add(this.lvRelatorio);
			this.Controls.Add(this.btnExportar);
			this.Controls.Add(this.btnVoltar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "formRelatorio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wallmgr - Relatório da execução";
			this.Load += new System.EventHandler(this.FormRelatorioLoad);
			this.ResumeLayout(false);

		}
	}
}
