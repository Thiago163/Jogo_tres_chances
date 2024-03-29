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
    public partial class frm_Jogos_facil : Form
    {
        public frm_Jogos_facil()
        {
            InitializeComponent();
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
            if (l1 == "S")
            {
                txt1.BackColor = Color.Green;
                txt1.Enabled = false;
            }

            else if (l1 == "S" || l1 == "O" || l1 == "N" || l1 == "I" || l1 == "C")
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

            else if (l2 == "S" || l2 == "O" || l2 == "N" || l2 == "I" || l2 == "C")
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

            else if (l3 == "S" || l3 == "O" || l3 == "N" || l3 == "I" || l3 == "C")
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
            if (l4 == "I")
            {
                txt4.BackColor = Color.Green;
                txt4.Enabled = false;
            }

            else if (l4 == "S" || l4 == "O" || l4 == "N" || l4 == "I" || l4 == "C")
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
            if (l5 == "C")
            {
                txt5.BackColor = Color.Green;
                txt5.Enabled = false;
            }

            else if (l5 == "S" || l5 == "O" || l5 == "N" || l5 == "I" || l5 == "C")
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



            if (l1 == "S" && l2 == "O" && l3 == "N" && l4 == "I" && l5 == "C")
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

        private void Btn_limpar_Click(object sender, EventArgs e)
        {

        }
    }
}
