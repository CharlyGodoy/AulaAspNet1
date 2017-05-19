<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calc2.aspx.cs" Inherits="Aula1805.Calc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblValor1" runat="server" Text="Valor1"></asp:Label>
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblValor2" runat="server" Text="Valor2"></asp:Label>
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="col-md-1">
                <asp:TextBox ID="txtValor1Soma" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-1" style="text-align: center;">
                <asp:Label ID="lblSoma" runat="server" Text="+"></asp:Label>
            </div>
            <div class="col-md-1">
                <asp:TextBox ID="txtValor2Soma" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-1" style="text-align: center;">
                <asp:Label ID="lblResSoma" runat="server" Text="="></asp:Label>
            </div>
            <div class="col-md-1">
                <asp:TextBox ID="txtResultadoSoma" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="row" style="margin-top: 8px;">
            <div class="col-md-1">
                <asp:TextBox ID="txtValor1Sub" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-1" style="text-align: center;">
                <asp:Label ID="lblSubtrair" runat="server" Text="-"></asp:Label>
            </div>
            <div class="col-md-1">
                <asp:TextBox ID="txtValor2Sub" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-1" style="text-align: center;">
                <asp:Label ID="lblResSub" runat="server" Text="="></asp:Label>
            </div>
            <div class="col-md-1">
                <asp:TextBox ID="txtResultadoSub" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="row" style="margin-top: 8px;">
            <div class="col-md-1">
                <asp:TextBox ID="txtValor1Mult" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-1" style="text-align: center;">
                <asp:Label ID="lblMultiplicar" runat="server" Text="*"></asp:Label>
            </div>
            <div class="col-md-1">
                <asp:TextBox ID="txtValor2Mult" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-1" style="text-align: center;">
                <asp:Label ID="lblResMult" runat="server" Text="="></asp:Label>
            </div>
            <div class="col-md-1">
                <asp:TextBox ID="txtResultadoMult" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="row" style="margin-top: 8px;">
            <div class="col-md-1">
                <asp:TextBox ID="txtValor1Div" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-1" style="text-align: center;">
                <asp:Label ID="lblDividir" runat="server" Text="÷"></asp:Label>
            </div>
            <div class="col-md-1">
                <asp:TextBox ID="txtValor2Div" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-1" style="text-align: center;">
                <asp:Label ID="lblResDiv" runat="server" Text="="></asp:Label>
            </div>
            <div class="col-md-1">
                <asp:TextBox ID="txtResultadoDiv" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>

</asp:Content>
