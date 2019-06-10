<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="Web_Form_Net.Controlls.FileUpload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row form-group">
            <asp:FileUpload ID="UploadFile" runat="server" />
        </div>
        <div class="row form-group">
            <asp:Button ID="UploadFileBtn" Text="Upload File" runat="server" OnClick="UploadFileBtn_Click" />
        </div>
        <div class="row form-group">
            <asp:Label ID="UploadFileMsg" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
