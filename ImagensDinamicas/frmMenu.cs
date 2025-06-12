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
    public partial class frmMenu: Form
    {
    
        public frmMenu()
        {
            InitializeComponent();
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            frmCarregaFoto fotos = new frmCarregaFoto(txtJog1.Text, txtJog2.Text, picJog1.Image, picJog2.Image);
            //txtJog1.Text, txtJog2.Text
            fotos.ShowDialog();
            if (fotos.FotoJog1Image != null)
                picJog1.Image = fotos.FotoJog1Image;
            if (fotos.FotoJog2Image != null)
                picJog2.Image = fotos.FotoJog2Image;
        }

        private void picDado_Click(object sender, EventArgs e)
        {
            if (picJog1.Image == null || picJog2.Image == null)
            {
                MessageBox.Show("Por favor, carregue as fotos dos jogadores antes de iniciar o jogo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmJogoDados dados = new frmJogoDados(txtJog1.Text, txtJog2.Text, picJog1.Image, picJog2.Image);
            dados.ShowDialog();
            if (dados.contVitoria1 > 0)
                lblPlacarMenu1.Text = dados.contVitoria1.ToString();
            else
            {
                lblPlacarMenu1.Text = "0";
            }

            if (dados.contVitoria2 > 0)
                lblPlacarMenu2.Text = dados.contVitoria2.ToString();
            else
            {
                lblPlacarMenu2.Text = "0";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void lblPlacarMenu2_Click(object sender, EventArgs e)
        {

        }
    }
}
