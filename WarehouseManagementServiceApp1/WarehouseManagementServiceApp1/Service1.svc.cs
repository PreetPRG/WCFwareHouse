using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WarehouseManagementServiceApp1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void DeleteDetails(int srNo)
        {
            //bool result;
            try
            {

                SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WarehouseManagement1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "DELETE FROM warehouse WHERE srNo=@srNo";
                cmd.Parameters.AddWithValue("@srNo", srNo);
                /*cmd.Parameters.AddWithValue("@warehouseCity", ware.WarehouseCity);
                cmd.Parameters.AddWithValue("@warehouseName", ware.WarehouseName);
                cmd.Parameters.AddWithValue("@companyName", ware.CompanyName);
                cmd.Parameters.AddWithValue("@itemName", ware.ItemName);
                cmd.Parameters.AddWithValue("@quantity", ware.Quantity);
                cmd.Parameters.AddWithValue("@location", ware.Location);*/
                if (cnn.State == System.Data.ConnectionState.Closed)
                {
                    cnn.Open();
                }
                cmd.ExecuteNonQuery();
                cnn.Close();
                //result = true;
                //return result;
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }
            //return result;
        }

        public List<Warehouse> GetDetails()
        {
            DataSet ds = new DataSet();
            try
            {
                //List<Warehouse> list = new List<Warehouse>();
                SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WarehouseManagement1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                string query = cmd.CommandText = "SELECT * FROM warehouse";
                SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }            //cmd.CommandText = "SELECT * FROM warehouse";
            List<Warehouse> list = new List<Warehouse>();
            foreach(DataRow datarow in ds.Tables[0].Rows)
            {
                Warehouse ware = new Warehouse();
                //var ware = new Warehouse();
                ware.srNo = Convert.ToInt32(datarow["srNo"]);
                ware.warehouseCity = Convert.ToString(datarow["warehouseCity"]);
                ware.warehouseName = Convert.ToString(datarow["warehouseName"]);
                ware.companyName = Convert.ToString(datarow["companyName"]);
                ware.itemName = Convert.ToString(datarow["itemName"]);
                ware.quantity = Convert.ToInt32(datarow["quantity"]);
                ware.location = Convert.ToString(datarow["location"]);
                list.Add(ware);
            }
           /* SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                var ware = new Warehouse();
                ware.WarehouseCity = rdr.GetString(1);
                ware.WarehouseName = rdr.GetString(2);
                ware.CompanyName = rdr.GetString(3);
                ware.ItemName = rdr.GetString(4);
                ware.Quantity = rdr.GetInt32(5);
                ware.Location = rdr.GetString(6);
                list.Add(ware);
            }
            //rdr.Close();
            cnn.Close();*/
            return list;
            
        }

        public Warehouse GetDetailsById(int srNo)
        {
            Warehouse ware = new Warehouse();
            DataSet ds = new DataSet();
            try
            {
                //List<Warehouse> list = new List<Warehouse>();
                SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WarehouseManagement1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                //cmd.CommandText = "DELETE FROM warehouse WHERE srNo=@srNo";
                string query = cmd.CommandText = "SELECT * FROM warehouse WHERE srNo=@srNo";
                cmd.Parameters.AddWithValue("@srNo", srNo);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }            //cmd.CommandText = "SELECT * FROM warehouse";
            //List<Warehouse> list = new List<Warehouse>();
            //DataRow datarow = ds.Tables[0].Rows;
            
                //Warehouse ware = new Warehouse();
                //var ware = new Warehouse();
                ware.srNo = Convert.ToInt32(ds.Tables[0].Rows[0]["srNo"]);
                ware.warehouseCity = Convert.ToString(ds.Tables[0].Rows[0]["warehouseCity"]);
                ware.warehouseName = Convert.ToString(ds.Tables[0].Rows[0]["warehouseName"]);
                ware.companyName = Convert.ToString(ds.Tables[0].Rows[0]["companyName"]);
                ware.itemName = Convert.ToString(ds.Tables[0].Rows[0]["itemName"]);
                ware.quantity = Convert.ToInt32(ds.Tables[0].Rows[0]["quantity"]);
                ware.location = Convert.ToString(ds.Tables[0].Rows[0]["location"]);
                //list.Add(ware);
            
            /* SqlDataReader rdr = cmd.ExecuteReader();
             while(rdr.Read())
             {
                 var ware = new Warehouse();
                 ware.WarehouseCity = rdr.GetString(1);
                 ware.WarehouseName = rdr.GetString(2);
                 ware.CompanyName = rdr.GetString(3);
                 ware.ItemName = rdr.GetString(4);
                 ware.Quantity = rdr.GetInt32(5);
                 ware.Location = rdr.GetString(6);
                 list.Add(ware);
             }
             //rdr.Close();
             cnn.Close();*/
            return ware;
        }

        public void InsertDetails(string warehouseCity, string warehouseName, string companyName, string itemName, int quantity, string location)
        {
            //string result;
            try
            {

                SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WarehouseManagement1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "INSERT INTO warehouse (warehouseCity,warehouseName,companyName,itemName,quantity,location) VALUES (@warehouseCity,@warehouseName,@companyName,@itemName,@quantity,@location)";
                //cmd.Parameters.AddWithValue("@srNo", ware.SrNo);
                cmd.Parameters.AddWithValue("@warehouseCity", warehouseCity);
                cmd.Parameters.AddWithValue("@warehouseName", warehouseName);
                cmd.Parameters.AddWithValue("@companyName", companyName);
                cmd.Parameters.AddWithValue("@itemName", itemName);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@location", location);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
               // result = "Record added";
                //return result;
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }
            //return result;
        }

        public void UpdateDetails(int srNo, string warehouseCity, string warehouseName, string companyName, string itemName, int quantity, string location)
        {
           //string result;
            try
            {

                SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WarehouseManagement1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "UPDATE warehouse SET warehouseCity=@warehouseCity,warehouseName=@warehouseName,companyName=@companyName,itemName=@itemName,quantity=@quantity,location=@location WHERE srNo=@srNo";
                cmd.Parameters.AddWithValue("@srNo", srNo);
                cmd.Parameters.AddWithValue("@warehouseCity", warehouseCity);
                cmd.Parameters.AddWithValue("@warehouseName", warehouseName);
                cmd.Parameters.AddWithValue("@companyName", companyName);
                cmd.Parameters.AddWithValue("@itemName", itemName);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@location", location);
                cnn.Open();
                /*if (cnn.State == System.Data.ConnectionState.Closed)
                {
                   
                }*/
                cmd.ExecuteNonQuery();
                /*if (status == 1)
                {
                    result = "Record updated";
                }
                else
                {
                    result = "record not updated";
                }*/
                cnn.Close();
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }
            //return result;
        }
    }
}
