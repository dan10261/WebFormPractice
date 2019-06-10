<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Profile.aspx.cs" Inherits="Web_Form_Net.Controlls.Profile" %>

<asp:Content ID="ProfileHeader" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="ProfileContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:MultiView ID="MultiViewProfile" runat="server">
        <asp:View ID="ViewPersonalDetail" runat="server">
            <div class="row form-group">
                <div class="col-md-2">
                    <asp:Label AssociatedControlID="tbFirstName" runat="server" Text="First Name"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="tbFirstName" runat="server" />
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-2">
                    <asp:Label AssociatedControlID="tbLastName" runat="server" Text="Last Name"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="tbLastName" runat="server" />
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-2">
                    <asp:Label AssociatedControlID="ddlGender" runat="server" Text="Gender"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:DropDownList ID="ddlGender" runat="server">
                        <asp:ListItem Value="-1" Text="Select a gender"></asp:ListItem>
                        <asp:ListItem Value="0" Text="Male"></asp:ListItem>
                        <asp:ListItem Value="1" Text="Female"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row form-group">
                <asp:Button ID="btnStep2" runat="server" Text=">> Step 2" OnClick="btnStep2_Click" />
            </div>
        </asp:View>
        <asp:View ID="ViewContactDetail" runat="server">
            <div class="row form-group">
                <div class="col-md-2">
                    <asp:Label AssociatedControlID="tbEmail" runat="server" Text="Email"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-2">
                    <asp:Label AssociatedControlID="tbPhone" runat="server" Text="Phone Number"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="tbPhone" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row form-group">
                <asp:Button ID="btnStep2To1" Text="<< Step 1" runat="server" OnClick="btnStep2To1_Click" />
                <asp:Button ID="btnStep2To3" Text=">> Step 3" runat="server" OnClick="btnStep2To3_Click" />
            </div>

        </asp:View>
        <asp:View ID="ViewSummary" runat="server">
            <div class="row form-group">
                <div class="col-md-12">
                    First Name:
                    <asp:Label ID="lblFirstName" runat="server"></asp:Label>
                </div>
                <div class="col-md-12">
                    Last Name:
                    <asp:Label ID="lblLastName" runat="server"></asp:Label>

                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-12">
                    Gender:
                    <asp:Label ID="lblGender" runat="server"></asp:Label>
                </div>
                <div class="col-md-12"></div>
            </div>
            <div class="row form-group">
                <div class="col-md-12">
                    Email:
                    <asp:Label ID="lblEmail" runat="server"></asp:Label>
                </div>
                <div class="col-md-12">
                    Phone:
                    <asp:Label ID="lblPhone" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <asp:Button ID="btnStep3To2" Text="<< Step 2" runat="server" OnClick="btnStep3To2_Click" />
                <asp:Button ID="btnSummary" Text="Summary" runat="server" OnClick="btnSummary_Click" />
            </div>
        </asp:View>
    </asp:MultiView>
</asp:Content>
