<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 543px;
        }
        .auto-style3 {
            width: 575px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Panel ID="Panel1" runat="server" GroupingText="Araba Satış Fiyatı" Height="125px">
                        &nbsp;
                        <br />
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        &nbsp; TL<br />
                        <br />
                    </asp:Panel>
                </td>
                <td class="auto-style3">
                    <asp:Panel ID="Panel2" runat="server" GroupingText="Aksesuar" Height="129px">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Hız Sabitleyici" />
                        <br />
                        <br />
                        <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Yol Bilgisayarı" />
                        <br />
                        <br />
                        <asp:CheckBox ID="CheckBox3" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Otomatik Vites" />
                    </asp:Panel>
                </td>
            </tr>
        </table>
    <div>
    
        Hız Sabitleyici 2000 TL , Yol Bilgisayarı 3000 TL , Otomatik Vites 5000 TL</div>
    </form>
</body>
</html>
