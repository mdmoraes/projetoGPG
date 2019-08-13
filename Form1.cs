using System;
using System.IO;
using System.Windows.Forms;

namespace EncontrarArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Recupera as configurações
        private void Form1_Load(object sender, EventArgs e)
        {
            txtPastaInicial.Text = Properties.Settings.Default.PastaInicial;
            cboPadraoArquivos.Text = Properties.Settings.Default.PadraoArquivos;
        }

        // Salva as configurações atuais
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PastaInicial = txtPastaInicial.Text;
            Properties.Settings.Default.PadraoArquivos = cboPadraoArquivos.Text;
            Properties.Settings.Default.Save();
        }

        //define a pasta inicial para buscar os arquivos
        private void btnDiretorioInicial_Click(object sender, EventArgs e)
        {
            try
            {
                fbd1.SelectedPath = txtPastaInicial.Text;
                if (fbd1.ShowDialog() == DialogResult.OK)
                {
                    txtPastaInicial.Text = fbd1.SelectedPath;
                }
            }
            catch
            {
                throw;
            }
        }

        //Chama o método ProcurarArquivos passando os valores
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtPastaInicial.Text) && cboPadraoArquivos.SelectedIndex != -1)
            //{
            //    ProcuraArquivos(lbArquivos, txtPastaInicial.Text, cboPadraoArquivos.Text);
            //}
            //else
            //{
            //    MessageBox.Show("Defina a pasta incial de busca e/ou o padrão de arquivos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        // Localiza arquivos que atendem o padrão definido
        private void ProcuraArquivos(ListBox lstb, string pastaInicial, string padrao)
        {
            try
            {
                // Limpa a listbox
                lbArquivos.Items.Clear();
                // Define os padrões
                string[] padroes = AnalisaPadroes(padrao);
                DirectoryInfo dir_info = new DirectoryInfo(pastaInicial);
                //Procura no diretório usando os padrões
                ProcuraDiretorio(lstb, dir_info, padroes);
                //exibe mensagem 
                MessageBox.Show("Foram encontrados " + lstb.Items.Count + " arquivos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Encontra os arquivos que atendem o padrão no diretorio
        private void ProcuraDiretorio(ListBox lstb, DirectoryInfo dir_info, string[] padroes)
        {
            try
            {
                // Procura o diretorio
                foreach (string padrao in padroes)
                {
                    // Verifica o padrão
                    foreach (FileInfo Arq_info in dir_info.GetFiles(padrao))
                    {
                        // Processa o arquivo
                        ProcessaArquivo(lstb, Arq_info);
                    }
                }

                // Procura nos subdiretorios
                foreach (DirectoryInfo subdir_info in dir_info.GetDirectories())
                {
                    ProcuraDiretorio(lstb, subdir_info, padroes);
                }
            }
            catch
            {
                throw;
            }
        }

        private void ProcessaArquivo(ListBox lstb, FileInfo arq_info)
        {
            try
            {
                //exibe o nome do arquivo no listbox
                lstb.Items.Add(arq_info.FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar o arquivo " + arq_info.FullName + "\n" + ex.Message);
            }
        }

        private string[] AnalisaPadroes(string string_padrao)
        {
            try
            {
                // Pega tudo que esta entre os parenteses
                if (string_padrao.Contains("("))
                {
                    string_padrao = TextoEntre(string_padrao, "(", ")");
                }

                // divide a string em ;
                string[] resultado = string_padrao.Split(';');

                // Remove todos os padrões para espaço extra
                for (int i = 0; i < resultado.Length; i++)
                {
                    resultado[i] = resultado[i].Trim();
                }
                //retorna o resultado
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        private string TextoEntre(string txt, string delimitador1, string delimitador2)
        {
            try
            {
                // Encontra o delimitador inicial
                int pos1 = txt.IndexOf(delimitador1);
                int texto_inicio = pos1 + delimitador1.Length;
                int pos2 = txt.IndexOf(delimitador2, texto_inicio);
                return txt.Substring(texto_inicio, pos2 - texto_inicio);
            }
            catch
            {
                throw;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void LbArquivos_DoubleClick(object sender, EventArgs e)
        {
            //  txtArquivoEscolhido.Text = lbArquivos.SelectedItem.ToString();
        }

        private void LbArquivos_Click(object sender, EventArgs e)
        {
            txtArquivoEscolhido.Text = lbArquivos.SelectedItem.ToString();
        }

        private void CboPadraoArquivos_DropDown(object sender, EventArgs e)
        {

        }

        private void CboPadraoArquivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPastaInicial.Text) && cboPadraoArquivos.SelectedIndex != -1)
            {
                ProcuraArquivos(lbArquivos, txtPastaInicial.Text, cboPadraoArquivos.Text);
            }
            else
            {
                MessageBox.Show("Defina a pasta incial de busca e/ou o padrão de arquivos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEncriptar_Click(object sender, EventArgs e)
        {
            

            if (txtChavePublica.Text == string.Empty)
            {
                MessageBox.Show("Campo Chave pública é requerido");
                txtChavePublica.Focus();
                return;

             }
           
            try
            { 
            
                System.Diagnostics.ProcessStartInfo psi =
                new System.Diagnostics.ProcessStartInfo("cmd.exe");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                psi.WorkingDirectory = "C:\\Program Files (x86)\\GnuPG\\bin";

                string ArquivoEncriptado = txtArquivoEscolhido.Text;
                string ChavePublica = txtChavePublica.Text;


                System.Diagnostics.Process process = System.Diagnostics.Process.Start(psi);

                string sCommandLine = "gpg -e -r" +" " + ChavePublica +" " + ArquivoEncriptado;

                process.StandardInput.WriteLine(sCommandLine);
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
                MessageBox.Show("Arquivo Encriptado com Sucesso.");
               // listBoxResultado.Text = sCommandLine;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void BtnDescriptar_Click(object sender, EventArgs e)
        {
         //   txtChavePublica.Text = string.Empty;

            if (txtArquivoEscolhido.Text == "")
            {
                MessageBox.Show("É necessário escolher um Arq. *.gpg");
                txtArquivoEscolhido.Focus();
                return;
            }

            try
            {
                System.Diagnostics.ProcessStartInfo psi =
                new System.Diagnostics.ProcessStartInfo("cmd.exe");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                psi.WorkingDirectory = "C:\\Program Files (x86)\\GnuPG\\bin";

                string ArquivoEncriptado = txtArquivoEscolhido.Text;
                string ChavePublica = txtChavePublica.Text;

                string arquivo = ArquivoEncriptado;
                int startIndex = 0;
                int endIndex = arquivo.Length - 4;
                string title = arquivo.Substring(startIndex, endIndex);
              
                System.Diagnostics.Process process = System.Diagnostics.Process.Start(psi);

                //executando o comando GPG para descriptar um arquivo encriptado.
                string sCommandLine = "gpg --output" + " " + title + " " + "--decrypt" + " " + ArquivoEncriptado;

                process.StandardInput.WriteLine(sCommandLine);
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
                MessageBox.Show("Arquivo Desencriptado com Sucesso.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}

