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
            this.picJogador1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlacar1 = new System.Windows.Forms.Label();
            this.lblPlacar2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picJogador2 = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tmrAnimacaoDado = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picJogador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador2)).BeginInit();
            this.SuspendLayout();
            // 
            // picJogador1
            // 
            this.picJogador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picJogador1.Location = new System.Drawing.Point(55, 69);
            this.picJogador1.Name = "picJogador1";
            this.picJogador1.Size = new System.Drawing.Size(200, 200);
            this.picJogador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJogador1.TabIndex = 0;
            this.picJogador1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jogador 1";
            // 
            // lblPlacar1
            // 
            this.lblPlacar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlacar1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar1.Location = new System.Drawing.Point(126, 282);
            this.lblPlacar1.Name = "lblPlacar1";
            this.lblPlacar1.Size = new System.Drawing.Size(63, 51);
            this.lblPlacar1.TabIndex = 2;
            this.lblPlacar1.Text = "4";
            this.lblPlacar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlacar2
            // 
            this.lblPlacar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlacar2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar2.Location = new System.Drawing.Point(388, 282);
            this.lblPlacar2.Name = "lblPlacar2";
            this.lblPlacar2.Size = new System.Drawing.Size(63, 51);
            this.lblPlacar2.TabIndex = 5;
            this.lblPlacar2.Text = "4";
            this.lblPlacar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jogador 2";
            // 
            // picJogador2
            // 
            this.picJogador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picJogador2.Location = new System.Drawing.Point(317, 69);
            this.picJogador2.Name = "picJogador2";
            this.picJogador2.Size = new System.Drawing.Size(200, 200);
            this.picJogador2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJogador2.TabIndex = 3;
            this.picJogador2.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.AutoSize = true;
            this.btnReiniciar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(111, 376);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(86, 33);
            this.btnReiniciar.TabIndex = 6;
            this.btnReiniciar.Text = "&Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            this.btnJogar.AutoSize = true;
            this.btnJogar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(249, 376);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 33);
            this.btnJogar.TabIndex = 7;
            this.btnJogar.Text = "&Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(379, 376);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 33);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmJogoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblPlacar2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picJogador2);
            this.Controls.Add(this.lblPlacar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picJogador1);
            this.Name = "frmJogoDados";
            this.Text = "Jogo de Dados CTI";
            ((System.ComponentModel.ISupportInitialize)(this.picJogador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picJogador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlacar1;
        private System.Windows.Forms.Label lblPlacar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picJogador2;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer tmrAnimacaoDado;
    }
}