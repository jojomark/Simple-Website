using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Security.Policy;

namespace test1web
{ 
        
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string msg = "This is a registration form.";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["submit"] != null)
            {
                string uName = Request.Form["uName"];
                string lName = Request.Form["lName"];
                string fName = Request.Form["fName"];
                string email = Request.Form["email"];
                string phone = Request.Form["phone"];
                int networth = Convert.ToInt32(Request.Form["networth"]);
                string birthdate = Request.Form["date"];

                string fileName = "Database1.mdf";
                string tableName = "Users";
                string sqlSelect = $"select * from {tableName} where uName = '{uName}'";
                if (Helper.IsExist(fileName, sqlSelect))
                {
                    msg = "This username is already taken";
                }
                else
                {
                    string sqlInsert = $"insert into {tableName} ";
                    sqlInsert += $"values ('{uName}', '{fName}', '{lName}', '{email}', '0', '{networth}', '{phone}', '{birthdate}')";

                    Helper.DoQuery(fileName, sqlInsert);
                    msg = "User added.";
                 }

                DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

                int Length = table.Rows.Count;
                if (Length == 0) msg = "there is no data to display";

            }
        }
    }
}