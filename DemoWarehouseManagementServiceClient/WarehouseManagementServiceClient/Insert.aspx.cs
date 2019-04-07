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
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!TextBox1.Text.Equals("") || !TextBox2.Text.Equals("") || !TextBox3.Text.Equals("") || !TextBox4.Text.Equals("") || !TextBox5.Text.Equals("") || !TextBox6.Text.Equals(""))
            {
                Label1.Text = "";
                Warehouse ware = new Warehouse();
                // ware.SrNo = Int32.Parse(TextBox7.Text);
                string warehouseCity = TextBox1.Text;
                string warehouseName = TextBox2.Text;
                string companyName = TextBox3.Text;
                string itemName = TextBox4.Text;
                int quantity = Int32.Parse(TextBox5.Text);
                string location = TextBox6.Text;
                ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
                proxy.InsertDetails(warehouseCity,warehouseName,companyName,itemName,quantity,location);
                //GridView1.DataSource = ds;
                //GridView1.DataBind();
                // lblStatus.Text = "record updated";
                Response.Redirect("Default.aspx");
                //Server.Transfer("Default.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Please enter valid details";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Server.Transfer("Default.aspx");

        }
    }
}