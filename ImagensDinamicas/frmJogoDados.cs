using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnJogar_Click(object sender, EventArgs e)
        {
            picJogador1.Image = SorteioDado(picJogador1);
            picJogador2.Image = SorteioDado(picJogador2);
        }

        // Método que sorteia os valores do dado
        private Image SorteioDado(PictureBox dado)
        {
            int valorDado = random.Next(1, 7);
            // Variável String que guarda a concatenação da palavra "dado" com o valor convertido para String e
            // o tipo da imagem para referenciar o arquivo na pasta "Imagens"
            String arquivoDado = ".\\Imagens\\dado" + valorDado.ToString() + ".jpg";
            // Carregar a imagem do dado usando a variável arquivoDado como parâmetro
     
            dado.Image = Image.FromFile(arquivoDado);

            return dado.Image;
        }
    }
}
