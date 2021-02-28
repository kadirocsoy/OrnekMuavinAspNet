<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResimEkleIslemi.aspx.cs" Inherits="OrnekMuavinAspNet.ResimEkleIslemi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="resim" runat="server" />
            <br /><br />
            <asp:Button ID="btnekle" runat="server" Text="Ekle" OnClick="btnekle_Click" />
        </div>
    </form>
</body>
</html>
