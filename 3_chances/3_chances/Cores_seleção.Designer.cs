namespace _3_chances
{
    partial class frm_Cores_seleção
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cores_seleção));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btn_cores_dificil = new System.Windows.Forms.Button();
            this.btn_cores_medio = new System.Windows.Forms.Button();
            this.btn_cores_facil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_gerarP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nada = new System.Windows.Forms.Label();
            this.lblMaiorPontuacao3 = new System.Windows.Forms.Label();
            this.lblMaiorPontuador3 = new System.Windows.Forms.Label();
            this.lblMaiorPontuacao2 = new System.Windows.Forms.Label();
            this.lblMaiorPontuador2 = new System.Windows.Forms.Label();
            this.lblMaiorPontuacao = new System.Windows.Forms.Label();
            this.lblMaiorPontuador = new System.Windows.Forms.Label();
            this.txtPontos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 119);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cores";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnFechar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(146, 358);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(92, 35);
            this.btnFechar.TabIndex = 29;
            this.btnFechar.Text = "Voltar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btn_cores_dificil
            // 
            this.btn_cores_dificil.BackColor = System.Drawing.Color.Navy;
            this.btn_cores_dificil.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cores_dificil.ForeColor = System.Drawing.Color.White;
            this.btn_cores_dificil.Location = new System.Drawing.Point(78, 280);
            this.btn_cores_dificil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cores_dificil.Name = "btn_cores_dificil";
            this.btn_cores_dificil.Size = new System.Drawing.Size(225, 49);
            this.btn_cores_dificil.TabIndex = 28;
            this.btn_cores_dificil.Text = "3 chances";
            this.btn_cores_dificil.UseVisualStyleBackColor = false;
            this.btn_cores_dificil.Click += new System.EventHandler(this.btn_cores_dificil_Click);
            // 
            // btn_cores_medio
            // 
            this.btn_cores_medio.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_cores_medio.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cores_medio.ForeColor = System.Drawing.Color.White;
            this.btn_cores_medio.Location = new System.Drawing.Point(78, 215);
            this.btn_cores_medio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cores_medio.Name = "btn_cores_medio";
            this.btn_cores_medio.Size = new System.Drawing.Size(225, 49);
            this.btn_cores_medio.TabIndex = 27;
            this.btn_cores_medio.Text = "4 chances";
            this.btn_cores_medio.UseVisualStyleBackColor = false;
            this.btn_cores_medio.Click += new System.EventHandler(this.btn_cores_medio_Click);
            // 
            // btn_cores_facil
            // 
            this.btn_cores_facil.BackColor = System.Drawing.Color.Blue;
            this.btn_cores_facil.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cores_facil.ForeColor = System.Drawing.Color.White;
            this.btn_cores_facil.Location = new System.Drawing.Point(78, 154);
            this.btn_cores_facil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cores_facil.Name = "btn_cores_facil";
            this.btn_cores_facil.Size = new System.Drawing.Size(225, 49);
            this.btn_cores_facil.TabIndex = 26;
            this.btn_cores_facil.Text = "5 chances";
            this.btn_cores_facil.UseVisualStyleBackColor = false;
            this.btn_cores_facil.Click += new System.EventHandler(this.btn_cores_facil_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::_3_chances.Properties.Resources.Cores;
            this.pictureBox2.Location = new System.Drawing.Point(518, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 255;
            this.pictureBox2.TabStop = false;
            // 
            // btn_gerarP
            // 
            this.btn_gerarP.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_gerarP.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerarP.ForeColor = System.Drawing.Color.White;
            this.btn_gerarP.Location = new System.Drawing.Point(395, 373);
            this.btn_gerarP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_gerarP.Name = "btn_gerarP";
            this.btn_gerarP.Size = new System.Drawing.Size(278, 35);
            this.btn_gerarP.TabIndex = 261;
            this.btn_gerarP.Text = "Gerar pontuação";
            this.btn_gerarP.UseVisualStyleBackColor = false;
            this.btn_gerarP.Click += new System.EventHandler(this.btn_gerarP_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPontos);
            this.groupBox1.Controls.Add(this.lbl_nada);
            this.groupBox1.Controls.Add(this.lblMaiorPontuacao3);
            this.groupBox1.Controls.Add(this.lblMaiorPontuador3);
            this.groupBox1.Controls.Add(this.lblMaiorPontuacao2);
            this.groupBox1.Controls.Add(this.lblMaiorPontuador2);
            this.groupBox1.Controls.Add(this.lblMaiorPontuacao);
            this.groupBox1.Controls.Add(this.lblMaiorPontuador);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(378, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(314, 226);
            this.groupBox1.TabIndex = 267;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Placar";
            // 
            // lbl_nada
            // 
            this.lbl_nada.AutoSize = true;
            this.lbl_nada.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nada.Font = new System.Drawing.Font("Showcard Gothic", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nada.ForeColor = System.Drawing.Color.Blue;
            this.lbl_nada.Location = new System.Drawing.Point(194, 225);
            this.lbl_nada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nada.Name = "lbl_nada";
            this.lbl_nada.Size = new System.Drawing.Size(0, 38);
            this.lbl_nada.TabIndex = 260;
            // 
            // lblMaiorPontuacao3
            // 
            this.lblMaiorPontuacao3.AutoSize = true;
            this.lblMaiorPontuacao3.BackColor = System.Drawing.Color.Transparent;
            this.lblMaiorPontuacao3.Font = new System.Drawing.Font("Showcard Gothic", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaiorPontuacao3.ForeColor = System.Drawing.Color.Blue;
            this.lblMaiorPontuacao3.Location = new System.Drawing.Point(230, 169);
            this.lblMaiorPontuacao3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaiorPontuacao3.Name = "lblMaiorPontuacao3";
            this.lblMaiorPontuacao3.Size = new System.Drawing.Size(62, 38);
            this.lblMaiorPontuacao3.TabIndex = 25;
            this.lblMaiorPontuacao3.Text = "???";
            // 
            // lblMaiorPontuador3
            // 
            this.lblMaiorPontuador3.AutoSize = true;
            this.lblMaiorPontuador3.BackColor = System.Drawing.Color.Transparent;
            this.lblMaiorPontuador3.Font = new System.Drawing.Font("Showcard Gothic", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaiorPontuador3.ForeColor = System.Drawing.Color.Blue;
            this.lblMaiorPontuador3.Location = new System.Drawing.Point(18, 169);
            this.lblMaiorPontuador3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaiorPontuador3.Name = "lblMaiorPontuador3";
            this.lblMaiorPontuador3.Size = new System.Drawing.Size(174, 38);
            this.lblMaiorPontuador3.TabIndex = 24;
            this.lblMaiorPontuador3.Text = "Jogador3";
            // 
            // lblMaiorPontuacao2
            // 
            this.lblMaiorPontuacao2.AutoSize = true;
            this.lblMaiorPontuacao2.BackColor = System.Drawing.Color.Transparent;
            this.lblMaiorPontuacao2.Font = new System.Drawing.Font("Showcard Gothic", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaiorPontuacao2.ForeColor = System.Drawing.Color.Blue;
            this.lblMaiorPontuacao2.Location = new System.Drawing.Point(230, 114);
            this.lblMaiorPontuacao2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaiorPontuacao2.Name = "lblMaiorPontuacao2";
            this.lblMaiorPontuacao2.Size = new System.Drawing.Size(62, 38);
            this.lblMaiorPontuacao2.TabIndex = 23;
            this.lblMaiorPontuacao2.Text = "???";
            // 
            // lblMaiorPontuador2
            // 
            this.lblMaiorPontuador2.AutoSize = true;
            this.lblMaiorPontuador2.BackColor = System.Drawing.Color.Transparent;
            this.lblMaiorPontuador2.Font = new System.Drawing.Font("Showcard Gothic", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaiorPontuador2.ForeColor = System.Drawing.Color.Blue;
            this.lblMaiorPontuador2.Location = new System.Drawing.Point(18, 114);
            this.lblMaiorPontuador2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaiorPontuador2.Name = "lblMaiorPontuador2";
            this.lblMaiorPontuador2.Size = new System.Drawing.Size(173, 38);
            this.lblMaiorPontuador2.TabIndex = 22;
            this.lblMaiorPontuador2.Text = "Jogador2";
            // 
            // lblMaiorPontuacao
            // 
            this.lblMaiorPontuacao.AutoSize = true;
            this.lblMaiorPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lblMaiorPontuacao.Font = new System.Drawing.Font("Showcard Gothic", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaiorPontuacao.ForeColor = System.Drawing.Color.Blue;
            this.lblMaiorPontuacao.Location = new System.Drawing.Point(230, 58);
            this.lblMaiorPontuacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaiorPontuacao.Name = "lblMaiorPontuacao";
            this.lblMaiorPontuacao.Size = new System.Drawing.Size(62, 38);
            this.lblMaiorPontuacao.TabIndex = 21;
            this.lblMaiorPontuacao.Text = "???";
            // 
            // lblMaiorPontuador
            // 
            this.lblMaiorPontuador.AutoSize = true;
            this.lblMaiorPontuador.BackColor = System.Drawing.Color.Transparent;
            this.lblMaiorPontuador.Font = new System.Drawing.Font("Showcard Gothic", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaiorPontuador.ForeColor = System.Drawing.Color.Blue;
            this.lblMaiorPontuador.Location = new System.Drawing.Point(18, 58);
            this.lblMaiorPontuador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaiorPontuador.Name = "lblMaiorPontuador";
            this.lblMaiorPontuador.Size = new System.Drawing.Size(172, 38);
            this.lblMaiorPontuador.TabIndex = 18;
            this.lblMaiorPontuador.Text = "Jogador1";
            // 
            // txtPontos
            // 
            this.txtPontos.Location = new System.Drawing.Point(114, 226);
            this.txtPontos.Name = "txtPontos";
            this.txtPontos.Size = new System.Drawing.Size(100, 47);
            this.txtPontos.TabIndex = 269;
            // 
            // frm_Cores_seleção
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(729, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_gerarP);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btn_cores_dificil);
            this.Controls.Add(this.btn_cores_medio);
            this.Controls.Add(this.btn_cores_facil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Cores_seleção";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cores - Seleção";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btn_cores_dificil;
        private System.Windows.Forms.Button btn_cores_medio;
        private System.Windows.Forms.Button btn_cores_facil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_gerarP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nada;
        private System.Windows.Forms.Label lblMaiorPontuacao3;
        private System.Windows.Forms.Label lblMaiorPontuador3;
        private System.Windows.Forms.Label lblMaiorPontuacao2;
        private System.Windows.Forms.Label lblMaiorPontuador2;
        private System.Windows.Forms.Label lblMaiorPontuacao;
        private System.Windows.Forms.Label lblMaiorPontuador;
        private System.Windows.Forms.TextBox txtPontos;
    }
}