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
    class cls_datos : cls_connection1
    {
        #region DATOS
        string query = "";
        SqlCommand command;
        cls_connection1 conection = new cls_connection1();
        DataSet set = new DataSet();
        SqlDataAdapter adapter;
        #endregion

        public cls_datos()
        {
        }

        public void sql_Insertar(string tabla, string campos, string valores)


        {
            query = "INSERT INTO " + tabla + "(" + campos + ") VALUES (" + valores + ")";
            
            try
            {

                command = new SqlCommand(query, conection.Conectar());
                command.ExecuteNonQuery();
                conection.Desconectar();


            }
            catch(SqlException x)
            {

                MessageBox.Show(x.ToString());

            }

            



        }

        public DataTable sql_Consultas (string tabla, string campos, string condicion    )
        {

            query = "SELECT " + campos + " FROM " + tabla + " WHERE " + condicion + "";

            try
            {

                adapter = new SqlDataAdapter(query, conection.Conectar());
                adapter.Fill(set,"TDATOS");
            }
            catch (SqlException x)

            {
                MessageBox.Show(x.ToString());

            }
                
            return set.Tables["TDATOS"];
        }

        public void sql_Actualizar (string tabla,string campos, string condicion)

        {

            query = "UPDATE " + tabla + " SET " + campos + " WHERE " + condicion + "";

            try
            {
                command = new SqlCommand(query, conection.Conectar());
                command.ExecuteNonQuery();
                conection.Desconectar();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString());

            }

        }


    }

}
