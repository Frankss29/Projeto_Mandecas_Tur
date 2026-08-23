using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login
{
    internal class Conexao
    {
        private static string conexao = "server = localhost; database = mandecas; user = root; password = ;";

        public MySqlConnection Conectar()
        { 
            return new MySqlConnection(conexao);
        }
    }
}
