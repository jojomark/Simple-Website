using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace test1web
{
    public partial class UpdateStats : System.Web.UI.Page
    {
        public string msg2 = "This is an update form.";
        public string mfName = "";
        public string mlName = "";
        public string memail = "";
        public string mphone = "";
        public DateTime mbirthdate = DateTime.Now;
        public string birthdate2 = "2000-02-02";
        public int mnetworth = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uName"].ToString() == "guest") Response.Redirect("login.aspx");
            string fileName = "Database1.mdf";
            string tableName = "Users";
            string sqlSelect = $"select * from {tableName} where uName = '{Session["uName"]}'";
            DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);
            mfName = table.Rows[0]["fName"].ToString();
            mlName = table.Rows[0]["lName"].ToString();
            memail = table.Rows[0]["email"].ToString();
            mphone = table.Rows[0]["phone"].ToString();
            mbirthdate = (DateTime)table.Rows[0]["birthdate"];
            birthdate2 = mbirthdate.ToString("yyyy-MM-dd");
            mnetworth = Convert.ToInt32(table.Rows[0]["networth"]);
            if (Request.Form["submit"] != null)
            {
                mfName = Request.Form["fName"];
                mlName = Request.Form["lName"];
                memail = Request.Form["email"];
                mphone = Request.Form["phone"];
                mnetworth = Convert.ToInt32(Request.Form["networth"]);
                birthdate2 = Request.Form["date"];

                string sqlUpdate = $"UPDATE {tableName} SET fName = '{mfName}', lName = '{mlName}', email = '{memail}', networth = '{mnetworth}', phone = '{mphone}', birthdate = '{mbirthdate}' WHERE uName = '{Session["uName"]}'";
                Helper.DoQuery(fileName, sqlUpdate);
                msg2 = "Information updated.";
            }
        }
    }
}