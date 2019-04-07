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
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!TextBox7.Text.Equals(""))
            {
                
                Label7.Visible = false;
                Label7.Text = "";
                Warehouse ware = new Warehouse();
                int srNo = Int32.Parse(TextBox7.Text);
                ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
                //DetailsView1.DataSource = proxy.GetDetailsById(srNo);
                ware = proxy.GetDetailsById(srNo);
                Label8.Visible = true;
                TextBox8.Visible = true;
                Label9.Visible = true;
                TextBox9.Visible = true;
                Label10.Visible = true;
                TextBox10.Visible = true;
                Label11.Visible = true;
                TextBox11.Visible = true;
                Label12.Visible = true;
                TextBox12.Visible = true;

                //DetailsView1.DataSource = ware;
                //DetailsView1.DataBind();
                Button3.Visible = true;
                Button4.Visible = true;
                /*GridView1.DataBind();
                /*TextBox1.Visible = true;
                Label2.Visible = true;
                TextBox2.Visible = true;
                Label3.Visible = true;
                TextBox3.Visible = true;
                Label4.Visible = true;
                TextBox4.Visible = true;
                Label5.Visible = true;
                TextBox5.Visible = true;
                Label6.Visible = true;
                TextBox6.Visible = true;
                //btnSubmit.Visible = true;
                /*TextBox1.Text = ds.Tables[0].Rows[0]["warehouseCity"].ToString();
                TextBox2.Text = ds.Tables[0].Rows[0]["warehouseName"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["companyName"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["itemName"].ToString();
                TextBox5.Text = ds.Tables[0].Rows[0]["quantity"].ToString();
                TextBox6.Text = ds.Tables[0].Rows[0]["location"].ToString();*/
                TextBox8.Text = ware.warehouseCity;
                TextBox9.Text = ware.warehouseName;
                TextBox10.Text = ware.companyName;
                TextBox11.Text = ware.itemName;
                TextBox12.Text = ware.quantity.ToString();
                TextBox13.Text = ware.location;

            

            }
            else
            {
                Label7.Visible = true;
                Label7.Text = "Please enter ID";
            }
        }

       
        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Default.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (!TextBox7.Text.Equals(""))
            {
                int srNo = Int32.Parse(TextBox7.Text);
                // ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
                //proxy.DeleteDetails(srNo);
                //Response.Redirect("Default.aspx");
                Server.Transfer("Delete.aspx");
            }
            else
            {
                Label7.Visible = true;
                Label7.Text = "Please enter ID";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (!TextBox7.Text.Equals(""))
            {
                int srNo = Int32.Parse(TextBox7.Text);
                // ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
                //proxy.DeleteDetails(srNo);
                //Response.Redirect("Default.aspx");
                Server.Transfer("Update.aspx");
            }
            else
            {
                Label7.Visible = true;
                Label7.Text = "Please enter ID";
            }
        }
    }
}