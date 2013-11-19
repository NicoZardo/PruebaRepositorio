<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoAnalisis.aspx.cs" Inherits="Laboratorio.Paginas.Paginas_Laboratoristas.Analisis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        ANALISIS</p>
    <p>
        SELECCIONE UNA EXTRACCION PENDIENTE:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlextraccion" runat="server" Height="21px" Width="171px" 
            AutoPostBack="True" 
            onselectedindexchanged="ddlextraccion_SelectedIndexChanged">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="ddlid" runat="server" 
            AutoPostBack="True" onselectedindexchanged="ddlid_SelectedIndexChanged" 
            Visible="False">
        </asp:DropDownList>
    </p>
    <p>
        NOMBRE PACIENTE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtnombre" runat="server" Enabled="False" AutoPostBack="True"></asp:TextBox>
    </p>
    <p>
        APELLIDO PACIENTE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txtapellido" runat="server" Enabled="False" 
            AutoPostBack="True"></asp:TextBox>
    </p>
    <p>
        CEDULA PACIENTE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtcedula" runat="server" Enabled="False" AutoPostBack="True"></asp:TextBox>
    </p>
    <p>
        TIPO DE ANALISIS:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtanalisis" runat="server" Enabled="False" 
            AutoPostBack="True"></asp:TextBox>
    </p>
    <p>
        FECHA DE ANALISIS:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtfecha" runat="server" Enabled="False"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnfecha" runat="server" onclick="btnfecha_Click" 
            Text="Cargar Fecha" />
    &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtestado" runat="server" Visible="False" AutoPostBack="True"></asp:TextBox>
    </p>
    <p>
        PRECIO POR ANALISIS:&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txtprecioanalisis" runat="server" Enabled="False" 
            AutoPostBack="True"></asp:TextBox>
    </p>
    <p>
        RESULTADO:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txtresultado" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblmensaje" runat="server"></asp:Label>
    </p>
    <p>
        COSTO MATERIALES:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txtmateriales" runat="server"></asp:TextBox>
    </p>
    <p>
        IMPORTE TOTAL:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txttotal" runat="server" Enabled="False" AutoPostBack="True"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btncalcular" runat="server" onclick="btncalcular_Click" 
            Text="Calcular" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="btnaceptar" runat="server" 
            ImageUrl="~/Iconos/aceptar.png" onclick="btnaceptar_Click" />
    </p>
    <p>
        &nbsp;</p>
    </asp:Content>
