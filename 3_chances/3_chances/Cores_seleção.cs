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
    public partial class frm_Cores_seleção : Form
    {
        public frm_Cores_seleção(Form corFundo, string pontuacao)
        {
            InitializeComponent();
            this.BackColor = corFundo.BackColor;
            txtPontos.Text = pontuacao;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cores_facil_Click(object sender, EventArgs e)
        {
            frm_Cores_facil frm_cores_facil = new frm_Cores_facil(this);
            frm_cores_facil.ShowDialog();
        }

        private void btn_cores_medio_Click(object sender, EventArgs e)
        {
            frm_Cores_Medio frm_cores_Medio = new frm_Cores_Medio(this, "stop");
            frm_cores_Medio.ShowDialog();
        }

        private void btn_cores_dificil_Click(object sender, EventArgs e)
        {
            frm_Cores_Dificil frm_cores_Dificil = new frm_Cores_Dificil(this, "stop");
            frm_cores_Dificil.ShowDialog();
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
    }
}
