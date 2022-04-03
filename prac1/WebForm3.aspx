<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="prac1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<asp:TextBox ID="TextBox1" runat="server" Width="102px"></asp:TextBox>
		<p>
			<asp:RadioButton ID="Sugar" GroupName="R" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Сахар" />
			<asp:RadioButton ID="Grechka" GroupName="R" runat="server" Text="Гречка" />
			<asp:RadioButton ID="Eggs" GroupName="R" runat="server" Text="Яйца" />
		</p>
		<asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
			<asp:ListItem>MAYOT</asp:ListItem>
			<asp:ListItem>OG BUDA</asp:ListItem>
			<asp:ListItem>SODALUV</asp:ListItem>
		</asp:ListBox>
		<br />
		<asp:DropDownList ID="DropDownList1" runat="server">
			<asp:ListItem>SAMSUNG</asp:ListItem>
			<asp:ListItem>XIAOMI</asp:ListItem>
			<asp:ListItem>APPLE</asp:ListItem>
		</asp:DropDownList>
		<br />
		<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
		<br />
		<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
