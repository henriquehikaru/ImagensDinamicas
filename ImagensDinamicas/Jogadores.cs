using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImagensDinamicas
{
    class Jogadores
    {
        public string Jogador1 { get; set; }
        public string Jogador2 { get; set; }

        public Image FotoJog1 { get; set; }
        public Image FotoJog2 { get; set; }

        public int contVitoria1 { get; set; }
        public int contVitoria2 { get; set; }
    }
}
