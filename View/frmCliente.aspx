﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCliente.aspx.cs" Inherits="Facturas_proyecto.View.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>MIKE</title>
    </head>
    <body>
         <form id="form1" runat="server">
            <div>
                <asp:Label ID="lb1Nombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txbNombre" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lb2Direccion" runat="server" Text="Direccion"></asp:Label>
                <asp:TextBox ID="txbDireccion" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lb3Telefono" runat="server" Text="Telefono"></asp:Label>
                <asp:TextBox ID="txbTelefono" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lbRFC" runat="server" Text="RFC"></asp:Label>
                <asp:TextBox ID="txbRfc" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lbEmail" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="txbEmail" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lbFechaNacimiento" runat="server" Text="FechaNacimiento"></asp:Label>
                <asp:TextBox ID="txbFechaNacimiento" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnInsertar" runat="server" Text="Crear" OnClick="btnInsertar_Click" />
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                <asp:Button ID="bntLimpiar" runat="server" Text="Limpiar" />
            </div>
            <asp:GridView ID="GridClientes" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
         </form>

    </body>

</html>