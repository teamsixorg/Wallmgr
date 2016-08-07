
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
      public partial class formHome : Form
      {

        #region [...]

        public formHome()
        {
          InitializeComponent();
        }

        #endregion

        #region Declarações.

        public formResultado formResultado = new formResultado();
        public formRelatorio formRelatorio = new formRelatorio();
        public formOpcoes formOpcoes = new formOpcoes();
        public int contadorImagens = 0;

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

        public string RestaurarDiretorioPadrao()
        {
			/* Restura o diretório de exportação padrão do arquivo de configurações. */

			var localDiretorioPadrao = LeituraConfiguracoes("ExportDir");
            return localDiretorioPadrao.ToString();
        }

        public void ExibirTooltip(string valorMensagem, object objEnviado)
        {
            /* Cria um novo ToolTip e defini ele no objeto indicado com a mensagem desejada. */

            var objConversao = (Control) objEnviado;
            var ttMensagem = new ToolTip();
            ttMensagem.SetToolTip(objConversao, valorMensagem);
        }

        public void AtualizarContagem()
        {
			/* Atualiza o contador de imagens existentes na lista. */
			/* Renomeia o ID dos items da forma correta. */
			
			contadorImagens = lvImagens.Items.Count;
			for (var contadorAtual = 0; contadorAtual < contadorImagens; contadorAtual++)
			{
			lvImagens.Items[contadorAtual].Text = Convert.ToString(contadorAtual + 1);
			contadorAtual++;
			}
        }

        public void ObterInformacoes(string caminhoImagem)
        {
			/* Obtem e aplica as informações da imagem selecionada. */
			
			var infoImagem = new FileInfo(caminhoImagem);
			var imageImagem = Image.FromFile(caminhoImagem);
			var nomeImagem = Path.GetFileName(caminhoImagem);
			var tamahoImagem = Convert.ToString(infoImagem.Length / 1024);
			var resolucaoImagem = imageImagem.Width.ToString() + "x" + imageImagem.Height.ToString();
			tslbArquivo.Text = "Arquivo: " + nomeImagem;
			tslbTamanho.Text = "Tamanho: " + tamahoImagem + " kb";
			tslbResolucao.Text = "Resolução: " + resolucaoImagem + " px";
			tslbSep1.Text = "|";
			tslbSep2.Text = "|";
			infoImagem = null;
			imageImagem.Dispose();
        }

        public void LimparInformacoes()
        {
			/* Limpa as informações de seleção. */
			
			tslbArquivo.Text = null;
			tslbTamanho.Text = null;
			tslbResolucao.Text = null;
			tslbSep1.Text = null;
			tslbSep2.Text = null;
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

        public void AdicionarImagem()
        {
			/* Adiciona (por meio de um diálogo) uma ou mais imagens a lista. */
			
			var dialogoSelecao = new OpenFileDialog
			{
				AddExtension = true,
				AutoUpgradeEnabled = true,
				Filter = "Todas as imagens|*.png;*.jpg;*.jpeg;*.bmp",
				Multiselect = true,
				RestoreDirectory = true,
				Title = "Selecione as imagens que deseja adicionar."
			};
			
			if (dialogoSelecao.ShowDialog() == DialogResult.OK)
			{
				for (var contadorAtual = 0; contadorAtual < dialogoSelecao.FileNames.Length; contadorAtual++)
				{
					var itemID = Convert.ToString(contadorImagens + 1);
					var itemArquivo = Path.GetFileName(dialogoSelecao.FileNames[contadorAtual]);
					var itemExtensao = Path.GetExtension(dialogoSelecao.FileNames[contadorAtual]).ToUpper();
					var itemLocal = dialogoSelecao.FileNames[contadorAtual];
					var itemImagem = new ListViewItem();
					itemImagem.Text = itemID;
					itemImagem.SubItems.Add(itemArquivo);
					itemImagem.SubItems.Add(itemExtensao);
					itemImagem.SubItems.Add(itemLocal);
					lvImagens.Items.Add(itemImagem);
					contadorImagens++;
				}
			}
        }

        public void RemoverImagem(int valorIndex)
        {
			/* Remove a imagem selecionada da lista. */
			
			lvImagens.Items[valorIndex].Remove();
			if (lvImagens.Items.Count > 0)
			{
			lvImagens.Items[0].Selected = true;
			lvImagens.Items[0].Focused = true;
			}
			contadorImagens--;
        }

        public void LimparImagens()
        {
			/* Remove todas as imagens da lista. */
			
			lvImagens.Items.Clear();
			contadorImagens = 0;
        }

        public void Exportar(List<string> listaImagens)
        {
			/* Move todas as imagens da tabela para o diretório selecionado, dando a elas nomes aleatórios conforme a sintaxe. */
			/* Cria uma lista com as informações de expotação. Em caso de erro, retorna o seu conteúdo. */
			
			if (string.IsNullOrEmpty(tboxPastaDestino.Text) == false)
			{
				var localDestino = tboxPastaDestino.Text; // Defini a pasta de exportação.
				
				for (var contadorAtual = 0; contadorAtual < listaImagens.Count; contadorAtual++)
				{
			
				  #region Informações de exportação.
				
				  var numeroAleatorio = new Random(); // Novo número aleatório.
				  var contadorTentativas = 1; // Número de tentatvis realizadas. (1 até 5)
				  var estadoExportacao = 0;
				    // Estado de exportação da imagem. 1 para movido com êxito e 0 para ocorrência de erro ao mover.
				  var valorErro = ""; // Conteúdo do erro ao mover a imagem.
				  var imagemIndex = contadorAtual; // Index da imagem na lista.
				  var localInicial = Path.GetDirectoryName(listaImagens[contadorAtual]); // Pasta da imagem.
				  var arquivoInicial = Path.GetFileName(listaImagens[contadorAtual]); // Nome do arquivo da imagem.
				  var localNovo = localDestino; // Pasta de exportação da imagem.
				  var arquivoNovo = "{" + numeroAleatorio.Next(0, 9) + numeroAleatorio.Next(0, 9) + numeroAleatorio.Next(0, 9) + numeroAleatorio.Next(0, 9) + "-" + numeroAleatorio.Next(0, 9) + numeroAleatorio.Next(0, 9) + numeroAleatorio.Next(0, 9) + numeroAleatorio.Next(0, 9) + "}" + Path.GetExtension(arquivoInicial); // Nome do novo arquivo da imagem.
				
				  #endregion
			
			  #region Exportação da imagem.
			
			  while (contadorTentativas < 5)
			  {
			
			    #region Tentativa inicial.
			
			    try
			    {
			      File.Move(localInicial + @"\" + arquivoInicial, localNovo + @"\" + arquivoNovo);
			      contadorTentativas = 5;
			      estadoExportacao = 1;
			    }
			
			    #endregion
			
			    #region [Exceção] Diretório não encontrado.
			
			    catch (DirectoryNotFoundException)
			    {
			      valorErro = "O diretório informado não foi encontrado.";
			      contadorTentativas = 5;
			      estadoExportacao = 0;
			    }
			
			    #endregion
			
			    #region [Exceção] Nome de arquivo muito grande.
			
			    catch (PathTooLongException)
			    {
			      valorErro = "O nome informado é muito grande.";
			      contadorTentativas = 5;
			      estadoExportacao = 0;
			    }
			
			    #endregion
			
			    #region Nova tentativa.
			
			    catch
			    {
			      arquivoNovo = "{" + numeroAleatorio.Next(0, 9) + numeroAleatorio.Next(0, 9) + numeroAleatorio.Next(0, 9) + numeroAleatorio.Next(0, 9) + "-" + numeroAleatorio.Next(0, 9) + numeroAleatorio.Next(0, 9) + numeroAleatorio.Next(0, 9) + numeroAleatorio.Next(0, 9) + "}" + Path.GetExtension(arquivoInicial);
			      contadorTentativas++;
			      estadoExportacao = 0;
			    }
			
			    #endregion
			
			  }
			
			  #endregion
			
			  #region Geração do item do relatório.
			
			  ListViewItem itemExportacao = new ListViewItem();
			  itemExportacao.Text = (contadorAtual + 1).ToString();
			  if (estadoExportacao == 1)
			  {
			  	itemExportacao.SubItems.Add("Movido com êxito");
			  	itemExportacao.SubItems.Add(arquivoInicial);
		      	formResultado.contadorMovidos++;
			  }
			  else
			  {
			    if (string.IsNullOrEmpty(valorErro) == false)
			    {
			  		itemExportacao.SubItems.Add("Erro ao mover (não identificado)");
			  		itemExportacao.SubItems.Add(arquivoInicial);
			    }
			    else
			    { 
			  		itemExportacao.SubItems.Add("Erro ao mover (" + valorErro + ")");
			  		itemExportacao.SubItems.Add(arquivoInicial);
			    }
			    formResultado.contadorErros++;
			  }
			  #endregion
			  formRelatorio.lvRelatorio.Items.Add(itemExportacao);
            }
		                			    
          	#region  Finzalização do procedimento.

          	formResultado.formRelatorio = this.formRelatorio;
          	formResultado.ShowDialog();
          	#endregion
          }
          else
          {
            MessageBox.Show("Você precisa definir um destino para as imagens antes de prosseguir.", "Uma etapa de cada vez", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }

        #endregion

        #region Eventos.

        private void FormHomeLoad(object sender, EventArgs e)
        {
        	
			#region Ajuste do formulário.
          
			this.Text = "Wallmgr - Gerenciador e categorizadore de imagens [v" + ObterVersao() + "]";
          	this.tboxPastaDestino.Text = RestaurarDiretorioPadrao();
          	if(lvImagens.Items.Count < 1)
          	{
				btnAdicionar.Select();
          		btnAdicionar.Focus();
          	}
			else
			{
				btnIniciar.Select();
				btnIniciar.Focus();
			}
			
			#endregion
        	
			#region Ajuste dos ToolTips
          
			ExibirTooltip("Selecionar destino para exportação", btnSelecionar);
			ExibirTooltip("Restaurar o diretório de exportação padrão", btnRestaurarDiretorio);
			ExibirTooltip("Adicionar imagens a lista", btnAdicionar);
			ExibirTooltip("Remover imagem da lista", btnRemover);
			ExibirTooltip("Visualizar a iamgem externamente", btnVer);
			ExibirTooltip("Limpar lista de imagens", btnLimpar);
          
			#endregion
			
        }

        private void BtnSelecionarClick(object sender, EventArgs e)
        {
            tboxPastaDestino.Text = SelecionarDestino();
        }

        private void BtnRestaurarDiretorioClick(object sender, EventArgs e)
        {
        	string localLocalPadrao = RestaurarDiretorioPadrao();
        	if(string.IsNullOrEmpty(localLocalPadrao) == false)
        	{
        		tboxPastaDestino.Text = RestaurarDiretorioPadrao();
        	}
            else
            {
            	if (MessageBox.Show("Nenhum diretório padrão foi configurado. Deseja fazer isso agora?", "Ainda não.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            	{
            		formOpcoes.ShowDialog();
            	}
            	else
            	{
            		this.Show();
            	}
			}
        }

        private void BtnAdicionarClick(object sender, EventArgs e)
        {
            AdicionarImagem();
            AtualizarContagem();
        }

        private void BtnRemoverClick(object sender, EventArgs e)
        {
            RemoverImagem(lvImagens.SelectedItems[0].Index);
            AtualizarContagem();
        }

        private void BtnVerClick(object sender, EventArgs e)
        {
            Process.Start(lvImagens.SelectedItems[0].SubItems[3].Text);
        }

        private void BtnLimparClick(object sender, EventArgs e)
        {
          if (lvImagens.Items.Count > 0)
          {
            if (
                  MessageBox.Show("Deseja realmente limpar a lista de imagens?", "Quer apagar tudo?", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question) == DialogResult.Yes)
              {
                  LimparImagens();
                  AtualizarContagem();
              }
              else
              {
                  this.Show();
              }
          }
          else
          {
              MessageBox.Show("Não há nenhuma imagem na lista.", "Assim não tem como.", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }

        private void BtnSairClick(object sender, EventArgs e)
        {
          if (MessageBox.Show("Deseja realmente sair?", "Fique mais um pouco!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          {
              Application.Exit();
          }
          else
          {
              this.Show();
          }
        }

        private void BtnOpcoesClick(object sender, EventArgs e)
        {
            formOpcoes.ShowDialog();
        }

        private void BtnIniciarClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxPastaDestino.Text) == false)
            {
                if (lvImagens.Items.Count > 0)
                {
                    List<string> listaImagens = new List<string>();
                    for (var contadorAtual = 0; contadorAtual < lvImagens.Items.Count; contadorAtual++)
                    {
                        listaImagens.Add(lvImagens.Items[contadorAtual].SubItems[3].Text);
                    }
                    LimparImagens();
                    LimparInformacoes();
                    Exportar(listaImagens);
                }
                else
                {
                    MessageBox.Show("Não há nenhuma imagem na lista.", "Com calma...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                 MessageBox.Show("Você precisa definir um destino para as imagens antes de prosseguir.", "Uma etapa de cada vez", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void LvImagensSelectedIndexChanged(object sender, EventArgs e)
        {
          if (lvImagens.SelectedItems.Count > 0)
          {
              btnRemover.Enabled = true;
              btnVer.Enabled = true;
              ObterInformacoes(lvImagens.SelectedItems[0].SubItems[3].Text);
          }
          else
          {
              btnRemover.Enabled = false;
              btnVer.Enabled = false;
              LimparInformacoes();
          }
        }

        #endregion

      }
}
