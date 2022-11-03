<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Answer.aspx.cs" Inherits="TestPerSec.Answer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><h2>ข้อ 1</h2></td>
                </tr>
                <tr>
                    <td colspan="2">เปลี่ยน Type ใน Codeก่อน Default เป็น string</td>
                </tr>
                <tr>
                    <td><b>ข้อ 1.1</b></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtAns11" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnsend11" runat="server" Text="ส่งข้อมูลข้อ 1.1" 
                            onclick="btnsend11_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lblans11" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><b>ข้อ 1.2</b></td>
                </tr>
                <tr>
                <td>
                        <asp:TextBox ID="txtAns12" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnsend12" runat="server" Text="ส่งข้อมูลข้อ 1.2"
                            onclick="btnsend12_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lblans12" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><b>ข้อ 1.3</b></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnsend13" runat="server" Text="ส่งข้อมูลข้อ 1.3" 
                            onclick="btnsend13_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lblans13" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><b>ข้อ 1.4</b></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnsend14" runat="server" Text="ส่งข้อมูลข้อ 1.4" 
                            onclick="btnsend14_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lblans14" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><b>ข้อ 1.5</b></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnsend15" runat="server" Text="ส่งข้อมูลข้อ 1.5" 
                            onclick="btnsend15_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lblans15" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><h2>ข้อ 2</h2></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtAns2" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnsend2" runat="server" Text="ส่งข้อมูลข้อ 2" 
                            onclick="btnsend2_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lblans2" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><h2>ข้อ 3</h2></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtAns3" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnsend3" runat="server" Text="ส่งข้อมูลข้อ 3" 
                            onclick="btnsend3_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lblans3" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><h2>ข้อ 4</h2></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtAns4" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnsend4" runat="server" Text="ส่งข้อมูลข้อ 4" 
                            onclick="btnsend4_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lblans4" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>