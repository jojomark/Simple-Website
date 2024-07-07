<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="test1web.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>Login</title>
    <style>
        body{
            direction:ltr;
        }
        table, tr {
            border: 1px solid black;
            border-collapse: collapse;

        }
        .center {
            margin-left: auto;
            margin-right: auto;
        }
    </style>
</head>
<body style="text-align: center">
     <h3>This is a login form. You are not logged in.</h3>
    <form id="form2" runat="server" class ="center" onsubmit="return CheckForm();">
                <table class="center">
            <tr>
                <td> Username: </td>
                <td>
                    <input type="text" id="uName" name="uName"/>
                </td>
                <td>
                    <%= uNameExist %><input type="text"; id="muName"; style="display:none; background-color:silver; font-weight:bold;" disabled="disabled";/>
                </td>

            </tr>
            <tr>
                <td> Password: </td>
                <td>
                    <input type="password" id="lName" name="lName"/>
                </td>
                <td>
                    <%= lNameExist %><input type="text"; id="mlName"; style="display:none; background-color:silver; font-weight:bold;" disabled="disabled";/>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <input type="submit" id="submit" name="submit" value="finish"/>
                </td>
            </tr>
        </table>
    </form>
    <h4><a href="WebForm1.aspx">Go to registration form</a></h4>
    <script src="LoginJS.js?v=1"></script>
</body>
</html>
