using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaDePrestamo
{
    class cls_connection
    {

        SqlConnection mycon;
        SqlCommand command;
        SqlDataReader reader;

        public cls_connection()
        {

            mycon = new SqlConnection("Data Source=DESKTOP-7HTM10P\\MADELSONSQL;Initial Catalog=Made;Integrated Security=True");


        }
        public SqlConnection Conectar()
        {
            try
            {
                mycon.Open();
            }

            catch (Exception x)
            {

                MessageBox.Show("ERROR::" + x.ToString());

            }
            return mycon;
        }

        public bool Validar (string usuario, string pass)
        {
            bool valido = false;

            string query = @"Select UsuarioID,Pass from dbo.Usuario where 
                                     UsuarioID= '" + usuario + "' and Pass='" + pass + "'";

            command = new SqlCommand(query, Conectar());

            reader = command.ExecuteReader();

            if (reader.HasRows == true)
            {
                valido = true;


            }

            return valido;


        }



    }
}
