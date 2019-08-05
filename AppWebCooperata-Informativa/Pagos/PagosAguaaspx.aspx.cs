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

public partial class Pagos_PagosAguaaspx : System.Web.UI.Page
{

    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.TextBoxMedidor.Text.Equals(""))
            {
                this.LabelDeudaA.Text = ("No a ingresado el numero de medidor o no cuenta con uno");
            }

            else
            {

                string conexion = System.Configuration.ConfigurationManager.AppSettings["CONEXION"].ToString();
                OracleConnection cn = new OracleConnection(conexion);
                cn.Open();


                OracleCommand com = cn.CreateCommand();
                com.CommandText = "select valor_m3 from Emsaba where numero_medidor=" + this.TextBoxMedidor.Text + "";
                OracleDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                        int consumo = Convert.ToInt32(reader["valor_m3"]);

                    if (consumo == 0)
                    {
                        this.LabelDeudaA.Text = ("No presenta deuda, por consumo de : " + consumo + " m3");
                    }
                    else
                    {
                        double total = (consumo * 0.45);
                        this.LabelDeudaA.Text = ("Ha consumido: " + consumo + " m3" + " Valor a pagar " + total);
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