namespace ImagensDinamicas
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.picDado = new System.Windows.Forms.PictureBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJog1 = new System.Windows.Forms.TextBox();
            this.txtJog2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha uma opção:";
            // 
            // picDado
            // 
            this.picDado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDado.Image = global::ImagensDinamicas.Properties.Resources.dado_icon;
            this.picDado.Location = new System.Drawing.Point(433, 131);
            this.picDado.Name = "picDado";
            this.picDado.Size = new System.Drawing.Size(250, 250);
            this.picDado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDado.TabIndex = 4;
            this.picDado.TabStop = false;
            this.picDado.Click += new System.EventHandler(this.picDado_Click);
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Image = global::ImagensDinamicas.Properties.Resources.camera_icon;
            this.picFoto.Location = new System.Drawing.Point(112, 131);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(250, 250);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 3;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do Jogador 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome do Jogador 2:";
            // 
            // txtJog1
            // 
            this.txtJog1.Location = new System.Drawing.Point(230, 440);
            this.txtJog1.Name = "txtJog1";
            this.txtJog1.Size = new System.Drawing.Size(197, 20);
            this.txtJog1.TabIndex = 7;
            // 
            // txtJog2
            // 
            this.txtJog2.Location = new System.Drawing.Point(230, 474);
            this.txtJog2.Name = "txtJog2";
            this.txtJog2.Size = new System.Drawing.Size(197, 20);
            this.txtJog2.TabIndex = 8;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.txtJog2);
            this.Controls.Add(this.txtJog1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picDado);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "Imagens Dinâmicas - Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picDado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.PictureBox picDado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJog1;
        private System.Windows.Forms.TextBox txtJog2;
    }
}