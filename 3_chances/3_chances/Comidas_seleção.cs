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
    public partial class frm_Comidas_seleção : Form
    {
        public frm_Comidas_seleção(Form corFundo, string pontuacao)
        {
            InitializeComponent();
            this.BackColor = corFundo.BackColor;
            txtPontos.Text = pontuacao;
        }


        private void btn_Comidas_Facil_Click(object sender, EventArgs e)
        {
            frm_Comidas_facil frm_comidas_facil = new frm_Comidas_facil(this);
            frm_comidas_facil.ShowDialog();
        }

        private void btn_Comidas_Medio_Click(object sender, EventArgs e)
        {
            frm_Comidas_Medio frm_comidas_Medio = new frm_Comidas_Medio(this, "stop");
            frm_comidas_Medio.ShowDialog();
        }

        private void btn_Comidas_Dificil_Click(object sender, EventArgs e)
        {
            frm_Comidas_Dificil frm_comidas_Dificil = new frm_Comidas_Dificil(this, "stop");
            frm_comidas_Dificil.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_gerarP_Click_1(object sender, EventArgs e)
        {
            try
            {
                Jogador usu = new Jogador();
                usu.Pontos_usu1 = txtPontos.Text;

                object retorno = usu.Update();

            }
            catch (Exception ex)
            {
                lbl_nada.Text = ("" + ex);
            }

            var maiorPontuador = new Jogador().BuscarMaiorPontuador();

            lblMaiorPontuador.Text = maiorPontuador.Jogador_usu1;
            lblMaiorPontuacao.Text = maiorPontuador.Pontos_usu1;

            var medioPontuador = new Jogador().BuscarMedioPontuador();

            lblMaiorPontuador2.Text = medioPontuador.Jogador_usu1;
            lblMaiorPontuacao2.Text = medioPontuador.Pontos_usu1;

            var menorPontuador = new Jogador().BuscarMenorPontuador();

            lblMaiorPontuador3.Text = menorPontuador.Jogador_usu1;
            lblMaiorPontuacao3.Text = menorPontuador.Pontos_usu1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
