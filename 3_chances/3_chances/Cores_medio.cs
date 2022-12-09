﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_chances
{
    public partial class frm_Cores_Medio : Form
    {
        private static List<Keys> Characters = new List<Keys>() { Keys.A, Keys.B, Keys.C, Keys.D, Keys.E, Keys.F, Keys.G, Keys.H, Keys.I, Keys.J, Keys.K, Keys.L, Keys.M, Keys.N, Keys.O, Keys.P, Keys.Q, Keys.R, Keys.S, Keys.T, Keys.U, Keys.V, Keys.W, Keys.X, Keys.Y, Keys.Z };

        public frm_Cores_Medio(Form corFundo, string pontuacao)
        {
            InitializeComponent();
            this.BackColor = corFundo.BackColor;
            txtPontuacaoM.Text = pontuacao;
        }

        private void ChangeFocus(int number)
        {
            switch (number)
            {
                case 1:
                    txt1.Focus();
                    break;
                case 2:
                    txt2.Focus();
                    break;
                case 3:
                    txt3.Focus();
                    break;
                case 4:
                    txt4.Focus();
                    break;
                case 5:
                    txt5.Focus();
                    break;
                case 6:
                    txt6.Focus();
                    break;
                case 7:
                    txt7.Focus();
                    break;
                case 8:
                    txt8.Focus();
                    break;
                default:
                    break;
            }
        }

        private void btn_dica_Click(object sender, EventArgs e)
        {
            lbl_dicas.Text = "Dica: Cor primária";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            if (txt1.Enabled == true)
            {
                txt1.Text = "";
                txt1.BackColor = Color.Empty;
            }
            if (txt2.Enabled == true)
            {
                txt2.Text = "";
                txt2.BackColor = Color.Empty;
            }
            if (txt3.Enabled == true)
            {
                txt3.Text = "";
                txt3.BackColor = Color.Empty;
            }
            if (txt4.Enabled == true)
            {
                txt4.Text = "";
                txt4.BackColor = Color.Empty;
            }
            if (txt5.Enabled == true)
            {
                txt5.Text = "";
                txt5.BackColor = Color.Empty;
            }
            if (txt6.Enabled == true)
            {
                txt6.Text = "";
                txt6.BackColor = Color.Empty;
            }

            if (txt7.Enabled == true)
            {
                txt7.Text = "";
                txt7.BackColor = Color.Empty;
            }

            if (txt8.Enabled == true)
            {
                txt8.Text = "";
                txt8.BackColor = Color.Empty;
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string l1, l2, l3, l4, l5, l6, l7, l8;

            l1 = Convert.ToString(txt1.Text);
            l2 = Convert.ToString(txt2.Text);
            l3 = Convert.ToString(txt3.Text);
            l4 = Convert.ToString(txt4.Text);
            l5 = Convert.ToString(txt5.Text);
            l6 = Convert.ToString(txt6.Text);
            l7 = Convert.ToString(txt7.Text);
            l8 = Convert.ToString(txt8.Text);

            //Primeiro
            if (l1 == "V")
            {
                txt1.BackColor = Color.Green;
                txt1.Enabled = false;
            }

            else if (l1 == "E" || l1 == "R" || l1 == "M" || l1 == "L" || l1 == "H" || l1 == "O")
            {
                txt_Letras_existentes.Text += l1 + " ";
                txt1.BackColor = Color.Red;
                txt1.Text = "";
            }

            else if (String.IsNullOrEmpty(txt1.Text))
            {
                txt1.BackColor = Color.Red;
                txt1.Text = "";
            }

            else
            {
                txt1.BackColor = Color.Red;
                txt1.Text = "";
                txt_erros.Text += l1 + " ";
            }


            //Segundo
            if (l2 == "E")
            {
                txt2.BackColor = Color.Green;
                txt2.Enabled = false;
            }

            else if (l2 == "V" || l2 == "R" || l2 == "M" || l2 == "L" || l2 == "H" || l2 == "O")
            {
                txt_Letras_existentes.Text += l2 + " ";
                txt2.BackColor = Color.Red;
                txt2.Text = "";
            }

            else if (String.IsNullOrEmpty(txt2.Text))
            {
                txt2.BackColor = Color.Red;
                txt2.Text = "";
            }

            else
            {
                txt2.BackColor = Color.Red;
                txt2.Text = "";
                txt_erros.Text += l2 + " ";
            }

            //Terceiro
            if (l3 == "R")
            {
                txt3.BackColor = Color.Green;
                txt3.Enabled = false;
            }

            else if (l3 == "E" || l3 == "V" || l3 == "M" || l3 == "L" || l3 == "H" || l3 == "O")
            {
                txt_Letras_existentes.Text += l3 + " ";
                txt3.BackColor = Color.Red;
                txt3.Text = "";
            }

            else if (String.IsNullOrEmpty(txt3.Text))
            {
                txt3.BackColor = Color.Red;
            }

            else
            {
                txt3.BackColor = Color.Red;
                txt3.Text = "";
                txt_erros.Text += l3 + " ";
            }

            //Quarto
            if (l4 == "M")
            {
                txt4.BackColor = Color.Green;
                txt4.Enabled = false;
            }

            else if (l4 == "E" || l4 == "R" || l4 == "V" || l4 == "L" || l4 == "H" || l4 == "O")
            {
                txt_Letras_existentes.Text += l4 + " ";
                txt4.BackColor = Color.Red;
                txt4.Text = "";
            }

            else if (String.IsNullOrEmpty(txt1.Text))
            {
                txt4.BackColor = Color.Red;
            }

            else
            {
                txt4.BackColor = Color.Red;
                txt4.Text = "";
                txt_erros.Text += l4 + " ";
            }

            //Quinto
            if (l5 == "E")
            {
                txt5.BackColor = Color.Green;
                txt5.Enabled = false;
            }

            else if (l5 == "V" || l5 == "R" || l5 == "M" || l5 == "L" || l5 == "H" || l5 == "O")
            {
                txt_Letras_existentes.Text += l5 + " ";
                txt5.BackColor = Color.Red;
                txt5.Text = "";
            }

            else if (String.IsNullOrEmpty(txt5.Text))
            {
                txt5.BackColor = Color.Red;
            }

            else
            {
                txt5.BackColor = Color.Red;
                txt5.Text = "";
                txt_erros.Text += l5 + " ";
            }

            //Sexto
            if (l6 == "L")
            {
                txt6.BackColor = Color.Green;
                txt6.Enabled = false;
            }

            else if (l6 == "E" || l6 == "R" || l6 == "M" || l6 == "V" || l6 == "H" || l6 == "O")
            {
                txt_Letras_existentes.Text += l6 + " ";
                txt6.BackColor = Color.Red;
                txt6.Text = "";
            }

            else if (String.IsNullOrEmpty(txt6.Text))
            {
                txt6.BackColor = Color.Red;
                txt6.Text = "";
            }

            else
            {
                txt6.BackColor = Color.Red;
                txt6.Text = "";
                txt_erros.Text += l6 + " ";
            }

            //Sétimo
            if (l7 == "H")
            {
                txt6.BackColor = Color.Green;
                txt6.Enabled = false;
            }

            else if (l7 == "E" || l7 == "R" || l7 == "M" || l7 == "L" || l7 == "V" || l7 == "O")
            {
                txt_Letras_existentes.Text += l7 + " ";
                txt7.BackColor = Color.Red;
                txt7.Text = "";
            }

            else if (String.IsNullOrEmpty(txt6.Text))
            {
                txt7.BackColor = Color.Red;
                txt7.Text = "";
            }

            else
            {
                txt7.BackColor = Color.Red;
                txt7.Text = "";
                txt_erros.Text += l7 + " ";
            }

            //Oitávo
            if (l8 == "O")
            {
                txt8.BackColor = Color.Green;
                txt8.Enabled = false;
            }

            else if (l8 == "E" || l8 == "R" || l8 == "M" || l8 == "L" || l8 == "H" || l8 == "V")
            {
                txt_Letras_existentes.Text += l6 + " ";
                txt8.BackColor = Color.Red;
                txt8.Text = "";
            }

            else if (String.IsNullOrEmpty(txt8.Text))
            {
                txt8.BackColor = Color.Red;
                txt8.Text = "";
            }

            else
            {
                txt8.BackColor = Color.Red;
                txt8.Text = "";
                txt_erros.Text += l8 + " ";
            }


            if (l1 == "V" && l2 == "E" && l3 == "R" && l4 == "M" && l5 == "E" && l6 == "L" && l7 == "H" && l8 == "O")
            {
                btn_Avancar.Visible = true;
            }

            else if (pic_coracao4.Visible == true)
            {
                pic_coracao4.Visible = false;
            }

            else if (pic_coracao3.Visible == true)
            {
                pic_coracao3.Visible = false;
            }

            else if (pic_coracao2.Visible == true)
            {
                pic_coracao2.Visible = false;
            }

            else
            {
                pic_coracao1.Visible = false;
                this.Close();
            }
        }

        private void btn_desistir_selecao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Avancar_Click(object sender, EventArgs e)
        {
            int pontuacao;

            if (pic_coracao4.Visible == true)
            {
                pontuacao = Int32.Parse(txtPontuacaoM.Text);
                pontuacao += 8;
                txtPontuacaoM.Text = Convert.ToString(pontuacao);
            }

            else if (pic_coracao3.Visible == true)
            {
                pontuacao = Int32.Parse(txtPontuacaoM.Text);
                pontuacao += 6;
                txtPontuacaoM.Text = Convert.ToString(pontuacao);
            }

            else if (pic_coracao2.Visible == true)
            {
                pontuacao = Int32.Parse(txtPontuacaoM.Text);
                pontuacao += 4;
                txtPontuacaoM.Text = Convert.ToString(pontuacao);
            }

            else if (pic_coracao1.Visible == true)
            {
                pontuacao = Int32.Parse(txtPontuacaoM.Text);
                pontuacao += 2;
                txtPontuacaoM.Text = Convert.ToString(pontuacao);
            }

            frm_Cores_Dificil frm_comidas_Dificil = new frm_Cores_Dificil(this, txtPontuacaoM.Text);
            this.Hide();
            frm_comidas_Dificil.ShowDialog();
        }
        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(2);
            }
            else if (e.KeyCode == Keys.Back)
            {

            }
        }

        private void txt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(3);
            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(1);
            }
        }

        private void txt3_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(4);
            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(2);
            }
        }

        private void txt4_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(5);
            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(3);
            }
        }

        private void txt5_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(6);
            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(4);
            }
        }

        private void txt6_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(7);

            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(5);
            }
        }

        private void txt7_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(8);
            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(6);
            }
        }

        private void txt8_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {

            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(7);
            }
        }
    }
}