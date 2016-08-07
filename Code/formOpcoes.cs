
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
      public partial class formOpcoes : Form
      {

        #region [...]

        public formOpcoes()
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

        public string LeituraConfiguracoes(string parametroLeitura)
        {
            /* Encontra no arquivo de configurações o valor do parâmetro indicado. */

            var valorResultado = "";
            StreamReader leituraConfig = new StreamReader(@"Data\Config.ini");
            while (!leituraConfig.EndOfStream)
            {
                var linhaAtual = leituraConfig.ReadLine();
                if (string.IsNullOrEmpty(linhaAtual.ToString()) == false)
                {
                    string[] divisaoLinhaAtual = linhaAtual.Split('=');
                    if (divisaoLinhaAtual[0] == parametroLeitura)
                    {
                        linhaAtual = divisaoLinhaAtual[1];
                        divisaoLinhaAtual = linhaAtual.Split('\"');
                        valorResultado = divisaoLinhaAtual[1];
                    }
                }
            }
            leituraConfig.Close();
            leituraConfig.Dispose();
            return valorResultado.ToString();
          }

        public void ExibirTooltip(string valorMensagem, object objEnviado)
        {
            /* Cria um novo ToolTip e deini ele no objeto indicado com a mensagem indicada. */

            var objConversao = (Control) objEnviado;
            var ttMensagem = new ToolTip();
            ttMensagem.SetToolTip(objConversao, valorMensagem);
        }

    	public string SelecionarDestino()
        {
			/* Seleciona (por meio de um diálogo) o destino para a exportação das imagens. */
			
			string caminhoDestino = null;
			var dialogoSelecao = new FolderBrowserDialog
			{
			Description = "Selecione um destino para a exportação das imagens."
			};
			
			if (dialogoSelecao.ShowDialog() == DialogResult.OK)
			{
			caminhoDestino = dialogoSelecao.SelectedPath;
			}
			return caminhoDestino;
        }

      	public void SalvarConfiguracoes()
          {
              /* Salvar as configurações conforme solicitado. */

              StreamWriter escritaConfig = new StreamWriter(@"Data/Config.ini");
              escritaConfig.WriteLine("ExportDir=\"" + tboxDestinoExportacao.Text + "\"");
              escritaConfig.Close();
              escritaConfig.Dispose();
          }

        #endregion

        #region Eventos.

        void FormOpcoesLoad(object sender, EventArgs e)
        {
        	
        	#region Ajuste do formulário.
        	
        	this.Text = "Wallmgr - Opções [v" + ObterVersao() + "]";
            tboxDestinoExportacao.Text = LeituraConfiguracoes("ExportDir");
            btnSalvar.Select();
            btnSalvar.Focus();
        	
        	#endregion
            
            #region Ajuste dos ToolTips.

			ExibirTooltip("Alterar destino de expotação padrão", btnSelecionarDestinoExportacao);			

            #endregion
            
        }
        
        void BtnAlterarDestinoExportacaoClick(object sender, EventArgs e)
		{
        	string valorLocalAtual = tboxDestinoExportacao.Text;
        	string valorNovoLocal = SelecionarDestino();
        	if (string.IsNullOrEmpty(valorNovoLocal) == false)
        	{
        		tboxDestinoExportacao.Text = valorNovoLocal;
        	}
        	else
        	{
        		tboxDestinoExportacao.Text = valorLocalAtual;
        	}
		}

		void BtnSalvarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja realmente sobrescrever as configurações atuais?", "Renovando os hábitos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				SalvarConfiguracoes();
				MessageBox.Show("Suas definições foram aplicadas com êxito, porém, só entrarão em vigor na próxima inicialização do programa.", "Quase certo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				this.Show();
			}
		}
		
		void BtnVoltarClick(object sender, EventArgs e)
		{
			this.Close();
		}

        #endregion

      }
}
