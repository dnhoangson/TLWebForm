<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="TLWebForm.GUI.NhanVien.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 82px;
            width: 420px;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">

            <asp:PlaceHolder ID="placeholder" runat="server" />

        </div>
    </form>
    
    <p>
        <textarea id="TextArea1" name="S1"></textarea></p>
    
</body>
</html>
