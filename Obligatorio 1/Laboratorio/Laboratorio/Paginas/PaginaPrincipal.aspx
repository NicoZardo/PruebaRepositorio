<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="Laboratorio.Paginas.PaginaPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        PAGINA PRINCIPAL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        USUARIO ACTUAL&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtsesion" runat="server" BorderStyle="None" Enabled="False" 
            Width="155px"></asp:TextBox>
</p>
    <p>
        PAGO DE ANALISIS - INTRIDUZCA CEDULA&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtcedula" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnbuscar" runat="server" onclick="btnbuscar_Click" 
            Text="Buscar Analisis" />
</p>
    <p>
        <asp:Label ID="lblinfo" runat="server"></asp:Label>
</p>
    <p>
        <asp:Button ID="btnpago" runat="server" onclick="btnpago_Click" Text="Pagar" />
</p>
    <p>
        _____________________________________________________________________________________________________________________________________________________________</p>
    <p>
        USUARIO:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtusu" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblerror" runat="server"></asp:Label>
    </p>
    <p>
        CONTRASEÑA:&nbsp;&nbsp; 
        <asp:TextBox ID="txtcont" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btniniciar" runat="server" onclick="btniniciar_Click" 
            Text="Iniciar Sesion" />
    </p>
</asp:Content>
