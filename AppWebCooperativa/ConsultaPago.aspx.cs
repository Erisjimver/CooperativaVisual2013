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


    protected void ButtonConsulta_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start("http://localhost:1746/Principal.aspx");
       
    }
    protected void ButtonPagos_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}   
