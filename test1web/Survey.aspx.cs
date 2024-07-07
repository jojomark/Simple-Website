using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace test1web
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public string results = "";
        public string opinion;
        public string msg = "<h2 style=\"text-align:center\">We appreciate your feedback! Please answer this survey to help us make better websites!</h2>";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uName"].ToString() == "guest") Response.Redirect("login.aspx");

            string fileName = "Database1.mdf";
            string tableName = "Survey";
            string sqlSelect = $"select * from {tableName}";

            results += "<table class = 'center'> <tr>";
            results += "<th style='text-align:center;'>Number of good</th>";
            results += "<th style='text-align:center;'>Number of ok</th>";
            results += "<th style='text-align:center;'>Number of bad</th>";
            results += "</tr> <tr>";
            results += $"<td style='text-align:center;'>{Application["good"]}</td>";
            results += $"<td style='text-align:center;'>{Application["ok"]}</td>";
            results += $"<td style='text-align:center;'>{Application["bad"]}</td>";
            results += "</tr> </table>";

            string sqlInsert = $"INSERT INTO {tableName} values ('{Session["uName"]}', '{opinion}')";
            string sqlCheck = $"select * from {tableName} where uName = '{Session["uName"]}'";

            if (!Helper.IsExist(fileName, sqlCheck))
            {
                if (this.IsPostBack)
                {
                    opinion = Request.Form["opinion"];
                    sqlInsert = $"INSERT INTO {tableName} values ('{Session["uName"]}', '{opinion}')";
                    if (opinion != null)
                    {
                        Application.Lock();
                        if (opinion == "good")
                        {
                            Application["good"] = (int)Application["good"] + 1;
                            Helper.DoQuery(fileName, sqlInsert);
                        }
                        else if (opinion == "ok")
                        {
                            Application["ok"] = (int)Application["ok"] + 1;
                            Helper.DoQuery(fileName, sqlInsert);
                        }
                        else if (opinion == "bad")
                        {
                            Application["bad"] = (int)Application["bad"] + 1;
                            Helper.DoQuery(fileName, sqlInsert);
                        }
                        Application.UnLock();
                    }
                    results = "";
                    results += "<table class = 'center'> <tr>";
                    results += "<th style='text-align:center;'>Number of good</th>";
                    results += "<th style='text-align:center;'>Number of ok</th>";
                    results += "<th style='text-align:center;'>Number of bad</th>";
                    results += "</tr> <tr>";
                    results += $"<td style='text-align:center;'>{Application["good"]}</td>";
                    results += $"<td style='text-align:center;'>{Application["ok"]}</td>";
                    results += $"<td style='text-align:center;'>{Application["bad"]}</td>";
                    results += "</tr> </table>";
                }
            }
            else msg = "<h2 style=\"text-align:center\">You have already answered this survey!</h2>";
        }
    }
}