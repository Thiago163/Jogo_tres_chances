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
    public partial class frm_Comidas_facil : Form
    {
        private static List<Keys> Characters = new List<Keys>() { Keys.A, Keys.B, Keys.C, Keys.D, Keys.E, Keys.F, Keys.G, Keys.H, Keys.I, Keys.J, Keys.K, Keys.L, Keys.M, Keys.N, Keys.O, Keys.P, Keys.Q, Keys.R, Keys.S, Keys.T, Keys.U, Keys.V, Keys.W, Keys.X, Keys.Y, Keys.Z};


        public frm_Comidas_facil(Form corFundo)
        {
            InitializeComponent();
            this.BackColor = corFundo.BackColor;
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
                default:
                    break;
            }

        }

        private void btn_dica_Click(object sender, EventArgs e)
        {
            lbl_dicas.Text = "Dica: Normalmente redonda";
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
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string l1, l2, l3, l4, l5;

            l1 = Convert.ToString(txt1.Text);
            l2 = Convert.ToString(txt2.Text);
            l3 = Convert.ToString(txt3.Text);
            l4 = Convert.ToString(txt4.Text);
            l5 = Convert.ToString(txt5.Text);
            
            //Primeiro
            if (l1 == "T")
            {
                txt1.BackColor = Color.Green;
                txt1.Enabled = false;
            }

            else if (l1 == "O" || l1 == "R" || l1 == "A")
            {
                txt_Letras_existentes.Text += l1 + " ";
                txt1.BackColor = Color.Red;
                txt1.Text = "";
            }

            else if (String.IsNullOrEmpty(txt1.Text))
            {
                txt1.BackColor = Color.Red;
            }

            else
            {
                txt1.BackColor = Color.Red;
                txt1.Text = "";
                txt_erros.Text += l1 + " ";
            }


            //Segundo
            if (l2 == "O")
            {
                txt2.BackColor = Color.Green;
                txt2.Enabled = false;
            }

            else if (l2 == "T" || l2 == "R" || l2 == "A")
            {
                txt_Letras_existentes.Text += l2 + " ";
                txt2.BackColor = Color.Red;
                txt2.Text = "";
            }

            else if (String.IsNullOrEmpty(txt2.Text))
            {
                txt2.BackColor = Color.Red;
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

            else if (l3 == "O" || l3 == "T" || l3 == "A")
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
            if (l4 == "T")
            {
                txt4.BackColor = Color.Green;
                txt4.Enabled = false;
            }

            else if (l4 == "O" || l4 == "R" || l4 == "A")
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



            //Quinto
            if (l5 == "A")
            {
                txt5.BackColor = Color.Green;
                txt5.Enabled = false;
            }

            else if (l5 == "O" || l5 == "R" || l5 == "T")
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



            if (l1 == "T" && l2 == "O" && l3 == "R" && l4 == "T" && l5 == "A")
            {
                btn_Avancar.Visible = true;
            }

            else if (pic_coracao5.Visible == true)
            {
                pic_coracao5.Visible = false;
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
                Frm_Perdededor frm_Perdededor = new Frm_Perdededor();
                frm_Perdededor.Show();
            }

        }

        private void Btn_desistir_selecao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Avancar_Click(object sender, EventArgs e)
        {
            if (pic_coracao5.Visible == true)
            {
                txtPontuacaoF.Text = "5";
            }

            else if (pic_coracao4.Visible == true)
            {
                txtPontuacaoF.Text = "4";
            }

            else if (pic_coracao3.Visible == true)
            {
                txtPontuacaoF.Text = "3";
            }

            else if (pic_coracao2.Visible == true)
            {
                txtPontuacaoF.Text = "2";
            }

            else if(pic_coracao1.Visible == true)
            {
                txtPontuacaoF.Text = "1";
            }

            frm_Comidas_Medio frm_comidas_Medio = new frm_Comidas_Medio(this, txtPontuacaoF.Text);
            this.Hide();
            frm_comidas_Medio.ShowDialog();
        }


        private void Txt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Characters.Contains(e.KeyCode))
            {
                ChangeFocus(2);
            }
            else if(e.KeyCode == Keys.Back)
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

            }
            else if (e.KeyCode == Keys.Back)
            {
                ChangeFocus(4);
            }
        }
    }
}
