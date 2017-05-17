<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Aula1605.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Meu Primeiro Form</h1>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <%--É necessario para não dar o refresh na tela.--%>
        <ContentTemplate>
            <%--É necessario dentro do UpdatePanel, pois o html só funciona dentro--%>

            <div class="row">
                <div style="margin-left : 25px;">
                    <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNome" runat="server" ErrorMessage="Campo nome é obrigatorio!" ControlToValidate="txtNome"></asp:RequiredFieldValidator> <%--Faz o campo ser obrigatorio e coloca uma mensagem ao lado do TextBox--%>
                </div>
            </div>
            <div class="row" style="margin-top : 5px;">
                <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="row">
                <div style="margin-left : 33px;">
                    <asp:Label ID="lblAtivo" runat="server" Text="Ativo"></asp:Label>
                    <asp:CheckBox ID="chkAtivo" runat="server" />
                </div>
            </div>
            <div class="row" style="margin-top : 10px;">
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" class="btn btn-success" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" class="btn btn-danger" CausesValidation="false" /> <%--CausesValidation, se o botao faz validação ou nao--%>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
