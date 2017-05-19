<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calc1.aspx.cs" Inherits="Aula1805.Calc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <%--É necessario para não dar o refresh na tela.--%>
        <ContentTemplate>
            <%--É necessario dentro do UpdatePanel, pois o html só funciona dentro--%>

            <div class="row">
                <div class="col-md-2">
                    <asp:Label ID="lblValor1" runat="server" Text="Valor1"></asp:Label>
                    <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>                                                        
                </div>
                
                <div class="col-md-2">
                    <asp:Label ID="lblValor2" runat="server" Text="Valor2"></asp:Label>
                    <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>                    
                </div>
                
            </div>
            <div class="row">
                <div class="col-md-2">
                    <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
                    <asp:TextBox ID="txtResultaDO" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-2" style="margin-top:20px;">
                    <asp:Button ID="btnSomar" runat="server" Text="+" OnClick="btnSomar_Click" />
                    <asp:Button ID="btnIgual" runat="server" Text="=" OnClick="btnIgual_Click" />
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
