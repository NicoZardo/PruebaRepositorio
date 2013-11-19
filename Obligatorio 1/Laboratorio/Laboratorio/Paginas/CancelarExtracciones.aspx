<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CancelarExtracciones.aspx.cs" Inherits="Laboratorio.Paginas.CancelarExtracciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    CANCELAR EXTRACCIONES</p>
<p>
    INGRESE CEDULA:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtcedula" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnbuscar" runat="server" onclick="btnbuscar_Click" 
        Text="Buscar" />
    </p>
<p>
    <asp:Label ID="lblinfo" runat="server"></asp:Label>
</p>
<p>
    <asp:Button ID="btnguardar" runat="server" Text="Cancelar" 
        onclick="btnguardar_Click" />
</p>
</asp:Content>
