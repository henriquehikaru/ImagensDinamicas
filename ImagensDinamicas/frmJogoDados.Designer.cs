namespace ImagensDinamicas
{
    partial class frmJogoDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblPlacar1 = new System.Windows.Forms.Label();
            this.lblPlacar2 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tmrAnimacaoDado = new System.Windows.Forms.Timer(this.components);
            this.picJogador2 = new System.Windows.Forms.PictureBox();
            this.picJogador1 = new System.Windows.Forms.PictureBox();
            this.picJog1 = new System.Windows.Forms.PictureBox();
            this.picJog2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador1.Location = new System.Drawing.Point(133, 166);
            this.lblJogador1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(105, 28);
            this.lblJogador1.TabIndex = 1;
            this.lblJogador1.Text = "Jogador 1";
            // 
            // lblPlacar1
            // 
            this.lblPlacar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlacar1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar1.Location = new System.Drawing.Point(152, 481);
            this.lblPlacar1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlacar1.Name = "lblPlacar1";
            this.lblPlacar1.Size = new System.Drawing.Size(84, 63);
            this.lblPlacar1.TabIndex = 2;
            this.lblPlacar1.Text = "0";
            this.lblPlacar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlacar2
            // 
            this.lblPlacar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlacar2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar2.Location = new System.Drawing.Point(468, 481);
            this.lblPlacar2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlacar2.Name = "lblPlacar2";
            this.lblPlacar2.Size = new System.Drawing.Size(84, 63);
            this.lblPlacar2.TabIndex = 5;
            this.lblPlacar2.Text = "0";
            this.lblPlacar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador2.Location = new System.Drawing.Point(451, 166);
            this.lblJogador2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(108, 28);
            this.lblJogador2.TabIndex = 4;
            this.lblJogador2.Text = "Jogador 2";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.AutoSize = true;
            this.btnReiniciar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(711, 249);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(115, 41);
            this.btnReiniciar.TabIndex = 6;
            this.btnReiniciar.Text = "&Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.AutoSize = true;
            this.btnJogar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(711, 297);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(115, 41);
            this.btnJogar.TabIndex = 7;
            this.btnJogar.Text = "&Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(711, 345);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 41);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picJogador2
            // 
            this.picJogador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picJogador2.Location = new System.Drawing.Point(373, 219);
            this.picJogador2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picJogador2.Name = "picJogador2";
            this.picJogador2.Size = new System.Drawing.Size(266, 246);
            this.picJogador2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJogador2.TabIndex = 3;
            this.picJogador2.TabStop = false;
            // 
            // picJogador1
            // 
            this.picJogador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picJogador1.Location = new System.Drawing.Point(57, 219);
            this.picJogador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picJogador1.Name = "picJogador1";
            this.picJogador1.Size = new System.Drawing.Size(266, 246);
            this.picJogador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJogador1.TabIndex = 0;
            this.picJogador1.TabStop = false;
            // 
            // picJog1
            // 
            this.picJog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picJog1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picJog1.Location = new System.Drawing.Point(136, 47);
            this.picJog1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picJog1.Name = "picJog1";
            this.picJog1.Size = new System.Drawing.Size(100, 116);
            this.picJog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJog1.TabIndex = 10;
            this.picJog1.TabStop = false;
            // 
            // picJog2
            // 
            this.picJog2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picJog2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picJog2.Location = new System.Drawing.Point(455, 47);
            this.picJog2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picJog2.Name = "picJog2";
            this.picJog2.Size = new System.Drawing.Size(100, 116);
            this.picJog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJog2.TabIndex = 11;
            this.picJog2.TabStop = false;
            // 
            // frmJogoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 554);
            this.Controls.Add(this.picJog2);
            this.Controls.Add(this.picJog1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblPlacar2);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.picJogador2);
            this.Controls.Add(this.lblPlacar1);
            this.Controls.Add(this.lblJogador1);
            this.Controls.Add(this.picJogador1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmJogoDados";
            this.Text = "Jogo de Dados CTI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmJogoDados_FormClosing);
            this.Load += new System.EventHandler(this.frmJogoDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picJogador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picJogador1;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblPlacar1;
        private System.Windows.Forms.Label lblPlacar2;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.PictureBox picJogador2;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer tmrAnimacaoDado;
        private System.Windows.Forms.PictureBox picJog1;
        private System.Windows.Forms.PictureBox picJog2;
    }
}