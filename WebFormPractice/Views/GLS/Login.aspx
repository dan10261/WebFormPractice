<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormPractice.Views.GLS.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset id="LoginFieldSet" title="Login Info" style="border:solid  #CCC 1px;margin:10px;padding:20px; ">
        <legend> Login Information</legend>
        <div class="form-group">
            <div class="row">
                <div class="col-sm-2">
                     <asp:Label runat="server" AssociatedControlID="tbUserName" Text="User Name" CssClass="custom-label"></asp:Label>
                </div>
                <div class="col-sm-6">
                    <asp:TextBox runat="server" ID="tbUserName" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="row">
                <div class="col-sm-2">
                      <asp:Label runat="server" AssociatedControlID="tbEmailAddress" Text="Email Address" CssClass="custom-label"></asp:Label>
                </div>
                <div class="col-sm-6">
                      <asp:TextBox runat="server" ID="tbEmailAddress"  CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="row">
                <div class="col-sm-2"></div>
                <div class="col-sm-6">
                      <asp:Button runat="server" ID="btnLogin"  CssClass="btn btn-primary" Text="sign in" OnClick="btnLogin_Click"></asp:Button>
                </div>
            </div>
        </div>

    </fieldset>
</asp:Content>
