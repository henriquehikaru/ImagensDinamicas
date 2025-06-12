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
            this.picJog1 = new System.Windows.Forms.PictureBox();
            this.picJog2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlacarMenu1 = new System.Windows.Forms.Label();
            this.lblPlacarMenu2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog2)).BeginInit();
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jogador 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jogador 2:";
            // 
            // txtJog1
            // 
            this.txtJog1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJog1.Location = new System.Drawing.Point(189, 485);
            this.txtJog1.Name = "txtJog1";
            this.txtJog1.Size = new System.Drawing.Size(197, 26);
            this.txtJog1.TabIndex = 7;
            // 
            // txtJog2
            // 
            this.txtJog2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJog2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJog2.Location = new System.Drawing.Point(575, 485);
            this.txtJog2.Name = "txtJog2";
            this.txtJog2.Size = new System.Drawing.Size(197, 26);
            this.txtJog2.TabIndex = 8;
            // 
            // picJog1
            // 
            this.picJog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picJog1.Location = new System.Drawing.Point(40, 487);
            this.picJog1.Name = "picJog1";
            this.picJog1.Size = new System.Drawing.Size(53, 72);
            this.picJog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJog1.TabIndex = 9;
            this.picJog1.TabStop = false;
            // 
            // picJog2
            // 
            this.picJog2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picJog2.Location = new System.Drawing.Point(423, 487);
            this.picJog2.Name = "picJog2";
            this.picJog2.Size = new System.Drawing.Size(53, 72);
            this.picJog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJog2.TabIndex = 10;
            this.picJog2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Placar 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Placar 2:";
            // 
            // lblPlacarMenu1
            // 
            this.lblPlacarMenu1.AutoSize = true;
            this.lblPlacarMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacarMenu1.Location = new System.Drawing.Point(185, 539);
            this.lblPlacarMenu1.Name = "lblPlacarMenu1";
            this.lblPlacarMenu1.Size = new System.Drawing.Size(19, 20);
            this.lblPlacarMenu1.TabIndex = 13;
            this.lblPlacarMenu1.Text = "#";
            // 
            // lblPlacarMenu2
            // 
            this.lblPlacarMenu2.AutoSize = true;
            this.lblPlacarMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacarMenu2.Location = new System.Drawing.Point(571, 539);
            this.lblPlacarMenu2.Name = "lblPlacarMenu2";
            this.lblPlacarMenu2.Size = new System.Drawing.Size(19, 20);
            this.lblPlacarMenu2.TabIndex = 14;
            this.lblPlacarMenu2.Text = "#";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.lblPlacarMenu2);
            this.Controls.Add(this.lblPlacarMenu1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picJog2);
            this.Controls.Add(this.picJog1);
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
            ((System.ComponentModel.ISupportInitialize)(this.picJog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog2)).EndInit();
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
        private System.Windows.Forms.PictureBox picJog1;
        private System.Windows.Forms.PictureBox picJog2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlacarMenu1;
        private System.Windows.Forms.Label lblPlacarMenu2;
    }
}