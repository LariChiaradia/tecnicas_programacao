using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Aula7.Models
{
    public class UsuarioModel
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String senha { get; set; }

        readonly String connectionString = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=AVA5;Integrated Security=True";
        public bool Login()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                //  select id from usuario where nome = 'daniel' and senha = '123';
                String sqlConsulta = $"SELECT id FROM usuario WHERE nome LIKE '{nome}' and senha LIKE '{senha} '";
                SqlCommand sqlCmd = new SqlCommand(sqlConsulta, sqlCon);

                SqlDataReader rdLogin = sqlCmd.ExecuteReader();
                rdLogin.Read();
                if (rdLogin.HasRows)
                {
                    sqlCon.Close();
                    return true;
                }
                else
                {
                    sqlCon.Close();
                    return false;
                }
            }
        }
    }
}