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
    public partial class frm_Esportes_Medio : Form
    {
        public frm_Esportes_Medio()
        {
            InitializeComponent();
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
            if (l1 == "B")
            {
                txt1.BackColor = Color.Green;
                txt1.Enabled = false;
            }

            else if (l1 == "B" || l1 == "A" || l1 == "S" || l1 == "Q" || l1 == "U" || l1 == "E" || l1 == "T")
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
            if (l2 == "A")
            {
                txt2.BackColor = Color.Green;
                txt2.Enabled = false;
            }

            else if (l2 == "B" || l2 == "A" || l2 == "S" || l2 == "Q" || l2 == "U" || l2 == "E" || l2 == "T")
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
            if (l3 == "S")
            {
                txt3.BackColor = Color.Green;
                txt3.Enabled = false;
            }

            else if (l3 == "B" || l3 == "A" || l3 == "S" || l3 == "Q" || l3 == "U" || l3 == "E" || l3 == "T")
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
            if (l4 == "Q")
            {
                txt4.BackColor = Color.Green;
                txt4.Enabled = false;
            }

            else if (l4 == "B" || l4 == "A" || l4 == "S" || l4 == "Q" || l4 == "U" || l4 == "E" || l4 == "T")
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
            if (l5 == "U")
            {
                txt5.BackColor = Color.Green;
                txt5.Enabled = false;
            }

            else if (l5 == "B" || l5 == "A" || l5 == "S" || l5 == "Q" || l5 == "U" || l5 == "E" || l5 == "T")
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
            if (l6 == "E")
            {
                txt6.BackColor = Color.Green;
                txt6.Enabled = false;
            }

            else if (l6 == "B" || l6 == "A" || l6 == "S" || l6 == "Q" || l6 == "U" || l6 == "E" || l6 == "T")
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
            if (l7 == "T")
            {
                txt7.BackColor = Color.Green;
                txt7.Enabled = false;
            }

            else if (l7 == "B" || l7 == "A" || l7 == "S" || l7 == "Q" || l7 == "U" || l7 == "E" || l7 == "T")
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
            if (l8 == "E")
            {
                txt8.BackColor = Color.Green;
                txt8.Enabled = false;
            }

            else if (l8 == "B" || l8 == "A" || l8 == "S" || l8 == "Q" || l8 == "U" || l8 == "E" || l8 == "T")
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


            if (l1 == "B" && l2 == "A" && l3 == "S" && l4 == "Q" && l5 == "U" && l6 == "E" && l7 == "T" && l8 == "E")
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
