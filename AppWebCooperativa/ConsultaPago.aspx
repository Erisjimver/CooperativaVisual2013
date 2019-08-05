<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConsultaPago.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link href="Bootstrap/bootstrap-theme.css" rel="stylesheet" />
</head>
<body id="img-login">

    <form id="form1" runat="server">

    <div class="panel-img">
        <img src="/Imagenes/Panel.png" />
&nbsp;</div>

        <div>
            <div style="position:absolute; z-index:auto"id="layer1">
                <div class="modal-body" style="margin:30px 0px 0px 400px;">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="from-group">
                                <label for="Consultas" class="control-label">Consultas</label>
                                
                                <span class="help-block">
                                            
                                <asp:Button ID="ButtonConsulta" runat="server" Text="Acceder" OnClick="ButtonConsulta_Click" />
                                
                           
                            
                                </span>
                            </div>

                            <div class="from-group">

                                <label for="Pagos" class="control-label">Pagos</label>

                                <span class="help-block">
                           
                                <asp:Button ID="ButtonPagos" runat="server" Text="Acceder" OnClick="ButtonPagos_Click" />
                                
                           
                            
                                </span>

                            </div>
                            
                        </div>
                    </div>
                </div>

            </div>
        </div>
        
       
    </form>
</body>
</html>
