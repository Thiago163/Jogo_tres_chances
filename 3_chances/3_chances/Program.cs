using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_chances
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }


    /*
     //Primeiro
            if (l1 == "")
            {
                txt1.BackColor = Color.Green;
                txt1.Enabled = false;
            }

            else if (l1 == "" || l1 == "" || l1 == "" || l1 == "" || l1 == "" || l1 == "")
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
            if (l2 == "")
            {
                txt2.BackColor = Color.Green;
                txt2.Enabled = false;
            }

            else if (l2 == "" || l2 == "" || l2 == "" || l2 == "" || l2 == "" || l2 == "")
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
            if (l3 == "")
            {
                txt3.BackColor = Color.Green;
                txt3.Enabled = false;
            }

            else if (l3 == "" || l3 == "" || l3 == "" || l3 == "" || l3 == "" || l3 == "")
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
            if (l4 == "")
            {
                txt4.BackColor = Color.Green;
                txt4.Enabled = false;
            }

            else if (l4 == "" || l4 == "" || l4 == "" || l4 == "" || l4 == "" || l4 == "")
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
            if (l5 == "")
            {
                txt5.BackColor = Color.Green;
                txt5.Enabled = false;
            }

            else if (l5 == "" || l5 == "" || l5 == "" || l5 == "" || l5 == "" || l5 == "")
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
            if (l6 == "")
            {
                txt6.BackColor = Color.Green;
                txt6.Enabled = false;
            }

            else if (l6 == "" || l6 == "" || l6 == "" || l6 == "" || l6 == "" || l6 == "")
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
            if (l7 == "")
            {
                txt7.BackColor = Color.Green;
                txt7.Enabled = false;
            }

            else if (l7 == "" || l7 == "" || l7 == "" || l7 == "" || l7 == "" || l7 == "")
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
            if (l8 == "")
            {
                txt8.BackColor = Color.Green;
                txt8.Enabled = false;
            }

            else if (l8 == "" || l8 == "" || l8 == "" || l8 == "" || l8 == "" || l8 == "")
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
            if (l9 == "")
            {
                txt9.BackColor = Color.Green;
                txt9.Enabled = false;
            }

            else if (l9 == "" || l9 == "" || l9 == "" || l9 == "" || l9 == "" || l9 == "")
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
            if (l10 == "")
            {
                txt10.BackColor = Color.Green;
                txt10.Enabled = false;
            }

            else if (l10 == "" || l10 == "" || l10 == "" || l10 == "" || l10 == "" || l10 == "")
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
            if (l11 == "")
            {
                txt11.BackColor = Color.Green;
                txt11.Enabled = false;
            }

            else if (l11 == "" || l11 == "" || l11 == "" || l11 == "" || l11 == "" || l11 == "")
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
            if (l12 == "")
            {
                txt12.BackColor = Color.Green;
                txt12.Enabled = false;
            }

            else if (l12 == "" || l12 == "" || l12 == "" || l12 == "" || l12 == "" || l12 == "" )
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



            if (l1 == "" && l2 == "" && l3 == "" && l4 == "" && l5 == "" && l6 == "" && l7 == "" && l8 == "")
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
     */
}
