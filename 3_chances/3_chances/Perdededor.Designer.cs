namespace _3_chances
{
    partial class Frm_Perdededor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Perdededor));
            this.lblMaiorPontuador = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_dica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaiorPontuador
            // 
            this.lblMaiorPontuador.AutoSize = true;
            this.lblMaiorPontuador.BackColor = System.Drawing.Color.Transparent;
            this.lblMaiorPontuador.Font = new System.Drawing.Font("Showcard Gothic", 50.25F);
            this.lblMaiorPontuador.ForeColor = System.Drawing.Color.Red;
            this.lblMaiorPontuador.Location = new System.Drawing.Point(168, 379);
            this.lblMaiorPontuador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaiorPontuador.Name = "lblMaiorPontuador";
            this.lblMaiorPontuador.Size = new System.Drawing.Size(294, 83);
            this.lblMaiorPontuador.TabIndex = 255;
            this.lblMaiorPontuador.Text = "Perdeu";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::_3_chances.Properties.Resources.sangue;
            this.pictureBox3.Location = new System.Drawing.Point(11, 398);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 152);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 256;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::_3_chances.Properties.Resources.coracaoPartido1;
            this.pictureBox1.Location = new System.Drawing.Point(45, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 253;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::_3_chances.Properties.Resources.tubarao_de_boas;
            this.pictureBox2.Location = new System.Drawing.Point(173, 74);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(386, 284);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 254;
            this.pictureBox2.TabStop = false;
            // 
            // btn_dica
            // 
            this.btn_dica.BackColor = System.Drawing.Color.Blue;
            this.btn_dica.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dica.ForeColor = System.Drawing.Color.White;
            this.btn_dica.Location = new System.Drawing.Point(224, 474);
            this.btn_dica.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dica.Name = "btn_dica";
            this.btn_dica.Size = new System.Drawing.Size(169, 64);
            this.btn_dica.TabIndex = 257;
            this.btn_dica.Text = "Desistir";
            this.btn_dica.UseVisualStyleBackColor = false;
            this.btn_dica.Click += new System.EventHandler(this.Btn_dica_Click);
            // 
            // Frm_Perdededor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btn_dica);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblMaiorPontuador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Perdededor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perdedor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblMaiorPontuador;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_dica;
    }
}