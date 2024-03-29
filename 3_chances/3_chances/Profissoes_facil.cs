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
    public partial class frm_Profissoes_facil : Form
    {
        public frm_Profissoes_facil()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string l1, l2, l3, l4, l5, l6;

            l1 = Convert.ToString(txt1.Text);
            l2 = Convert.ToString(txt2.Text);
            l3 = Convert.ToString(txt3.Text);
            l4 = Convert.ToString(txt4.Text);
            l5 = Convert.ToString(txt5.Text);
            l6 = Convert.ToString(txt6.Text);

            //Primeiro
            if (l1 == "P")
            {
                txt1.BackColor = Color.Green;
                txt1.Enabled = false;
            }

            else if (l1 == "P" || l1 == "I" || l1 == "N" || l1 == "T" || l1 == "O" || l1 == "R")
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

            else if (l2 == "P" || l2 == "I" || l2 == "N" || l2 == "T" || l2 == "O" || l2 == "R")
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

            else if (l3 == "P" || l3 == "I" || l3 == "N" || l3 == "T" || l3 == "O" || l3 == "R")
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

            else if (l4 == "P" || l4 == "I" || l4 == "N" || l4 == "T" || l4 == "O" || l4 == "R")
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
            if (l5 == "O")
            {
                txt5.BackColor = Color.Green;
                txt5.Enabled = false;
            }

            else if (l5 == "P" || l5 == "I" || l5 == "N" || l5 == "T" || l5 == "O" || l5 == "R")
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
            if (l6 == "R")
            {
                txt6.BackColor = Color.Green;
                txt6.Enabled = false;
            }

            else if (l6 == "P" || l6 == "I" || l6 == "N" || l6 == "T" || l6 == "O" || l6 == "R")
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



            if (l1 == "P" && l2 == "I" && l3 == "N" && l4 == "T" && l5 == "O" && l6 == "R")
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
                MessageBox.Show("Perdeu");
            }
        }
    }
}
