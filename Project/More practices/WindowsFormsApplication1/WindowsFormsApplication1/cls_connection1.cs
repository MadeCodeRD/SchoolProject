using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class cls_connection1
    {

        SqlConnection sqlcon;

        public cls_connection1()
        {

            sqlcon = new SqlConnection("Data Source=DESKTOP-7HTM10P\\MADELSONSQL;Initial Catalog=Made2;Integrated Security=True");
        }

        public SqlConnection Conectar()
        {
            try
            {
                sqlcon.Open();
            }
            catch
            { }


            return sqlcon;



        }

        public void Desconectar()
        {


            try
            {
                sqlcon.Close();
            }
            catch
            { }


        }

    }
}
