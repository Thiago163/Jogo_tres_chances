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
    public partial class frm_Esportes_selecao : Form
    {
        public frm_Esportes_selecao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_esportes_facil_Click(object sender, EventArgs e)
        {
            frm_Esportes_facil frm_Esportes_Facil = new frm_Esportes_facil();
            frm_Esportes_Facil.ShowDialog();
        }

        private void btn_esportes_medio_Click(object sender, EventArgs e)
        {
            frm_Esportes_Medio frm_Esportes_Medio = new frm_Esportes_Medio();
            frm_Esportes_Medio.ShowDialog();
        }

        private void btn_esportes_dificil_Click(object sender, EventArgs e)
        {
            frm_Esportes_dificil frm_Esportes_Dificil = new frm_Esportes_dificil();
            frm_Esportes_Dificil.ShowDialog();
        }

        private void btn_gerarP_Click(object sender, EventArgs e)
        {
            try
            {
                Jogador usu = new Jogador();
                usu.Pontos_usu1 = textBox1.Text;

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
    }
}
