<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarPaciente.aspx.cs" Inherits="Laboratorio.Paginas.ModificarPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    MODIFICAR PACIENTE</p>
    <p>
        INGRESE CEDULA:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtcedula" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnbuscar" runat="server" onclick="btnbuscar_Click" 
            Text="Buscar" />
    </p>
    <p>
        <asp:Label ID="lbldatos" runat="server" Enabled="False"></asp:Label>
    </p>
    <p>
        <asp:CheckBox ID="cboxtelefono" runat="server" AutoPostBack="True" 
            oncheckedchanged="cboxtelefono_CheckedChanged" Text="Telefono" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txttelefono" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
    &nbsp;<asp:CheckBox ID="cboxdireccion" runat="server" AutoPostBack="True" 
            oncheckedchanged="cboxdireccion_CheckedChanged" Text="Direccion" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtdireccion" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
    &nbsp;<asp:CheckBox ID="cboxemail" runat="server" AutoPostBack="True" 
            oncheckedchanged="cboxemail_CheckedChanged" Text="Email" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtemail" runat="server" Enabled="False"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
    &nbsp;<asp:CheckBox ID="cboxfiliacion" runat="server" AutoPostBack="True" 
            oncheckedchanged="cboxfiliacion_CheckedChanged" Text="Filiacion" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlfiliacion" runat="server" Enabled="False" 
            Height="17px" onselectedindexchanged="ddlfiliacion_SelectedIndexChanged" 
            Width="134px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txtfiliacion" runat="server" Visible="False"></asp:TextBox>
    </p>
    <p>
        <asp:CheckBox ID="cboxbaja" runat="server" AutoPostBack="True" 
            Text="Dar de Baja" Visible="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="cboxalta" runat="server" AutoPostBack="True" 
            Text="Dar de Alta" Visible="False" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtestado" runat="server" Visible="False"></asp:TextBox>
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="btnaceptar" runat="server" ImageUrl="~/Iconos/aceptar.png" 
            onclick="btnaceptar_Click" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
