<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThemCongViec.aspx.cs" Inherits="TLWebForm.GUI.ThemCongViec" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Tên công việc"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Mô tả công việc"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            <asp:Label ID="Label5" runat="server" Text="Loại công việc"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            </asp:RadioButtonList>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="File hoàn tất"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
    </form>
</body>
</html>
