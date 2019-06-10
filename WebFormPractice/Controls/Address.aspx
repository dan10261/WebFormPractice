<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Address.aspx.cs" Inherits="Web_Form_Net.Controlls.Address" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" id="AddressContainer">
        <fieldset>
            <legend>Address Information</legend>
            <div class="form-control">
                <div class="row form-group">
                    <div class="col-md-2">
                        <asp:Label AssociatedControlID="ddlContinent" runat="server"></asp:Label>
                    </div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="ddlContinent" runat="server" DataTextField="ContinentName" DataValueField="ContinentID" OnSelectedIndexChanged="ddlContinent_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-md-2">
                        <asp:Label AssociatedControlID="ddlCountry" runat="server"></asp:Label>
                    </div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="ddlCountry" runat="server" DataTextField="CountryName" DataValueField="CountryID" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-md-2">
                        <asp:Label AssociatedControlID="ddlCity" runat="server"></asp:Label>
                    </div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="ddlCity" runat="server" DataTextField="CityName" DataValueField="CityID"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="row form-group">
                <div class="row col-md-6" style="float:right">
                    <asp:Button runat="server" Text="Submit via server.transfer" ID="ServerTransferBtn" OnClick="ServerTransferBtn_Click"/>
                </div>
                 <div class="row col-md-6">                     
                    <asp:Button runat="server" Text="Submit via server.execute" ID="ServerExecuteBtn" OnClick="ServerExecuteBtn_Click"/>
                </div>
                 <div class="row col-md-6">                     
                    <asp:Button runat="server" Text="Submit via Post Back" ID="ButtonPostBack" PostBackUrl="AddressDetail.aspx"/>
                </div>
                </div>
        </fieldset>
    </div>
</asp:Content>
