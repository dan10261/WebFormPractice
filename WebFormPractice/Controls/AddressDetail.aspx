<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddressDetail.aspx.cs" Inherits="Web_Form_Net.Controls.AddressDetail" %>
<asp:Content ID="AddressDetailContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" id="AddressDetailContainer">
        <fieldset>
            <legend>Address Detail Information</legend>
            <div class="form-control">
                <div class="row form-group">
                    <div class="col-md-2">
                        <asp:Label AssociatedControlID="ddlContinentLiteral" runat="server" Text="Continent"></asp:Label>
                    </div>
                    <div class="col-md-10">
                        <asp:Literal ID="ddlContinentLiteral" runat="server"  ></asp:Literal>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-md-2">
                        <asp:Label AssociatedControlID="ddlCountryLiteral" runat="server" Text="Country"></asp:Label>
                    </div>
                    <div class="col-md-10">
                        <asp:Literal ID="ddlCountryLiteral" runat="server"></asp:Literal>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-md-2">
                        <asp:Label AssociatedControlID="ddlCityLiteral" runat="server" Text="City"></asp:Label>
                    </div>
                    <div class="col-md-10">
                        <asp:Literal ID="ddlCityLiteral" runat="server" ></asp:Literal>
                    </div>
                </div>
            </div>
        </fieldset>
    </div>
</asp:Content>
