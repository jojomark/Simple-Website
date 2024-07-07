using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test1web
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isAdmin"].ToString() == "1")
            {
                string uName = Request.QueryString["uName"].ToString();
                string fileName = "Database1.mdf";
                string tableName = "Users";
                string sqlChangeAdminPermissions = $"UPDATE {tableName} SET isAdmin = 1-isAdmin WHERE uName = '{uName}'";
                Helper.DoQuery(fileName, sqlChangeAdminPermissions);

                string sqlCheckIfAdmin = $"SELECT * FROM {tableName} WHERE uName = '{Session["uName"]}' AND isAdmin = '1'";
                if (!Helper.IsExist(fileName, sqlCheckIfAdmin)) Session["isAdmin"] = "0";

                Response.Redirect("AdministrationPage.aspx");
            }
        }
    }
}