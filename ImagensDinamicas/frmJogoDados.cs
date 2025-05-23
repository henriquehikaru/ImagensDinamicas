using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagensDinamicas
{
    
    public partial class frmJogoDados : Form
    {
        Random srt = new Random();
        private int dadoJog1, dadoJog2;
        private int contVitoria1 = 0, contVitoria2 = 0;

        public frmJogoDados()
        {
            InitializeComponent();
        }

        private Random random = new Random();

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            contVitoria1 = 0;
            contVitoria2 = 0;
            lblPlacar1.Text = "0";
            lblPlacar2.Text = "0";
            picJogador1.Image = null;
            picJogador2.Image = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmJogoDados_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente sair?", "Jogo de Dados CTI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            dadoJog1 = SorteioDado(picJogador1);
            dadoJog2 = SorteioDado(picJogador2);

            if (dadoJog1 > dadoJog2)
            {
                contVitoria1 += 1;
                lblPlacar1.Text = contVitoria1.ToString();
            }
            else if (dadoJog2 > dadoJog1)
            {
                contVitoria2 += 1;
                lblPlacar2.Text = contVitoria2.ToString();
            }
            else
            {
                MessageBox.Show("Empate!", "Jogo de Dados CTI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // Método que sorteia os valores do dado
        private int SorteioDado(PictureBox dado)
        {
            int valorDado = random.Next(1, 7);
            // Variável String que guarda a concatenação da palavra "dado" com o valor convertido para String e

            // o tipo da imagem para referenciar o arquivo na pasta "Imagens"
            // Pega o diretório base da aplicação (geralmente bin\Debug ou bin\Release)
            string caminhoBase = AppDomain.CurrentDomain.BaseDirectory;

            // Cria o caminho completo para a imagem do dado
            string arquivoDado = Path.Combine(caminhoBase, "Imagens", "dado" + valorDado.ToString() + ".jpg");

            // Verifica se o arquivo existe antes de tentar carregar
            if (!File.Exists(arquivoDado))
            {
                MessageBox.Show($"Arquivo de imagem não encontrado: {arquivoDado}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            //String arquivoDado = ".\\ImagensDinamicas\\bin\\debug\\net\\Imagens\\dado" + valorDado.ToString() + ".jpg";
            // Carregar a imagem do dado usando a variável arquivoDado como parâmetro
            // o tipo da imagem para referenciar o arquivo na pasta "Imagens" \bin\debug do projeto
            dado.Image = Image.FromFile(arquivoDado);

            return valorDado;
        }
    }
}
