using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//namespace del programador.
using System.Data.OracleClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.OleDb;


public partial class Login : System.Web.UI.Page
{


    protected void ButtonLogin_Click(object sender, EventArgs e)
    {

            string conexion = System.Configuration.ConfigurationManager.AppSettings["CONEXION"].ToString();
            OracleConnection cn = new OracleConnection(conexion);
            cn.Open();

            OracleCommand com = cn.CreateCommand();
            com.CommandText = "select nombres from Clientes where nombres='" + this.TextBoxUsuario.Text + "' and cedula='" + this.TextBoxPassword.Text + "'";
            OracleDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                if (!reader.HasRows)
                {
                    MessageBox.Show("usuario o contraseña incorrectos");
                }

                String user=("" + reader["nombres"]);
                if(user==this.TextBoxUsuario.Text)
                {
                    Response.Redirect("ConsultaPago.aspx");
                }
            }
        }

    protected void TextBoxPassword_TextChanged(object sender, EventArgs e)
    {

    }
}   
