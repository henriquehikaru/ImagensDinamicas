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
            frmCarregaFoto fotos = new frmCarregaFoto();
            //txtJog1.Text, txtJog2.Text
            fotos.ShowDialog();
        }

        private void picDado_Click(object sender, EventArgs e)
        {
            frmJogoDados dados = new frmJogoDados(txtJog1.Text, txtJog2.Text);
            dados.ShowDialog();
        }
    }
}
