<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevaExtraccion.aspx.cs" Inherits="Laboratorio.Paginas.NuevaExtraccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    PEDIDOS DE EXTRACCION</p>
    <p>
        INGRESE CEDULA DE PACIENTE:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtcedula" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnbuscar" runat="server" onclick="btnbuscar_Click" 
            Text="Buscar" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Nombre
        <asp:TextBox ID="txtnombre" runat="server" BorderStyle="None" Enabled="False" 
            Width="109px"></asp:TextBox>
        , apellido
        <asp:TextBox ID="txtapellido" runat="server" BorderStyle="None" Enabled="False" 
            Width="111px"></asp:TextBox>
        , telefono
        <asp:TextBox ID="txttelefono" runat="server" BorderStyle="None" Enabled="False"></asp:TextBox>
        , direccion
        <asp:TextBox ID="txtdireccion" runat="server" BorderStyle="None" 
            Enabled="False" Width="177px"></asp:TextBox>
        </p>
    <p>
        &nbsp;</p>
    <p>
        FECHA DE EXTRACCION:&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txtfec" runat="server" style="width: 128px" Enabled="False"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnfecha" runat="server" onclick="btnfecha_Click" 
            Text="Cargar Fecha" />
    </p>
    <p>
        TIPO DE ANALISIS:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlanalisis" runat="server" AutoPostBack="True" 
            Height="22px" onselectedindexchanged="ddlanalisis_SelectedIndexChanged" 
            Width="147px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlid" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddlid_SelectedIndexChanged" Visible="False">
        </asp:DropDownList>
    </p>
    <p>
        MUESTRA:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txtmuestra" runat="server" Enabled="False"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="btnacepatar" runat="server" Height="51px" 
            ImageUrl="~/Iconos/aceptar.png" onclick="btnacepatar_Click" Width="51px" />
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
