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
public partial class Transferencia_Retiro : System.Web.UI.Page
{


    public  string n_cuenta, cantidad;
    protected void ButtonConsultar_Click(object sender, EventArgs e)
    {
        n_cuenta = this.TextBoxNCuenta.Text;

        try
        {

            if (n_cuenta.Equals(""))
            {
                Labelresultado.Text = "no ha ingresado numero de cuenta";
            }
            else
            {
                string conexion = System.Configuration.ConfigurationManager.AppSettings["CONEXION"].ToString();
                OracleConnection cn = new OracleConnection(conexion);
                cn.Open();

                OracleCommand com = cn.CreateCommand();
                com.CommandText = "select saldo from Clientes where n_cuenta=" + n_cuenta+ "";
                OracleDataReader reader = com.ExecuteReader();

                if (!reader.HasRows)
                {
                    this.Labelresultado.Text = ("numero de cuenta invalido");
                }
                while (reader.Read())
                {
                    String saldo = ("" + reader["saldo"]);
                    this.Labelresultado.Text = ("Su saldo es de: " + saldo + " dolares");

                }
            }
        }
        catch (Exception err)
        {
            Labelresultado.Text = ("error de conexion" + err.Message + "");
        }

    }
    
    
    protected void ButtonRetirar_Click(object sender, EventArgs e)
    {
        n_cuenta = this.TextBoxNCuenta.Text;
        cantidad = DropDownList1.SelectedItem.ToString();


        
        try
        {
           if(n_cuenta.Equals("")){
               Labelr.Text = "Consulte su saldo";
            }
           else
            {
                string conexion = System.Configuration.ConfigurationManager.AppSettings["CONEXION"].ToString();
                OracleConnection cn = new OracleConnection(conexion);
                cn.Open();

                OracleCommand com = cn.CreateCommand();
                com.CommandText = "select saldo from Clientes where n_cuenta=" + n_cuenta+ "";
                OracleDataReader reader = com.ExecuteReader();
                
                while (reader.Read())
                {
                    
                    int cuenta, envio,saldo;

                    cuenta = Convert.ToInt32(n_cuenta);
                    envio = Convert.ToInt32(cantidad);
                    saldo = Convert.ToInt32(reader["saldo"]);
   

                    if (saldo < envio)
                    {
                        this.Labelr.Text = ("El monto a enviar excede a su presupuesto");
                    }
                    else
                    {
                        retiro(cuenta, envio);
                    }
                }   
            }
        }
        catch (Exception err)
        {
            Labelr.Text = "Error" + err;
        }
    }



    public void retiro(int n_cuenta,int can)
    {
        string conexion = System.Configuration.ConfigurationManager.AppSettings["CONEXION"].ToString();
        OracleConnection cn = new OracleConnection(conexion);
        cn.Open();

        OracleCommand com = cn.CreateCommand();

        com.CommandType = CommandType.StoredProcedure;
        com.CommandText = "retiro";
        com.Parameters.Add("cantidad", OracleType.Number).Value = can;
        com.Parameters.Add("nc", OracleType.Number).Value = n_cuenta;

        int registro = com.ExecuteNonQuery();

        if (registro > 0)
        {
            this.Labelr.Text = "retiro exitoso";

        }
        else
        {

            this.Labelr.Text = "retiro fallido";

        }
    }

}