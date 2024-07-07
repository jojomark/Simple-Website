<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdministrationPage.aspx.cs" Inherits="test1web.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administration Page</title>
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
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <%=st %>
    <h3 style="text-align:center"><a href="MainPage.aspx">Back to main page</a></h3>
</body>
</html>
