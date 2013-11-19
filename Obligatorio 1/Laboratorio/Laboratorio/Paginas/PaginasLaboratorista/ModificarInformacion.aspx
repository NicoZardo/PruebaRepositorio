<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarInformacion.aspx.cs" Inherits="Laboratorio.Paginas.PaginasLaboratorista.ModificarInformacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    MODIFICAR INFORMACION</p>
<p>
    INGRESE CEDULA:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtcedula" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnbuscar" runat="server" Text="Buscar" 
        onclick="btnbuscar_Click" />
</p>
<p>
    <asp:CheckBox ID="cboxdireccion" runat="server" AutoPostBack="True" 
        Text="DIRECCION" />
    :&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtdireccion" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    <asp:CheckBox ID="cboxtelefono" runat="server" AutoPostBack="True" 
        Text="TELEFONO" />
    :&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txttelefono" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    <asp:CheckBox ID="cboxemail" runat="server" AutoPostBack="True" Text="EMAIL" />
    :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtemail" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    <asp:CheckBox ID="cboxusuario" runat="server" AutoPostBack="True" 
        Text="USUARIO" />
    :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtusuario" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    <asp:CheckBox ID="cboxcont" runat="server" AutoPostBack="True" 
        Text="CONTRASEÑA" />
    :&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtcont" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    <asp:CheckBox ID="cboxdespedir" runat="server" AutoPostBack="True" 
        Text="DESPEDIR" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtestado" runat="server" Visible="False"></asp:TextBox>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="btnaceptar" runat="server" ImageUrl="~/Iconos/aceptar.png" 
        onclick="btnaceptar_Click" />
    &nbsp;</p>
</asp:Content>
