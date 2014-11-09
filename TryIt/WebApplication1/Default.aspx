<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <p>
                Currency check: Enter a three letter currency symbol and return the rate</p>
            <p>
                &nbsp;Currency&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="324px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Convert" OnClick="Button1_Click" />
            </p>
            <p>
                &nbsp;&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
            </p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                Find the nearest store: Enter a zipcode and will return the 10 hotels near the zipcode</p>
            <p>
                &nbsp;Zipcode&nbsp;<asp:TextBox ID="TextBox2" runat="server" Width="303px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Find" />
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </p>
        </div>
    </div>

</asp:Content>
