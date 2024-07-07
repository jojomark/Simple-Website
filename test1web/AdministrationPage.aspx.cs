using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace test1web
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public string st = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = "Database1.mdf";
            string tableName = "Users";
            string sqlSelect = $"select * from {tableName}";

            DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

            int Length = table.Rows.Count;
            
            if (Session["isAdmin"].ToString() == "1")
            {
              
                st += "<table class = 'center'> <tr>";
                st += "<th style='width:100px'>User name</th>";
                st += "<th style='width:100px'>First name</th>";
                st += "<th style='width:100px'>Password</th>";
                st += "<th style='width:100px'>Email</th>";
                st += "<th style='width:100px'>Phone</th>";
                st += "<th style='width:100px'>Birthdate</th>";
                st += "<th style='width:100px'>Networth</th>";
                st += "<th style='width:100px'>Is admin</th>";
                st += "<th style='width:100px'>Delete record</th>";
                st += "<th style='width:150px'>Change permissions</th>";
                st += "</tr>";
                for (int i = 0; i < Length; i++)
                {
                    string user = table.Rows[i]["uName"].ToString();

                    DateTime birthdate = (DateTime)table.Rows[i]["birthdate"];
                    string birthdate2 = birthdate.ToString("dd/MM/yyyy");

                    st += "<tr>";
                    st += "<td style='text-align:center;'>" + table.Rows[i]["uName"] + "</td>";
                    st += "<td style='text-align:center;'>" + table.Rows[i]["fName"] + "</td>";
                    st += "<td style='text-align:center;'>" + table.Rows[i]["lName"] + "</td>";
                    st += "<td style='text-align:center;'>" + table.Rows[i]["email"] + "</td>";
                    st += "<td style='text-align:center;'>" + table.Rows[i]["phone"] + "</td>";
                    st += "<td style='text-align:center;'>" + birthdate2 + "</td>";
                    st += "<td style='text-align:center;'>" + table.Rows[i]["networth"] + "</td>";
                    st += "<td style='text-align:center;'>" + table.Rows[i]["isAdmin"] + "</td>";
                    st += "<td style='text-align:center;'>" + "<a href='DeleteRecord.aspx?uName="+user+"'>[delete]</a>" + "</td> ";
                    st += "<td style='text-align:center;'>" + "<a href='MakeAdmin.aspx?uName=" +user + "'>[Change admin permissions]</a>" + "</td> ";
                }
                st += "</table>";
            }
            else st = "<h1 style='text-align:center;'> You don't have permission to view this page</h1>";
        }
    }
}