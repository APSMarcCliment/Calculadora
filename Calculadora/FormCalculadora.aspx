<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormCalculadora.aspx.cs" Inherits="Calculadora.FormCalculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="Calculos" runat="server" />
            <p><asp:Label ID="operacionLabel" runat="server" /></p>
            <p>
                <asp:Button ID="num7" runat="server" Text="7" OnClick="numberButtonClick7"/>
                <asp:Button ID="num8" runat="server" Text="8" OnClick="numberButtonClick8"/>
                <asp:Button ID="num9" runat="server" Text="9" OnClick="numberButtonClick9"/>
                <asp:Button ID="butMult" runat="server" Text="*" OnClick="multButtonClick"/>
            </p>
            <p>
                <asp:Button ID="num4" runat="server" Text="4" OnClick="numberButtonClick4"/>
                <asp:Button ID="num5" runat="server" Text="5" OnClick="numberButtonClick5"/>
                <asp:Button ID="num6" runat="server" Text="6" OnClick="numberButtonClick6"/>
                <asp:Button ID="butDiv" runat="server" Text="/" OnClick="divButtonClick"/>
            </p>
            <p>
                <asp:Button ID="num1" runat="server" Text="1" OnClick="numberButtonClick1"/>
                <asp:Button ID="num2" runat="server" Text="2" OnClick="numberButtonClick2"/>
                <asp:Button ID="num3" runat="server" Text="3" OnClick="numberButtonClick3"/>
                <asp:Button ID="butResta" runat="server" Text="-" OnClick="restaButtonClick"/>
            </p>
            <p>
                <asp:Button ID="butClear" runat="server" Text="C" OnClick="clearButtonClick"/>
                <asp:Button ID="num0" runat="server" Text="0" OnClick="numberButtonClick0"/>
                <asp:Button ID="butSum" runat="server" Text="+" OnClick="sumButtonClick"/>
                <asp:Button ID="butIgual" runat="server" Text="=" OnClick="equalsButtonClick"/>
            </p>
        </div>
    </form>
</body>
</html>
