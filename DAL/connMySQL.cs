using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WFLogin.DAL
{
    internal class connMySQL
    {
        private MySqlConnection conexao = new MySqlConnection();

        public connMySQL()
        {
            conexao.ConnectionString = @"server=localhost;Port=3307;database=loginmvc;Uid=root;Pwd=bibi2835201819";
        }

        public MySqlConnection conectar()
        {
            if(conexao.State == System.Data.ConnectionState.Closed) conexao.Open();
            return conexao;
        }

        public void desconectar()
        {
            if(conexao.State == System.Data.ConnectionState.Open) conexao.Close();
        }
    }
}
