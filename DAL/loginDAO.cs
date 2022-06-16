using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WFLogin.DAL
{
    internal class loginDAO
    {
        private MySqlCommand stmt;
        private connMySQL conexao;
        private MySqlDataReader dr;
        public string mensagem;
        public bool retorno;

        public loginDAO()
        {
            mensagem = "";
            retorno = false;
        }

        public bool selectByUserAndPass(string user, string pass)
        {
            conexao = new connMySQL();
            stmt = new MySqlCommand();

            stmt.CommandText = "SELECT * FROM usuarios WHERE nome = @user AND senha = @pass";
            stmt.Parameters.AddWithValue("@user", user);
            stmt.Parameters.AddWithValue("@pass", pass);

            try
            {
                stmt.Connection = conexao.conectar();
                dr = stmt.ExecuteReader();

                if (dr.HasRows) retorno = true;
            } catch (MySqlException)
            {
                mensagem = "Ocorreu um erro ao tentar se conectar ao banco de dados!";
            }

            return retorno;
        }
    }
}
