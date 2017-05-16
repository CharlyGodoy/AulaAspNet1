<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Aula1605.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Meu Primeiro Form</h1>

    <div class="row">
        <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    </div>

    <div class="row">
        <asp:Label ID="lblAtivo" runat="server" Text="Ativo"></asp:Label>
        <asp:CheckBox ID="chkAtivo" runat="server" />
    </div>

    <div class="row">
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" />
        <asp:Button ID="btnCancelar" runat="server" Text="btnCancelar" OnClick="btnCancelar_Click" />
    </div>

</asp:Content>
