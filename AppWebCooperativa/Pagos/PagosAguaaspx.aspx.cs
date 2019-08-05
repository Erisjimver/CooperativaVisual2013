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



    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.TextBoxMedidor.Text.Equals(""))
            {
                this.LabelResultado.Text = ("no se conoce la deuda");
            }

            else
            {

                string conexion = System.Configuration.ConfigurationManager.AppSettings["CONEXION"].ToString();
                OracleConnection cn = new OracleConnection(conexion);
                cn.Open();

                OracleCommand com = cn.CreateCommand();
                //com.CommandText = "select valor_m3 from Emsaba where numero_medidor=" + this.TextBoxMedidor.Text + "";
                com.CommandText = "select c.saldo, e.valor_m3 from Clientes c inner join servicios s on c.n_cuenta = s.n_cuenta inner join emsaba e on e.codigo_servicio = s.codigo_servicio where e.numero_medidor=" + this.TextBoxMedidor.Text + "";
                OracleDataReader reader = com.ExecuteReader();

                
                while (reader.Read())
                {
                    int  sal=Convert.ToInt32(reader["saldo"]);
                    int consumo = Convert.ToInt32(reader["valor_m3"]);
                    double total = (consumo * 0.45);

                    if (sal < total)
                    {
                        this.LabelResultado.Text = ("Dinero insuficiente en la cuenta");

                    }
                    else
                    {

                    
                        if (consumo == 0)
                        {
                            this.LabelResultado.Text = ("No presenta deuda");
                        }

                        else
                        {

                            com.CommandType = CommandType.StoredProcedure;
                            com.CommandText = "pagosServiciosAgua";
                            com.Parameters.Add("nm", OracleType.Number).Value = Convert.ToInt32(this.TextBoxMedidor.Text);
                            com.Parameters.Add("consu", OracleType.Number).Value = consumo;
                            com.Parameters.Add("cancelado", OracleType.Number).Value = total;

                            int registro = com.ExecuteNonQuery();

                            if (registro > 0)
                            {

                                this.LabelResultado.Text = "Pago de servicio exitoso";
                            }
                            else
                            {

                                this.LabelResultado.Text = "Pago de servicio fallido";
                            }

                        }
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