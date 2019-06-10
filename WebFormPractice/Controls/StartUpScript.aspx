<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartUpScript.aspx.cs" Inherits="Web_Form_Net.Controlls.StartUpScript" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RegisterStartupScript</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox runat="server" ID="HideMe" Text="hide me"></asp:TextBox>
        <asp:Button runat="server" ID="Bbtn" Text="hide me" OnClick="Bbtn_Click"></asp:Button>
    </div>
    </form>
</body>
</html>
