using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WarehouseManagementServiceClient.ServiceReference1;

namespace WarehouseManagementServiceClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Warehouse ware = new Warehouse();
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            GridView1.DataSource = proxy.GetDetails();
            GridView1.DataBind();
            //GridView1.DataSource = ds;
            //GridView1.DataBind();
        }

        
        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Delete.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("Update.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Server.Transfer("Insert.aspx");
        }

       

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Server.Transfer("Search.aspx");

        }
    }
}