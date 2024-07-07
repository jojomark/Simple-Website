<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStats.aspx.cs" Inherits="test1web.UpdateStats" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update information</title>
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
<body style="text-align: center" class="center">
    <h3><%=msg2 %></h3>
    <form method="post" runat="server" id="form1" onsubmit="return CheckForm();">
        <table class="center">
            <tr>
                <td> Username: </td>
                <td>
                    <input type="text" id="uName" name="uName" disabled ="disabled" value ="<% = Session["uName"]%>"/>
                </td>
            </tr>
            <tr>
                <td> Password: </td>
                <td>
                    <input type="password" id="lName" name="lName" pattern="\w{3,}" required="required" title="Password should have no special characters and be at least 3 characters long." value="<% = mlName %>"/>
                </td>
            </tr>
            <tr>
                <td> Verify password:  </td>
                <td>
                    <input type="password"; id="vLName"; name="vLName"; required="required"; value="<% = mlName %>"/>
                </td>
                <td> <input type="text"; id="mLName"; name="mLName"; disabled="disabled" style="display: none; background-color: silver; font-weight: bold"; /> </td>
                
            </tr>
            <tr>
                <td> First name: </td>
                <td>
                    <input type="text" id="fName" name="fName" pattern="\w{3,}" required="required" title="First name should have no special characters and be at least 3 characters long." value="<% = mfName %>"/>
                </td>
            </tr>
            <tr>
                <td> Email: </td>
                <td>
                    <input type="email" id="email" name="email" placeholder="someone@gmail.com" required="required" value="<% = memail %>"/>
                </td>
            </tr>
            <tr>
                <td> Phone: </td>
                <td>
                   <input type="tel"; id="phone"; name="phone"; title="Phone number should follow this pattern: 0xx-xxx-xxxx" pattern="[0-0]{1}[0-9]{2}-[0-9]{3}-[0-9]{4}" value="<% = mphone %>"" required="required"/>
                </td>
            </tr>
            <tr>
                <td> Date of birth: </td>
                <td> 
                    <input type="date"; id ="date"; name="date"; max="2015-01-01"; required="required"; value ="<%=birthdate2%>"/>
                </td>
            </tr>
            <tr>
                <td> Networth (money you have): </td>
                <td>
                    <input type="number"; id ="networth" name="networth"; required="required" value="<% = mnetworth %>"/>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <input type="submit" id="submit" name="submit" value="finish"/>
                </td>
            </tr>
        </table>
    </form>
    <h4><a href="MainPage.aspx">Back to main page.</a></h4>
    <script src= "Temp.js?v=1"></script>
</body>
</html>
