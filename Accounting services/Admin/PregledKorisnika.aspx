<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PregledKorisnika.aspx.cs" Inherits="Skola.Admin.UbacivanjeUcenika" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label>

        <div>
            <asp:GridView ID="gridView1" runat="server" CssClass="table-condensed" AllowSorting="true"></asp:GridView>
        </div>
    </form>
</body>
</html>
