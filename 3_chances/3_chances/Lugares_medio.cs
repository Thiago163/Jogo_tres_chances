using System;
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
    public partial class frm_Lugares_Medio : Form
    {
        private static List<Keys> Characters = new List<Keys>() { Keys.A, Keys.B, Keys.C, Keys.D, Keys.E, Keys.F, Keys.G, Keys.H, Keys.I, Keys.J, Keys.K, Keys.L, Keys.M, Keys.N, Keys.O, Keys.P, Keys.Q, Keys.R, Keys.S, Keys.T, Keys.U, Keys.V, Keys.W, Keys.X, Keys.Y, Keys.Z };

        public frm_Lugares_Medio(Form corFundo, string pontuacao)
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
                case 9:
                    txt9.Focus();
                    break;
                case 10:
                    txt10.Focus();
                    break;
                case 11:
                    txt11.Focus();
                    break;
                case 12:
                    txt12.Focus();
                    break;
                default:
                    break;
            }
        }

        private void btn_dica_Click(object sender, EventArgs e)
        {
            lbl_dicas.Text = "Dica: Biblia";
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
            if (txt9.Enabled == true)
            {
                txt9.Text = "";
                txt9.BackColor = Color.Empty;
            }
            if (txt10.Enabled == true)
            {
                txt10.Text = "";
                txt10.BackColor = Color.Empty;
            }
            if (txt11.Enabled == true)
            {
                txt11.Text = "";
                txt11.BackColor = Color.Empty;
            }
            if (txt12.Enabled == true)
            {
                txt12.Text = "";
                txt12.BackColor = Color.Empty;
            }
        }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12;

            l1 = Convert.ToString(txt1.Text);
            l2 = Convert.ToString(txt2.Text);
            l3 = Convert.ToString(txt3.Text);
            l4 = Convert.ToString(txt4.Text);
            l5 = Convert.ToString(txt5.Text);
            l6 = Convert.ToString(txt6.Text);
            l7 = Convert.ToString(txt7.Text);
            l8 = Convert.ToString(txt8.Text);
            l9 = Convert.ToString(txt9.Text);
            l10 = Convert.ToString(txt10.Text);
            l11 = Convert.ToString(txt11.Text);
            l12 = Convert.ToString(txt12.Text);

            //Primeiro
            if (l1 == "R")
            {
                txt1.BackColor = Color.Green;
                txt1.Enabled = false;
            }

            else if (l1 == "I" || l1 == "O" || l1 == "D" || l1 == "E" || l1 == "J" || l1 == "A" || l1 == "N")
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


            //___________________________________________________________________________________________________________________________________
            //___________________________________________________________________________________________________________________________________



            //Segundo
            if (l2 == "I")
            {
                txt2.BackColor = Color.Green;
                txt2.Enabled = false;
            }

            else if (l2 == "R" || l2 == "O" || l2 == "D" || l2 == "E" || l2 == "J" || l2 == "A" || l2 == "N")
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



            // ___________________________________________________________________________________________________________________________________
            // ___________________________________________________________________________________________________________________________________



            //Terceiro
            if (l3 == "O")
            {
                txt3.BackColor = Color.Green;
                txt3.Enabled = false;
            }

            else if (l3 == "R" || l3 == "I" || l3 == "D" || l3 == "E" || l3 == "J" || l3 == "A" || l3 == "N")
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



            // ___________________________________________________________________________________________________________________________________
            // ___________________________________________________________________________________________________________________________________



            //Quarto
            if (l4 == "D")
            {
                txt4.BackColor = Color.Green;
                txt4.Enabled = false;
            }

            else if (l4 == "R" || l4 == "I" || l4 == "O" || l4 == "E" || l4 == "J" || l4 == "A" || l4 == "N")
            {
                txt_Letras_existentes.Text += l4 + " ";
                txt4.BackColor = Color.Red;
                txt4.Text = "";
            }

            else if (String.IsNullOrEmpty(txt4.Text))
            {
                txt4.BackColor = Color.Red;
            }

            else
            {
                txt4.BackColor = Color.Red;
                txt4.Text = "";
                txt_erros.Text += l4 + " ";
            }



            // ___________________________________________________________________________________________________________________________________
            // ___________________________________________________________________________________________________________________________________

            //Quinto
            if (l5 == "E")
            {
                txt5.BackColor = Color.Green;
                txt5.Enabled = false;
            }

            else if (l5 == "R" || l5 == "I" || l5 == "O" || l5 == "D" || l5 == "J" || l5 == "A" || l5 == "N")
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



            // ___________________________________________________________________________________________________________________________________
            // ___________________________________________________________________________________________________________________________________



            //Sexto
            if (l6 == "J")
            {
                txt6.BackColor = Color.Green;
                txt6.Enabled = false;
            }

            else if (l6 == "R" || l6 == "I" || l6 == "O" || l6 == "D" || l6 == "E" || l6 == "A" || l6 == "N")
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



            // ___________________________________________________________________________________________________________________________________
            // ___________________________________________________________________________________________________________________________________

            //Sétimo
            if (l7 == "A")
            {
                txt7.BackColor = Color.Green;
                txt7.Enabled = false;
            }

            else if (l7 == "R" || l7 == "I" || l7 == "O" || l7 == "D" || l7 == "E" || l7 == "J" || l7 == "N")
            {
                txt_Letras_existentes.Text += l7 + " ";
                txt7.BackColor = Color.Red;
                txt7.Text = "";
            }

            else if (String.IsNullOrEmpty(txt7.Text))
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



            // ___________________________________________________________________________________________________________________________________
            // ___________________________________________________________________________________________________________________________________

            //Oitávo
            if (l8 == "N")
            {
                txt8.BackColor = Color.Green;
                txt8.Enabled = false;
            }

            else if (l8 == "R" || l8 == "I" || l8 == "O" || l8 == "D" || l8 == "E" || l8 == "J" || l8 == "A")
            {
                txt_Letras_existentes.Text += l8 + " ";
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



            // ___________________________________________________________________________________________________________________________________
            // ___________________________________________________________________________________________________________________________________

            //Nono
            if (l9 == "E")
            {
                txt8.BackColor = Color.Green;
                txt8.Enabled = false;
            }

            else if (l9 == "R" || l9 == "I" || l9 == "O" || l9 == "D" || l9 == "J" || l9 == "A" || l9 == "N")
            {
                txt_Letras_existentes.Text += l9 + " ";
                txt9.BackColor = Color.Red;
                txt9.Text = "";
            }

            else if (String.IsNullOrEmpty(txt9.Text))
            {
                txt9.BackColor = Color.Red;
                txt9.Text = "";
            }

            else
            {
                txt9.BackColor = Color.Red;
                txt9.Text = "";
                txt_erros.Text += l9 + " ";
            }



            // ___________________________________________________________________________________________________________________________________
            // ___________________________________________________________________________________________________________________________________

            //Décimo
            if (l10 == "I")
            {
                txt9.BackColor = Color.Green;
                txt9.Enabled = false;
            }

            else if (l10 == "R" || l10 == "O" || l10 == "D" || l10 == "E" || l10 == "J" || l10 == "A" || l10 == "N")
            {
                txt_Letras_existentes.Text += l10 + " ";
                txt10.BackColor = Color.Red;
                txt10.Text = "";
            }

            else if (String.IsNullOrEmpty(txt10.Text))
            {
                txt10.BackColor = Color.Red;
                txt10.Text = "";
            }

            else
            {
                txt10.BackColor = Color.Red;
                txt10.Text = "";
                txt_erros.Text += l10 + " ";
            }



            // ___________________________________________________________________________________________________________________________________
            // ___________________________________________________________________________________________________________________________________

            //Décimo Primeiro
            if (l11 == "R")
            {
                txt11.BackColor = Color.Green;
                txt11.Enabled = false;
            }

            else if (l11 == "I" || l11 == "O" || l11 == "D" || l11 == "E" || l11 == "J" || l11 == "A" || l11 == "N")
            {
                txt_Letras_existentes.Text += l11 + " ";
                txt11.BackColor = Color.Red;
                txt11.Text = "";
            }

            else if (String.IsNullOrEmpty(txt11.Text))
            {
                txt11.BackColor = Color.Red;
                txt11.Text = "";
            }

            else
            {
                txt11.BackColor = Color.Red;
                txt11.Text = "";
                txt_erros.Text += l11 + " ";
            }



            // ___________________________________________________________________________________________________________________________________
            // ___________________________________________________________________________________________________________________________________

            //Décimo Segundo
            if (l12 == "O")
            {
                txt12.BackColor = Color.Green;
                txt12.Enabled = false;
            }

            else if (l12 == "R" || l12 == "I" || l12 == "D" || l12 == "E" || l12 == "J" || l12 == "A" || l12 == "N")
            {
                txt_Letras_existentes.Text += l12 + " ";
                txt12.BackColor = Color.Red;
                txt12.Text = "";
            }

            else if (String.IsNullOrEmpty(txt12.Text))
            {
                txt12.BackColor = Color.Red;
                txt12.Text = "";
            }

            else
            {
                txt12.BackColor = Color.Red;
                txt12.Text = "";
                txt_erros.Text += l12 + " ";
            }

            // ___________________________________________________________________________________________________________________________________
            // ___________________________________________________________________________________________________________________________________


            if (l1 == "R" && l2 == "I" && l3 == "O" && l4 == "D" && l5 == "E" && l6 == "J" && l7 == "A" && l8 == "N" && l9 == "E" && l10 == "I" && l11 == "R" && l12 == "O")
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

        private void Btn_Avancar_Click(object sender, EventArgs e)
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

            frm_Lugares_Dificil frm_comidas_Dificil = new frm_Lugares_Dificil(this, txtPontuacaoM.Text);
            this.Hide();
            frm_comidas_Dificil.ShowDialog();
        }

        private void Txt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(2);
            }
            else if (e.KeyCode == Keys.Back)
            {

            }
        }

        private void Txt2_KeyDown(object sender, KeyEventArgs e)
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

        private void Txt3_KeyDown(object sender, KeyEventArgs e)
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

        private void Txt4_KeyDown(object sender, KeyEventArgs e)
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

        private void Txt5_KeyDown(object sender, KeyEventArgs e)
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

        private void Txt6_KeyDown(object sender, KeyEventArgs e)
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

        private void Txt7_KeyDown(object sender, KeyEventArgs e)
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

        private void Txt8_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(9);
            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(7);
            }
        }

        private void Txt9_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(10);
            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(8);
            }
        }

        private void Txt10_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(11);
            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(9);
            }
        }

        private void Txt11_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(12);
            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(10);
            }
        }

        private void Txt12_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {

            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(11);
            }
        }
    }
}
