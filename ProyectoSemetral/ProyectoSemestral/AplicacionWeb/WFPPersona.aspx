<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFPPersona.aspx.cs"  Inherits="AplicacionWeb.WFPPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<style type="text/css">
		#form1 {
			height: 137px;
		}
	</style>
</head>
<body style="height: 238px">
		 <form id="form1" runat="server">	
			 <div style="height: 156px">

				 <div>	id:
				 <asp:TextBox ID="TextBox6" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
				 </div>
				 <div>	nombre:
				 <asp:TextBox ID="TextBox1" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
				 </div>
				  <div>	Apellido paterno:
				 <asp:TextBox ID="TextBox2" runat="server" Height="16px"></asp:TextBox>
				 </div>
				  <div>	Apellido materno:
				 <asp:TextBox ID="TextBox3" runat="server" Height="16px"></asp:TextBox>
				 </div>
				  <div>	correo:
				 <asp:TextBox ID="TextBox4" runat="server" Height="16px"></asp:TextBox>
				 </div>
				  <div>	telefono:
				 <asp:TextBox ID="TextBox5" runat="server" Height="16px"></asp:TextBox>
				 </div>		 
			 
				

			 </div>
			 <div>
					<asp:Button ID="btnAgregar" runat="server" OnClick="Button1_Click" Text="Agregar" />
					<%--<asp:Button ID="btnEliminar" runat="server" OnClick="Button2_Click" Text="Eliminar" />--%>
					<%--<asp:Button ID="btnActualizar" runat="server" OnClick="Button3_Click" Text="Actualizar" />
					<asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="BtnBuscar_Click" />--%>
			 </div>
			 <div>


			 	<asp:ListBox ID="ListBox1" runat="server" Height="73px" Width="253px"></asp:ListBox>


			 </div>
			  <div>
					<%--<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />--%>
					<%--<asp:Button ID="btnEliminar" runat="server" OnClick="Button2_Click" Text="Eliminar" />--%>
					<%--<asp:Button ID="btnActualizar" runat="server" OnClick="Button3_Click" Text="Actualizar" />--%>
					<asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="BtnBuscar_Click" />
			 </div>
			
		</form>

    </body>
</html>
