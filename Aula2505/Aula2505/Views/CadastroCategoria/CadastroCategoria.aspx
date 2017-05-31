<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCategoria.aspx.cs" Inherits="Aula2505.Views.CadastroCategoria.CadastroCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
    <br />
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNome" ErrorMessage="*Campo obrigatorio!"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
    <br />
    <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
    <br />
    <asp:CheckBox ID="cbAtivo" runat="server" />
    <asp:Label ID="lblAtivo" runat="server" Text="Ativo"></asp:Label>
    <br />
    <asp:Button ID="btnAdd" runat="server" Text="Adicionar" OnClick="btnSalvar_Click" />
    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnCancelar_Click" />
    <br />
    <asp:Button ID="btnLocalizar" runat="server" Text="Localizar" OnClick="btnLocalizar_Click" />
    <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
    <br />
    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
    <asp:Button ID="btnListar" runat="server" Text="Listar" OnClick="btnListar_Click" />
    <br />
    <asp:GridView ID="gdCategorias" runat="server"></asp:GridView>
</asp:Content>
