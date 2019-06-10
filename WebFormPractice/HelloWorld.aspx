<%@ Page Title="Helloworld" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HelloWorld.aspx.cs" Inherits="Web_Form_Net.HelloWorld" %>

<asp:Content ID="HelloWorldBodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container form-group">
        <asp:Table runat="server" CssClass="HelloTableCss">
            <asp:TableRow>
                <asp:TableHeaderCell ID="OnLineUserCountHeader" Text="Number of online users"></asp:TableHeaderCell>
                <asp:TableCell ID="OnLineUserCount"></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell ID="ApplicationCountHeader" Text="Number of applications"></asp:TableHeaderCell>
                <asp:TableCell ID="ApplicationCount"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <fieldset>
            <legend>Profile</legend>
            <div class="container" id="ProfileContainer">
                <div class="row form-group">
                    <div class="col-sm-2">
                        <asp:Label AssociatedControlID="FirstNameTextBox" runat="server" Text="First Name" CssClass="form-label"></asp:Label>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="FirstNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-sm-2">
                        <asp:Label AssociatedControlID="LastNameTextBox" runat="server" Text="Last Name" CssClass="form-label"></asp:Label>
                    </div>

                    <div class="col-sm-6">
                        <asp:TextBox ID="LastNameTextBox" runat="server" CssClass=" form-control" OnTextChanged="LastNameTextBox_TextChanged" AutoPostBack="true"></asp:TextBox>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-sm-2">
                        <asp:Label AssociatedControlID="CityDropDownList" runat="server" Text="City" CssClass="col-md-4"></asp:Label>
                    </div>
                    <div class="col-sm-2">
                        <asp:DropDownList ID="CityDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-sm-2">
                        <asp:Label AssociatedControlID="ClickMeCountTextBox" runat="server" Text="Click Count" CssClass="form-label"></asp:Label>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox ID="ClickMeCountTextBox" Text="0" runat="server" AutoPostBack="true" OnTextChanged="ClickMeCountTextBox_TextChanged" CssClass="form-control"></asp:TextBox>

                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-sm-2">
                        <asp:Label runat="server" Text="Gender" CssClass="form-label"></asp:Label>
                    </div>
                    <div class="col-sm-10 form-check">
                        <asp:RadioButton ID="FemaleRadioBtn" GroupName="Gender" Text="Female" runat="server" OnCheckedChanged="GenderRadioBtn_CheckedChanged" AutoPostBack="true"  CssClass="form-check-input"/>
                        <asp:RadioButton ID="MaleRadioBtn" GroupName="Gender" Text="Male" runat="server" OnCheckedChanged="GenderRadioBtn_CheckedChanged" AutoPostBack="true"/>
                        <asp:RadioButton ID="UnknownRadioBtn" GroupName="Gender" Text="Unknown" runat="server" OnCheckedChanged="GenderRadioBtn_CheckedChanged" AutoPostBack="true"/>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-sm-2">
                        <asp:Label runat="server" Text="Country" CssClass="form-label"></asp:Label>
                    </div>
                    <div class="col-sm-10">
                        <asp:DropDownList ID="CountryDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>    
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-sm-2">
                        <asp:Label runat="server" Text="Education" AssociatedControlID="cblEducation" CssClass="form-label"></asp:Label>
                    </div>
                    <div class="col-sm-10 form-check">
                        <asp:CheckBoxList ID="cblEducation" runat="server" RepeatDirection="Horizontal" CssClass="form-check-input" AutoPostBack="true" OnSelectedIndexChanged="loadEducationCheckBoxList_OnSeletedListCheckBox"></asp:CheckBoxList>    
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-sm-2">
                    </div>
                    <div class="col-md-10">
                        <asp:Button Id="SelectAllBtn" Text="Select ALL" runat="server" OnClick="SelectAllBtn_Click" CssClass="btn btn-default"/>
                        <asp:Button Id="DeSelectAllbtn" Text="DeSelect ALL" runat="server" OnClick="DeSelectAllbtn_Click" CssClass="btn btn-default"/>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-sm-2">
                    </div>
                    <div class="col-md-10">
                        <asp:ListBox ID="lbEducation" runat="server" SelectionMode="Multiple" Rows="3" Width="100px"></asp:ListBox>
                    </div>
                </div>
                
                <asp:Button ID="ClickMe" Text="Click Me" runat="server" OnClick="ClickMeButton_Click" CssClass="btn btn-primary"></asp:Button>
                <asp:Button ID="CommandMePrint" Text="Print" runat="server" OnCommand="CommandMe_Commands" CommandName="Print" CssClass="btn btn-default"/>
                <asp:Button ID="CommandMeDel"   Text="Delete" runat="server" OnCommand="CommandMe_Commands" CommandName="Delete" CssClass="btn btn-default"/>
                <asp:Button ID="CommandMeTop10" Text="Print Top 10" runat="server" OnCommand="CommandMe_Commands" CommandName="PrintTop" CommandArgument="Top10" CssClass="btn btn-default"/>
                <asp:Button ID="CommandMeTop20" Text="Print Top 20" runat="server" OnCommand="CommandMe_Commands" CommandName="PrintTop" CommandArgument="Top20" CssClass="btn btn-default"/>
                <asp:Button ID="CommandMeEmail" Text="Email" runat="server" OnCommand="CommandMe_Commands" CommandName="Email" CommandArgument="Top10" CssClass="btn btn-default"/>
            
            </div>
        </fieldset>
        <!-----End of profile container-->

    </div>
</asp:Content>
