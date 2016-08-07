/*
 * Criado por SharpDevelop.
 * Usuário: Daniel
 * Data: 01/08/2016
 * Hora: 18:58
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Wallmgr
{
	partial class formResultado
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pboxMovidos;
		private System.Windows.Forms.Label lbelArquviosMovidos;
		private System.Windows.Forms.PictureBox pboxErros;
		private System.Windows.Forms.Label lbelErros;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.GroupBox gboxResultado;
		private System.Windows.Forms.Button btnRelatorio;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formResultado));
			this.pboxMovidos = new System.Windows.Forms.PictureBox();
			this.lbelArquviosMovidos = new System.Windows.Forms.Label();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.gboxResultado = new System.Windows.Forms.GroupBox();
			this.lbelErros = new System.Windows.Forms.Label();
			this.pboxErros = new System.Windows.Forms.PictureBox();
			this.btnRelatorio = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pboxMovidos)).BeginInit();
			this.gboxResultado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pboxErros)).BeginInit();
			this.SuspendLayout();
			// 
			// pboxMovidos
			// 
			this.pboxMovidos.Image = ((System.Drawing.Image)(resources.GetObject("pboxMovidos.Image")));
			this.pboxMovidos.Location = new System.Drawing.Point(17, 32);
			this.pboxMovidos.Name = "pboxMovidos";
			this.pboxMovidos.Size = new System.Drawing.Size(50, 50);
			this.pboxMovidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pboxMovidos.TabIndex = 0;
			this.pboxMovidos.TabStop = false;
			// 
			// lbelArquviosMovidos
			// 
			this.lbelArquviosMovidos.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.lbelArquviosMovidos.Location = new System.Drawing.Point(73, 32);
			this.lbelArquviosMovidos.Name = "lbelArquviosMovidos";
			this.lbelArquviosMovidos.Size = new System.Drawing.Size(314, 23);
			this.lbelArquviosMovidos.TabIndex = 1;
			this.lbelArquviosMovidos.Text = "Arquivos movidos: X";
			this.lbelArquviosMovidos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnVoltar
			// 
			this.btnVoltar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
			this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVoltar.Location = new System.Drawing.Point(122, 176);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(150, 40);
			this.btnVoltar.TabIndex = 6;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.BtnVoltarClick);
			// 
			// gboxResultado
			// 
			this.gboxResultado.Controls.Add(this.lbelErros);
			this.gboxResultado.Controls.Add(this.pboxErros);
			this.gboxResultado.Controls.Add(this.pboxMovidos);
			this.gboxResultado.Controls.Add(this.lbelArquviosMovidos);
			this.gboxResultado.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.gboxResultado.Location = new System.Drawing.Point(12, 12);
			this.gboxResultado.Name = "gboxResultado";
			this.gboxResultado.Size = new System.Drawing.Size(416, 158);
			this.gboxResultado.TabIndex = 7;
			this.gboxResultado.TabStop = false;
			this.gboxResultado.Text = " Resultado ";
			// 
			// lbelErros
			// 
			this.lbelErros.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.lbelErros.Location = new System.Drawing.Point(73, 88);
			this.lbelErros.Name = "lbelErros";
			this.lbelErros.Size = new System.Drawing.Size(314, 23);
			this.lbelErros.TabIndex = 5;
			this.lbelErros.Text = "Erros ao mover: X";
			this.lbelErros.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// pboxErros
			// 
			this.pboxErros.Image = ((System.Drawing.Image)(resources.GetObject("pboxErros.Image")));
			this.pboxErros.Location = new System.Drawing.Point(17, 88);
			this.pboxErros.Name = "pboxErros";
			this.pboxErros.Size = new System.Drawing.Size(50, 50);
			this.pboxErros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pboxErros.TabIndex = 4;
			this.pboxErros.TabStop = false;
			// 
			// btnRelatorio
			// 
			this.btnRelatorio.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
			this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRelatorio.Location = new System.Drawing.Point(278, 176);
			this.btnRelatorio.Name = "btnRelatorio";
			this.btnRelatorio.Size = new System.Drawing.Size(150, 40);
			this.btnRelatorio.TabIndex = 8;
			this.btnRelatorio.Text = "Relatório";
			this.btnRelatorio.UseVisualStyleBackColor = true;
			this.btnRelatorio.Click += new System.EventHandler(this.BtnRelatorioClick);
			// 
			// formResultado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 225);
			this.Controls.Add(this.btnRelatorio);
			this.Controls.Add(this.gboxResultado);
			this.Controls.Add(this.btnVoltar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "formResultado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wallmgr - Resultado";
			this.Load += new System.EventHandler(this.FormResultadoLoad);
			((System.ComponentModel.ISupportInitialize)(this.pboxMovidos)).EndInit();
			this.gboxResultado.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pboxErros)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
