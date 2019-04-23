<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 200px;
        }
        .body{
            align-content:center;
        }
    </style>
</head>
<body class="body">
    <h1 style="align-content:center">Login Page</h1>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Username:</td>
                    <td><asp:TextBox ID="TextBox1" runat="server" Width="248px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td><asp:TextBox ID="TextBox2" runat="server" Width="248px"></asp:TextBox></td>
                </tr>
                
            </table>
            
            
        </div>
        
        
        <p class="auto-style1">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        </p>
    </form>
</body>
</html>
