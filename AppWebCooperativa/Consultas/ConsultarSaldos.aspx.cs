using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//namespace del programador.
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data;

public partial class Consultas_ConsultarSaldos : System.Web.UI.Page
{


    OracleDataAdapter Adap;
    DataSet ds;

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            string conexion = System.Configuration.ConfigurationManager.AppSettings["CONEXION"].ToString();
            OracleConnection cn = new OracleConnection(conexion);
            cn.Open();

            OracleCommand com = cn.CreateCommand();
            com.CommandText = "select saldo from Clientes where cedula=" + this.TextBoxCedula.Text + "";
            OracleDataReader reader = com.ExecuteReader();
           
            if (!reader.HasRows)
            {
                MessageBox.Show("No a ingresado el numero de medidor o no cuenta con uno");
            }
            while (reader.Read())
            {
                String saldo = ("" + reader["saldo"]);
                this.LabelSaldo.Text = ("Su saldo es de: "+saldo+" dolares");
            }   
        }

        catch (Exception err)
        {
            MessageBox.Show("error de conexion" + err.Message, "");
        }
        
    }

}