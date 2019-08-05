<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

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
                                <label for="username" class="control-label">Usuario</label>
                                
                                <span class="help-block">
                                
                                <asp:TextBox ID="TextBoxUsuario" runat="server"  placeholder="Usuario"></asp:TextBox>
                                
                                </span>
                            </div>

                            <div class="from-group">

                                <label for="Password" class="control-label">Contraseña</label>

                                <span class="help-block">

                                   

                                    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" placeholder="Password" OnTextChanged="TextBoxPassword_TextChanged"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="TextBoxPassword" ErrorMessage="Ingrese contraseña" 
                                    ToolTip="Ingrese contraseña" ValidationGroup="lgnIngreso">*</asp:RequiredFieldValidator>

                                </span>

                            </div>
                           <asp:Button ID="ButtonLogin" runat="server" type="submit" Text="Acceder" OnClick="ButtonLogin_Click" />
                            
                        </div>
                    </div>
                </div>

            </div>
        </div>
        
       
    </form>
</body>
</html>
