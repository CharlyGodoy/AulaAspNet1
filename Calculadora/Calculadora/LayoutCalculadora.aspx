<%@ Page Title="" Language="C#" MasterPageFile="~/Calculadora.Master" AutoEventWireup="true" CodeBehind="LayoutCalculadora.aspx.cs" Inherits="Calculadora.LayoutCalculadora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cabecalho" runat="server">
    <asp:TextBox ID="txtDisplay" runat="server" Text="Calculadora"></asp:TextBox>    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Principal" runat="server">
    
    <div class="row">
        <div class="col-md-6">
    <br />
    <asp:Button ID="btn1" runat="server" Text="1" OnClick="btn1_Click" /> 
    <asp:Button ID="btn2" runat="server" Text="2" OnClick="btn2_Click"/>
    <asp:Button ID="btn3" runat="server" Text="3" OnClick="btn3_Click"/>
    <br />
    <asp:Button ID="btn4" runat="server" Text="4" OnClick="btn4_Click"/>
    <asp:Button ID="btn5" runat="server" Text="5" OnClick="btn5_Click"/>
    <asp:Button ID="btn6" runat="server" Text="6" OnClick="btn6_Click"/>
    <br />
    <asp:Button ID="btn7" runat="server" Text="7" OnClick="btn7_Click"/>
    <asp:Button ID="btn8" runat="server" Text="8" OnClick="btn8_Click"/>
    <asp:Button ID="btn9" runat="server" Text="9" OnClick="btn9_Click"/>
    <br />
    <asp:Button ID="btnVirgula" runat="server" Text="," OnClick="btnVirgula_Click"/>
    <asp:Button ID="btn0" runat="server" Text="0" OnClick="btn0_Click"/>
    <asp:Button ID="btnIgual" runat="server" Text="=" OnClick="btnIgual_Click"/>
    <asp:Button ID="btnMais" runat="server" Text="+" OnClick="btnMais_Click"/>
    </div>
        </div>

</asp:Content>
