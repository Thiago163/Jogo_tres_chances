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
    public partial class frm_Filmes_Medio : Form
    {
        public frm_Filmes_Medio()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string l1, l2, l3, l4, l5, l6, l7, l8, l9;

            l1 = Convert.ToString(txt1.Text);
            l2 = Convert.ToString(txt2.Text);
            l3 = Convert.ToString(txt3.Text);
            l4 = Convert.ToString(txt4.Text);
            l5 = Convert.ToString(txt5.Text);
            l6 = Convert.ToString(txt6.Text);
            l7 = Convert.ToString(txt7.Text);
            l8 = Convert.ToString(txt8.Text);
            l9 = Convert.ToString(txt9.Text);

            //Primeiro
            if (l1 == "D")
            {
                txt1.BackColor = Color.Green;
                txt1.Enabled = false;
            }

            else if (l1 == "D" || l1 == "I" || l1 == "N" || l1 == "O" || l1 == "S" || l1 == "A" || l1 == "U" || l1 == "R")
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
            if (l2 == "I")
            {
                txt2.BackColor = Color.Green;
                txt2.Enabled = false;
            }

            else if (l2 == "D" || l2 == "I" || l2 == "N" || l2 == "O" || l2 == "S" || l2 == "A" || l2 == "U" || l2 == "R")
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
            if (l3 == "N")
            {
                txt3.BackColor = Color.Green;
                txt3.Enabled = false;
            }

            else if (l3 == "D" || l3 == "I" || l3 == "N" || l3 == "O" || l3 == "S" || l3 == "A" || l3 == "U" || l3 == "R")
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
            if (l4 == "O")
            {
                txt4.BackColor = Color.Green;
                txt4.Enabled = false;
            }

            else if (l4 == "D" || l4 == "I" || l4 == "N" || l4 == "O" || l4 == "S" || l4 == "A" || l4 == "U" || l4 == "R")
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
            if (l5 == "S")
            {
                txt5.BackColor = Color.Green;
                txt5.Enabled = false;
            }

            else if (l5 == "D" || l5 == "I" || l5 == "N" || l5 == "O" || l5 == "S" || l5 == "A" || l5 == "U" || l5 == "R")
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
            if (l6 == "A")
            {
                txt6.BackColor = Color.Green;
                txt6.Enabled = false;
            }

            else if (l6 == "D" || l6 == "I" || l6 == "N" || l6 == "O" || l6 == "S" || l6 == "A" || l6 == "U" || l6 == "R")
            {
                txt_Letras_existentes.Text += l6 + " ";
                txt6.BackColor = Color.Red;
                txt6.Text = "";
            }

            else if (String.IsNullOrEmpty(txt5.Text))
            {
                txt6.BackColor = Color.Red;
            }

            else
            {
                txt6.BackColor = Color.Red;
                txt6.Text = "";
                txt_erros.Text += l6 + " ";
            }

            //SETIMO
            if (l7 == "U")
            {
                txt7.BackColor = Color.Green;
                txt7.Enabled = false;
            }

            else if (l7 == "D" || l7 == "I" || l7 == "N" || l7 == "O" || l7 == "S" || l7 == "A" || l7 == "U" || l7 == "R")
            {
                txt_Letras_existentes.Text += l7 + " ";
                txt7.BackColor = Color.Red;
                txt7.Text = "";
            }

            else if (String.IsNullOrEmpty(txt5.Text))
            {
                txt7.BackColor = Color.Red;
            }

            else
            {
                txt7.BackColor = Color.Red;
                txt7.Text = "";
                txt_erros.Text += l7 + " ";
            }

            //OITAVO
            if (l8 == "R")
            {
                txt8.BackColor = Color.Green;
                txt8.Enabled = false;
            }

            else if (l8 == "D" || l8 == "I" || l8 == "N" || l8 == "O" || l8 == "S" || l8 == "A" || l8 == "U" || l8 == "R")
            {
                txt_Letras_existentes.Text += l6 + " ";
                txt8.BackColor = Color.Red;
                txt8.Text = "";
            }

            else if (String.IsNullOrEmpty(txt5.Text))
            {
                txt8.BackColor = Color.Red;
            }

            else
            {
                txt8.BackColor = Color.Red;
                txt8.Text = "";
                txt_erros.Text += l8 + " ";
            }

            //nono
            if (l9 == "O")
            {
                txt9.BackColor = Color.Green;
                txt9.Enabled = false;
            }

            else if (l9 == "D" || l9 == "I" || l9 == "N" || l9 == "O" || l9 == "S" || l9 == "A" || l9 == "U" || l9 == "R")
            {
                txt_Letras_existentes.Text += l9 + " ";
                txt9.BackColor = Color.Red;
                txt9.Text = "";
            }

            else if (String.IsNullOrEmpty(txt5.Text))
            {
                txt9.BackColor = Color.Red;
            }

            else
            {
                txt9.BackColor = Color.Red;
                txt9.Text = "";
                txt_erros.Text += l9 + " ";
            }


            if (l1 == "D" && l2 == "I" && l3 == "N" && l4 == "O" && l5 == "S" && l6 == "A" && l7 == "U" && l8 == "R" && l9 == "O")
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
                MessageBox.Show("Perdeu");
            }
        }
    }
}
