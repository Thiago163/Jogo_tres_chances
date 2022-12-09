using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace _3_chances
{
    class Jogador
    {
        Conexao_MySql conexao_MySql = new Conexao_MySql();
        //Declaração atributos
        string Jogador_usu;
        string Pontos_usu;

        public string Jogador_usu1 { get => Jogador_usu; set => Jogador_usu = value; }
        public string Pontos_usu1 { get => Pontos_usu; set => Pontos_usu = value; }

        #region Inserir Dados
        public object Inserir()
        {
            MySqlConnection cn = conexao_MySql.Conexao();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_inserir";
                cmd.Parameters.AddWithValue("@Jogador", Jogador_usu);
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {



                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region Atualizar Dados
        public object Update()
        {
            MySqlConnection cn = conexao_MySql.Conexao();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_update";
                cmd.Parameters.AddWithValue("@PontosJ", Pontos_usu);
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {



                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region Deletar dados
        public object deletar()
        {
            MySqlConnection cn = conexao_MySql.Conexao();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_deletar";
                cmd.Parameters.AddWithValue("@PontosJ", Pontos_usu);
                cmd.Parameters.AddWithValue("@Jogador", Jogador_usu);
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {



                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region Mostrar Dados1
        public Jogador BuscarMaiorPontuador()
        {
            var conexao = conexao_MySql.Conexao();
            conexao.Open();

            var query = "SELECT * FROM Jogador ORDER BY PONTOS DESC LIMIT 0,1";

            var comando = new MySqlCommand(query, conexao);
            var dataReader = comando.ExecuteReader();

            var jogador = new Jogador();

            while (dataReader.Read())
            {
                jogador.Jogador_usu1 = dataReader["Jogador"].ToString();
                jogador.Pontos_usu1 = dataReader["Pontos"].ToString();
            }
            conexao.Close();

            return jogador;
        }
        #endregion

        #region Mostrar Dados2
        public Jogador BuscarMedioPontuador()
        {
            var conexao = conexao_MySql.Conexao();
            conexao.Open();

            var query = "SELECT * FROM Jogador ORDER BY PONTOS DESC LIMIT 0,2";

            var comando = new MySqlCommand(query, conexao);
            var dataReader = comando.ExecuteReader();

            var jogador = new Jogador();

            while (dataReader.Read())
            {
                jogador.Jogador_usu1 = dataReader["Jogador"].ToString();
                jogador.Pontos_usu1 = dataReader["Pontos"].ToString();
            }
            conexao.Close();

            return jogador;
        }
        #endregion

        #region Mostrar Dados3
        public Jogador BuscarMenorPontuador()
        {
            var conexao = conexao_MySql.Conexao();
            conexao.Open();

            var query = "SELECT * FROM Jogador ORDER BY PONTOS DESC LIMIT 0,3";

            var comando = new MySqlCommand(query, conexao);
            var dataReader = comando.ExecuteReader();

            var jogador = new Jogador();

            while (dataReader.Read())
            {
                jogador.Jogador_usu1 = dataReader["Jogador"].ToString();
                jogador.Pontos_usu1 = dataReader["Pontos"].ToString();
            }
            conexao.Close();

            return jogador;
        }
        #endregion
    }
}
