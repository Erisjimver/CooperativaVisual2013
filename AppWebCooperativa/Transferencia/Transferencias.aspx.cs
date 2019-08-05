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
public partial class Transferencia_Transferencias : System.Web.UI.Page
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
                this.LabelSaldo.Text = ("Su saldo es de: " + saldo + " dolares");
            }
        }

        catch (Exception err)
        {
            MessageBox.Show("error de conexion" + err.Message, "");
        }
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {

            string conexion = System.Configuration.ConfigurationManager.AppSettings["CONEXION"].ToString();
            OracleConnection cn = new OracleConnection(conexion);
            cn.Open();

            OracleCommand com = cn.CreateCommand();
            com.CommandText = "select saldo from Clientes where n_cuenta=" + this.TextBoxCorigen.Text + "";
            
            OracleDataReader reader = com.ExecuteReader();
            while(reader.Read())
            {
                int saldo,envio;
                saldo = Convert.ToInt32(reader["saldo"]);
                envio = Convert.ToInt32(this.TextBoxNmonto.Text);
                if (saldo < envio)
                {
                    this.LabelResultado.Text = ("El monto a enviar excede a su presupuesto");
                }
                else
                {

                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "transaccion";
                    com.Parameters.Add("cantidad", OracleType.Number).Value = Convert.ToInt32(this.TextBoxNmonto.Text);
                    com.Parameters.Add("co", OracleType.Number).Value = Convert.ToInt32(this.TextBoxCorigen.Text);
                    com.Parameters.Add("cd", OracleType.Number).Value = Convert.ToInt32(this.TextBoxCdestino.Text);

                    int registro = com.ExecuteNonQuery();

                    if (registro > 0)
                    {

                        this.LabelResultado.Text = "Transaccion exitosa";
                    }
                    else
                    {

                        this.LabelResultado.Text = "Transaccion fallida";
                    }

                }
                  
            }


           
        }

        catch (Exception err)
        {
            MessageBox.Show("error de conexion" + err.Message, "");
        }

    }
}