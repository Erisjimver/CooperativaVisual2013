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

public partial class Consultas_ConsultarEstadosC : System.Web.UI.Page
{

    OracleDataAdapter Adap;
    DataSet ds;
    private string n_medidor, entidad, tabla;

    protected void Button1_Click(object sender, EventArgs e)
    {
        entidad = DropDownList1.SelectedItem.ToString();

        n_medidor = this.TextBoxNMedidor.Text;

        try
        {
            this.GridView1.DataBind();

            if (entidad.Equals("")||(this.TextBoxNMedidor.Text.Equals("")))
            {
                LabelError.Text = "no ha selecionado entidad o no ingreso el medidor";
            }


            else if (entidad.Equals("Emsaba"))
            {
            
                    LabelError.Text = "----------------------------------------------------";
                    tabla = "pagos_emsaba";
                    consulta(tabla, n_medidor);
            }

            else if (entidad.Equals("Cnel"))
             {
                    LabelError.Text = "----------------------------------------------------";
                    tabla = "pagos_cnel";
                    consulta(tabla, n_medidor);
             }

            }
        

        catch (Exception err)
        {
            MessageBox.Show("error de conexion" + err.Message, "");
        }
    }

    //metodo de consulta
    public void consulta(String enti, string medi)
    {
        try
        {
            string conexion = System.Configuration.ConfigurationManager.AppSettings["CONEXION"].ToString();
            OracleConnection cn = new OracleConnection(conexion);
            cn.Open();

            ds = new DataSet();
            Adap = new OracleDataAdapter("Select fecha,consumo,cancelado from " + enti + " Where numero_medidor=:n_medi", cn);
            Adap.SelectCommand.CommandType = CommandType.Text;
            Adap.SelectCommand.Parameters.Add(":n_medi", OracleType.VarChar).Value = medi;
            Adap.Fill(ds, "TbAuxiliar");
            Adap.Dispose();

            this.GridView1.DataSource = ds.Tables[0];
            this.GridView1.DataBind();
            cn.Close();
            cn.Dispose();
        }
        catch (Exception e)
        {
            this.LabelError.Text = "error de conexion";
        }
    }
}