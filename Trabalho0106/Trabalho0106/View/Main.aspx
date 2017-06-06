<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Trabalho0106.View.Main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cadastro de Genero</h1>
    <br />
    <asp:Label ID="lblNomeG" runat="server" Text="Nome"></asp:Label>
    <br />
    <asp:TextBox ID="txtNomeG" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNomeG" ErrorMessage="*Campo obrigatorio!" ValidationGroup="ValidGenero"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblDescricaoG" runat="server" Text="Descrição"></asp:Label>
    <br />
    <asp:TextBox ID="txtDescricaoG" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnAddG" runat="server" Text="Adicionar" OnClick="btnAddG_Click" ValidationGroup="ValidGenero" />
    <asp:Button ID="btnLimparG" runat="server" Text="Limpar" OnClick="btnLimparG_Click" ValidationGroup="ValidGenero"/>
    <asp:Button ID="btnLocalizarG" runat="server" Text="Localizar" OnClick="btnLocalizarG_Click" ValidationGroup="ValidGenero"/>
    <asp:Button ID="btnEditarG" runat="server" Text="Editar" OnClick="btnEditarG_Click" ValidationGroup="ValidGenero" Enabled="False"/>
    <asp:Button ID="btnExcluirG" runat="server" Text="Excluir" OnClick="btnExcluirG_Click" ValidationGroup="ValidGenero" Enabled="False"/>
    <br />
    <br />
    <asp:GridView ID="gdGenero" runat="server"></asp:GridView>

    <br />
    <br />
    <h1>Cadastro de Jogo</h1>
    <br />
        <asp:Label ID="lblNomeJ" runat="server" Text="Nome"></asp:Label>
    <br />
        <asp:TextBox ID="txtNomeJ" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNomeJ" ErrorMessage="*Campo obrigatorio!" ValidationGroup="ValJogo"></asp:RequiredFieldValidator>
    <br />
        <asp:Label ID="lblDescricaoJ" runat="server" Text="Descrição"></asp:Label>
    <br />
        <asp:TextBox ID="txtDescricaoJ" runat="server"></asp:TextBox>
    <br />
        <asp:Label ID="lblLancamento" runat="server" Text="Lancamento"></asp:Label>
    <br />
    <asp:TextBox ID="txtLancamento" runat="server"></asp:TextBox>
    <br />
        <asp:Label ID="lblGeneroEscolhido" runat="server" Text="Genero"></asp:Label>
    <br />
    <asp:DropDownList ID="ddpGenero" runat="server" DataTextField="Nome" DataValueField="Id"></asp:DropDownList> Só funciona para o botão Adicionar
    <br />
    <br />
    <asp:Button ID="btnAddJ" runat="server" Text="Adicionar" OnClick="btnAddJ_Click" ValidationGroup="ValJogo"/>
    <asp:Button ID="btnLimparJ" runat="server" Text="Limpar" OnClick="btnLimparJ_Click" ValidationGroup="ValJogo"/>
    <asp:Button ID="btnLocalizarJ" runat="server" Text="Localizar" OnClick="btnLocalizarJ_Click" ValidationGroup="ValJogo"/>
    <asp:Button ID="btnEditarJ" runat="server" Text="Editar" OnClick="btnEditarJ_Click" ValidationGroup="ValJogo" Enabled="False"/>
    <asp:Button ID="btnExcluirJ" runat="server" Text="Excluir" OnClick="btnExcluirJ_Click" ValidationGroup="ValJogo" Enabled="False"/>
    <br />
    <br />
    <asp:GridView ID="gdJogo" runat="server"></asp:GridView>

    <br />


</asp:Content>
