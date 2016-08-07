
#region Using.

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.AccessControl;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

#endregion

namespace Wallmgr
{
	public partial class formRelatorio : Form
	{
		
		#region [...]
		
		public formRelatorio()
		{
			InitializeComponent();
		}
		
		#endregion

		#region Funções.
		
		public string ObterVersao()
		{
			/* Extrai a versão atual do programa do Assembly do projeto. */
			
			var valorVersao = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
			return valorVersao.ProductVersion.ToString();
		}
		
		public string Exportar()
		{
			/* Exporta o conteúdo do relatório atual para um arquivo de LOG. */
			
			string localArquivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Wallmgr - LOG.log";
			StreamWriter escritaArquivo = new StreamWriter(localArquivo);
			for(int contadorAtual = 0; contadorAtual < lvRelatorio.Items.Count; contadorAtual++)
			{
				escritaArquivo.WriteLine("# " + lvRelatorio.Items[contadorAtual].SubItems[1].Text + " # Arquivo: \"" + lvRelatorio.Items[contadorAtual].SubItems[2].Text + "\"");
			}
			escritaArquivo.Close();
			escritaArquivo.Dispose();
			return localArquivo;
		}
		
		#endregion
		
		#region Eventos.
		
		void FormRelatorioLoad(object sender, EventArgs e)
		{
			
			#region Ajuste do formulário.
			
			this.Text = "Wallmgr - Relatório da execução [v" + ObterVersao() + "]";
			btnExportar.Select();
			btnExportar.Focus();
			
			#endregion
			
		}
		
		void BtnVoltarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnExportarClick(object sender, EventArgs e)
		{
			MessageBox.Show("Uma cópia do relatório foi enviada para \"" + Exportar() + "\".", "Sem problemas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		#endregion
	}
}
