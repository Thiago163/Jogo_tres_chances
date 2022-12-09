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
    public partial class frm_Jogos_Medio : Form
    {
        public frm_Jogos_Medio()
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
            if (l1 == "G")
            {
                txt1.BackColor = Color.Green;
                txt1.Enabled = false;
            }

            else if (l1 == "G" || l1 == "D" || l1 == "O" || l1 == "F" || l1 == "W" || l1 == "A" || l1 == "R" || l1 == "3")
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

            else if (l2 == "G" || l2 == "O" || l2 == "D" || l2 == "F" || l2 == "W" || l2 == "A" || l2 == "R" || l2 == "3")
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
            if (l3 == "D")
            {
                txt3.BackColor = Color.Green;
                txt3.Enabled = false;
            }

            else if (l1 == "G" || l1 == "O" || l1 == "D" || l1 == "F" || l1 == "W" || l1 == "A" || l1 == "R" || l1 == "3")
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

            else if (l4 == "G" || l4 == "O" || l4 == "D" || l4 == "F" || l4 == "W" || l4 == "A" || l4 == "R" || l4 == "3")
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
            if (l5 == "F")
            {
                txt5.BackColor = Color.Green;
                txt5.Enabled = false;
            }

            else if (l5 == "G" || l5 == "O" || l5 == "D" || l5 == "F" || l5 == "W" || l5 == "A" || l5 == "R" || l5 == "3")
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
            if (l6 == "W")
            {
                txt6.BackColor = Color.Green;
                txt6.Enabled = false;
            }

            else if (l6 == "G" || l6 == "O" || l6 == "D" || l6 == "F" || l6 == "W" || l6 == "A" || l6 == "R" || l6 == "3")
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
            if (l7 == "A")
            {
                txt7.BackColor = Color.Green;
                txt7.Enabled = false;
            }

            else if (l7 == "G" || l7 == "O" || l7 == "D" || l7 == "F" || l7 == "W" || l7 == "A" || l7 == "R" || l7 == "3")
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

            else if (l8 == "G" || l8 == "O" || l8 == "D" || l8 == "F" || l8 == "W" || l8 == "A" || l8 == "R" || l8 == "3")
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
            if (l9 == "3")
            {
                txt9.BackColor = Color.Green;
                txt9.Enabled = false;
            }

            else if (l9 == "G" || l9 == "O" || l9== "D" || l9 == "F" || l9 == "W" || l9 == "A" || l9 == "R" || l9 == "3")
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


            if (l1 == "G" && l2 == "O" && l3 == "D" && l4 == "O" && l5 == "F" && l6 == "W" && l7 == "A" && l8 == "R" && l9 == "3")
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
