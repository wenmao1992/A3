<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <p>
                ELECTIVE SERVICE</p>
            <p>
                &nbsp;</p>
            <p>
                Currency check: Enter a three letter currency symbol and return the rate</p>
            <p>
                &nbsp;Currency&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="324px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Check" OnClick="Button1_Click" />
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
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                REQUIRED SERVICE</p>
            <p>
                &nbsp;</p>
            <p>
                Number2Words: Enter a set of number and return the easy remember words</p>
            <p>
                Number<asp:TextBox ID="TextBox3" runat="server" Width="344px"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Convert" />
            </p>
            <p>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </p>
            <p>
                &nbsp;</p>
            <p>
                FindNearestStoreService: Enter a zipcode and the store name or type and return the 10 stores around based on your search<br />
                Zipcode<asp:TextBox ID="TextBox4" runat="server" Width="336px"></asp:TextBox>
            </p>
            <p>
                Store&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox5" runat="server" Width="335px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Find" Width="67px" />
            </p>
            <p>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </p>
        </div>
    </div>

</asp:Content>
