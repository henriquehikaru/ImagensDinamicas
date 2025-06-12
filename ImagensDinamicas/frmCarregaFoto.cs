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
    public partial class frmCarregaFoto: Form
    {
        string caminhoProjeto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

        public PictureBox FotoJog1 { get; private set; }
        public PictureBox FotoJog2 { get; private set; }
        public frmCarregaFoto(String lblJogador1, String lblJogador2, Image picJogador1, Image picJogador2)
        {
            InitializeComponent();
            this.lblJogador1.Text = lblJogador1;
            this.lblJogador2.Text = lblJogador2;
            this.picJogador1.Image = picJogador1;
            this.picJogador2.Image = picJogador2;
        }

        private void btnCarregarFotoJog1_Click(object sender, EventArgs e)
        {
            openFDFoto.Filter = "JPEG (*jpg)|*.jpg|" + "Bitmaps (*.bmp)|*.bmp|" + "JFIF (*.jfif)|*.jfif";
            if (openFDFoto.ShowDialog() == DialogResult.OK)
            {
                picJogador1.Image = Image.FromFile(openFDFoto.FileName);
                this.FotoJog1 = picJogador1;
            }
            else
            {
                picJogador1.Image = null;
            }
        }

        private void btnCarregarFotoJog2_Click(object sender, EventArgs e)
        {
            openFDFoto.Filter = "JPEG (*jpg)|*.jpg|" + "Bitmaps (*.bmp)|*.bmp|" + "JFIF (*.jfif)|*.jfif";
            if (openFDFoto.ShowDialog() == DialogResult.OK)
            {
                picJogador2.Image = Image.FromFile(openFDFoto.FileName);
                this.FotoJog2 = picJogador2;
            }
            else
            {
                picJogador2.Image = null;
            }
        }

        private void frmCarregaFoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (picJogador1.Image == null)
            {
                string arquivoDado = Path.Combine(caminhoProjeto, "Imagens", "sem_imagem_avatar" + ".png");
                picJogador1.Image = Image.FromFile(arquivoDado);
                this.FotoJog1 = picJogador1;
            }

            if (picJogador2.Image == null)
            {
                string arquivoDado = Path.Combine(caminhoProjeto, "Imagens", "sem_imagem_avatar" + ".png");
                picJogador2.Image = Image.FromFile(arquivoDado);
                this.FotoJog2 = picJogador2;
            }
        }

        private void chkJog1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJog1.Checked)
            {
                picJogador1.Visible = true;
                btnCarregarFotoJog1.Visible = true;
            }
            else
            {
                picJogador1.Visible = false;
                btnCarregarFotoJog1.Visible = false;
            }
        }

        private void chkJog2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJog2.Checked)
            {
                picJogador2.Visible = true;
                btnCarregarFotoJog2.Visible = true;
            }
            else
            {
                picJogador2.Visible = false;
                btnCarregarFotoJog2.Visible = false;
            }
            
        }
    }
}
