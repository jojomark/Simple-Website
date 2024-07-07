using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test1web
{
    public partial class DeleteRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isAdmin"].ToString() == "1")
            {
                string uName = Request.QueryString["uName"].ToString();
                string fileName = "Database1.mdf";
                string tableName = "Users";
                string sqlDelete = $"DELETE FROM {tableName} WHERE uName = '{uName}'";
                Helper.DoQuery(fileName, sqlDelete);
                Response.Redirect("AdministrationPage.aspx");
            }
        }
    }
}