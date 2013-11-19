<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnviarResultados.aspx.cs" Inherits="Laboratorio.Paginas.PaginasLaboratorista.EnviarResultados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        ENVIO DE EMAIL</p>
    <p>
        ANALISIS:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlanalisis" runat="server" 
            onselectedindexchanged="ddlanalisis_SelectedIndexChanged" 
            AutoPostBack="True">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlcedula" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddlcedula_SelectedIndexChanged" Visible="False">
        </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        <asp:Button ID="btnbuscar" runat="server" onclick="btnbuscar_Click" 
            Text="Buscar Email" />
    </p>
    <p>
        EMAIL:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblmensaje" runat="server"></asp:Label>
    </p>
    <p>
        MENSAJE:&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        <asp:TextBox ID="txtmensaje" runat="server" Height="101px" TextMode="MultiLine" 
            Width="482px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnenviar" runat="server" onclick="btnenviar_Click" 
            Text="Enviar" />
        &nbsp;</p>
</asp:Content>
