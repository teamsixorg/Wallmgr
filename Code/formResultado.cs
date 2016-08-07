
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
	public partial class formResultado : Form
	{
		
		#region [...]
		
		public formResultado()
		{
			InitializeComponent();
		}
		
		#endregion
		
		#region Declarações.
		
		public formRelatorio formRelatorio;
		public int contadorMovidos = 0;
		public int contadorErros = 0;
		
		#endregion
		
		#region Funções.
		
		public string ObterVersao()
        {
			/* Extrai a versão atual do programa do Assembly do projeto. */
			
			var valorVersao = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
			return valorVersao.ProductVersion.ToString();
        }
		
		public void ContagemRelatorio()
		{
			/* Realiza a contagem das imagens que foram movidas e dos erros ocorridos. */

			if(contadorMovidos > 0)
			{
				lbelArquviosMovidos.Text = "Arquivos movidos: " + contadorMovidos;
			}
			else
			{
				lbelArquviosMovidos.Text = "Nenhum arquivo movido.";
			}
			
			if(contadorErros > 0)
			{
				lbelErros.Text = "Erros ao mover: " + contadorErros;
			}
			else
			{
				lbelErros.Text = "Nenhum erro ocorrido.";
			}
		}
		
		#endregion
		
		#region Eventos.
		
		void FormResultadoLoad(object sender, EventArgs e)
		{
			
			#region Ajuste do formulário.
			
			this.Text = "Wallmgr - Resultado [v" + ObterVersao() + "]";
			btnRelatorio.Select();
			btnRelatorio.Focus();
			ContagemRelatorio();
			
			#endregion

		}
		
		void BtnVoltarClick(object sender, EventArgs e)
		{	
			this.Close();
		}
		
		void BtnRelatorioClick(object sender, EventArgs e)
		{
			formRelatorio.ShowDialog();
		}
		
		#endregion
	}
}
