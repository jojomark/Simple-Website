<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Survey.aspx.cs" Inherits="test1web.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Survey</title>
            <style>
        body{
            direction:ltr;
        }
        table, tr, td, th {
            border: 1px solid black;
            border-collapse: collapse;

        }
        .center {
            margin-left: auto;
            margin-right: auto;
        }
    </style>
</head>
<body>
    <%=msg %> <br />
    <form id="form1" runat="server" style="text-align:center;" onsubmit="return true;">
        <label for="opinion">What do you think of this website?</label>
        <select id="opinion" name="opinion" style="text-align:center;">
            <option value="good">Good</option>
            <option value="ok">Ok</option>
            <option value="bad">Bad</option>
        </select>
        <input type="submit" id="submit" name="submit" value="submit"/>
    </form>
    <h4 style="text-align:center;"><%=results %></h4>
    <br />
    <h3 style="text-align:center"><a href="MainPage.aspx">Back to main page</a></h3>
</body>
</html>
