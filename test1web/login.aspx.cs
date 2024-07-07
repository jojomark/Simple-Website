using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test1web
{
    public partial class login : System.Web.UI.Page
    {
        public string uNameExist = "";
        public string lNameExist = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["submit"] != null)
            {
                string uName = Request.Form["uName"];
                string lName = Request.Form["lName"];

                string fileName = "Database1.mdf";
                string tableName = "Users";
                string sqlSelectUName = $"select * from {tableName} where uName = '{uName}'";
                string sqlSelectLName = $"select * from {tableName} where lName = '{lName}' AND uName = '{uName}'";
                string sqlCheckAdmin = $"select * from {tableName} where uName = '{uName}' AND isAdmin = '1'";

                if (!Helper.IsExist(fileName, sqlSelectUName)) uNameExist = "This username doesn't exist";
                else if (!Helper.IsExist(fileName, sqlSelectLName)) lNameExist = "Last name is incorrect.";
                else
                {
                    Session["uName"] = uName;
                    if (Helper.IsExist(fileName, sqlCheckAdmin)) Session["isAdmin"] = '1';
                    else Session["isAdmin"] = '0';
                    Response.Redirect("MainPage.aspx");
                }
            }
        }
    }
}