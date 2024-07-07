<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="test1web.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main</title>
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
        img{
            transition: ease-out 0.4s;
        }
        img:hover{
            transform: scale(1.08);
        }
    </style>
</head>
<body style ="text-align:center">

    <div style="float: right"><p>*hover over any image for cool effect!*</p></div>

    <%string content = ""; %>
    <%string AdminPages = ""; %>

    <h1 style ="margin-left: 270px">Hello, <%=Session["uName"].ToString() %><%if (Session["isAdmin"].ToString() == "1") content = ", you are an admin.";%><%=content %></h1> 
    <a href="disconnect.aspx">[Disconnect] </a><%if (Session["isAdmin"].ToString() == "1") AdminPages = "<a href='AdministrationPage.aspx'</a>[Administration Page]"; %><%=AdminPages%>
    <a href="UpdateStats.aspx">[Update information]</a>
    <a href="Survey.aspx">[Survey]</a>

    <br /> <br /> <br /> <br /> <br />

    <h1>This is a website for the top three video games ever made, by Eitan Ben Ari.</h1>
    <br />
    <div style="float: right;">
        <img src="images/realheart.png" /></div>
    <div style="float: left;">
        <img src="images/realheart.png" /></div>
    <h2 style="color: darkred">No. 3: Undertale.</h2> 
    <br />
    <p style="color:darkred">Undertale is a 2015 2D role-playing video game created by American indie developer Toby Fox. 
        The player controls a child who has fallen into the Underground: a large, secluded region under the surface of the
        Earth, separated by a magical barrier. The player meets various monsters during the journey back to the surface, 
        although some monsters might engage the player in a fight. The combat system involves the player navigating through
        mini-bullet hell attacks by the opponent. They can opt to pacify or subdue monsters in order to spare them instead
        of killing them. These choices affect the game, with the dialogue, 
        characters, and story changing based on outcomes.</p>
    <a href="Undertale.html">[Read more]</a> <a href="https://store.steampowered.com/app/391540/Undertale/">[Buy the game]</a>

    <br /><br /><br /><br /><br /><br /><br />

    <h2 style="color:cornflowerblue"> No.2: Rocket league.</h2>
    <div style="float: left;">
        <img src="images/rocket%20league%20car.png" /></div>
    <div style="float: right; transform: scaleX(-1)">
        <img src="images/rocket%20league%20car.png"/></div>
    <br />
    <p style="color:cornflowerblue">Rocket League is a vehicular soccer video game developed and published by Psyonix. 
        Described as "soccer, but with rocket-powered cars", Rocket League has up to eight players assigned to 
        each of the two teams, using rocket-powered vehicles to hit a ball into their opponent's goal and score 
        points over the course of a match. The game includes single-player and multiplayer modes that can be 
        played both locally and online, including cross-platform play between all versions. Later updates for 
        the game enabled the ability to modify core rules and added new game modes, including ones based on ice 
        hockey and basketball.
    </p>
    <a href="RocketLeague.html">[Read more]</a> <a href="https://store.epicgames.com/en-US/p/rocket-league">[Download for free]</a>

    <br /><br /><br /><br /><br /><br /><br />

    <h2 style="color:darkgreen;">No.1: Minecraft</h2>
     <div style="float: left;">
         <img src="images/minecraft.png" /></div>
    <div style="float: right; transform: scaleX(-1)">
        <img src="images/minecraft.png" /></div>
    <br />
    <p style="color: darkgreen;">Minecraft is a sandbox game developed by Mojang Studios. The game was created 
        by Markus "Notch" Persson in the Java programming language. Following several early private testing versions, 
        it was first made public in May 2009 before being fully released in November 2011, with Notch stepping down 
        and Jens "Jeb" Bergensten taking over development. Minecraft is the best-selling video game in history, 
        with over 238 million copies sold and nearly 140 million monthly active players as of 2021 and has been 
        ported to several platforms.</p>
    <a href="Minecraft.html">[Read more]</a> <a href="https://www.microsoft.com/en-ms/p/minecraft-java-bedrock-edition-for-pc/9nxp44l49shj?activetab=pivot:overviewtab">[Buy the game]</a>

</body>
</html>
