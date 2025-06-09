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
        private String nomeJog1, nomeJog2;

        // Método construtor da classe frmJogoDados, é o método que é executado
        // quando é criada a nova instância dessa classe, em que você pode
        // por exemplo, adicionar comandos que serão executados logo na criação da classe.
        public frmJogoDados(String nomeJog1, String nomeJog2)
        {
            InitializeComponent();
            this.nomeJog1 = nomeJog1;
            this.nomeJog2 = nomeJog2;
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

        private void frmJogoDados_Load(object sender, EventArgs e)
        {
            lblJogador1.Text = nomeJog1;
            lblJogador2.Text = nomeJog2;
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

            // Pega o pai do diretório, no caso, começa da BaseDirectory, que geralmente é o diretório '/debug'
            // que pega o diretório pai do debug, que é '/bin', duas vezes até chegar na raiz do projeto 'ImagensDinamicas'

           string caminhoProjeto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

           string arquivoDado = Path.Combine(caminhoProjeto, "Imagens", "dado" + valorDado.ToString() + ".jpg");

           
            if (!File.Exists(arquivoDado))
            {
                MessageBox.Show($"Arquivo de imagem não encontrado: {arquivoDado}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            // Carregar a imagem do dado usando a variável arquivoDado como parâmetro
            dado.Image = Image.FromFile(arquivoDado);

            return valorDado;
        }
    }
}
