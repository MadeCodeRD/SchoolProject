using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sumadora
{
    class cls_conexion
    {
        SqlConnection MyCon;
        SqlCommand comand;
        SqlDataReader reader;
        public cls_conexion()
        {
            
            MyCon = new SqlConnection("Data Source=DESKTOP-7HTM10P\\MADELSONSQL;Initial Catalog=Tester;Integrated Security=True");
        }
        public SqlConnection Conectar()
        {
            try
            {
                MyCon.Open();  
            }
            catch (Exception x)  
            {
                MessageBox.Show("Error :: " + x.ToString());
            }
            return MyCon;     
        }
        public bool Validar(string user, string password)  
        {
            bool valido = false;  
            string query = @"SELECT Usuario_ID,Pass from dbo.Usuario where 
                              Usuario_ID='" + user + "' and Pass ='" + password + "'"; 

            comand = new SqlCommand(query, Conectar()); 
            reader = comand.ExecuteReader(); 

            if (reader.HasRows == true) 
            {
                valido = true;
            }

            return valido; 
        }

    }



}
