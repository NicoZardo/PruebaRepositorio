<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaInicio.aspx.cs" Inherits="Laboratorio.Paginas.Paginas_Laboratoristas.PaginaInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        PAGINA INICIO -ESTADISTICAS-</p>
    <p>
        CANTIDAD DE SERVICIOS REALIZADOS&nbsp;&nbsp;&nbsp; 
        <asp:Button ID="btncantserv" runat="server" onclick="btncantserv_Click" 
            Text="Buscar" />
    </p>
    <p>
        <asp:Label ID="lblinfo1" runat="server"></asp:Label>
    </p>
    <p>
        TOTAL COBRADO A PARTICULARES E INSTITUCIONES MEDICAS&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btntotalcobrado" runat="server" onclick="btntotalcobrado_Click" 
            Text="Buscar" />
    </p>
    <p>
        <asp:Label ID="lblinfo2" runat="server"></asp:Label>
    </p>
    <p>
        CANTIDAD DE SERVICIOS REALIZADOS POR UN 
        LABORATORISTA EN UN PERIODO</p>
    <p>
        INGRESE CEDULA:
        <asp:DropDownList ID="ddlcedula" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddlcedula_SelectedIndexChanged">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DESDE:
        <asp:TextBox ID="txtdesdecant" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; HASTA:&nbsp;<asp:TextBox ID="txthastacant" 
            runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; dd/mm/aaaa&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnemp" runat="server" onclick="btnemp_Click" Text="Buscar" />
    </p>
    <p>
        <asp:Label ID="lblinfo3" runat="server"></asp:Label>
    </p>
    <p>
        COSTO DE MATERIALES UTILIZADOS EN UN PERIODO&nbsp;&nbsp;&nbsp; DESDE: 
        <asp:TextBox ID="txtdesdecosto" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; HASTA:
        <asp:TextBox ID="txthastacosto" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btncosto" runat="server" onclick="btncosto_Click" 
            Text="Buscar" />
    </p>
    <p>
        <asp:Label ID="lblinfo4" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
