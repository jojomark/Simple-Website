using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace test1web
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            string fileName = "Database1.mdf";
            string tableName = "Survey";
            string sqlSelect = $"select * from {tableName}";
            DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

            int Length = table.Rows.Count;

            Application["good"] = 0;
            Application["ok"] = 0;
            Application["bad"] = 0;

            Application.Lock();
            for (int i = 0; i < Length; i++)
            {
                if (table.Rows[i]["vote"].ToString() == "good") Application["good"] = (int)Application["good"] + 1;
                if (table.Rows[i]["vote"].ToString() == "ok") Application["ok"] = (int)Application["ok"] + 1;
                if (table.Rows[i]["vote"].ToString() == "bad") Application["bad"] = (int)Application["bad"] + 1;
            }
            Application.UnLock();
        }
        void Session_Start(object sender, EventArgs e)
        {
            Session["uName"] = "guest";
            Session["isAdmin"] = "0";
        }
        void Session_End(object sender, EventArgs e)
        {
            Session["uName"] = "guest"; 
            Session["isAdmin"] = "0";
        }
    }
}