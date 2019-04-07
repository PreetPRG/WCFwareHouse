using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WarehouseManagementServiceApp1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void InsertDetails(string warehosueCity, string warehouseName, string companyName, string itemName, int quantity, string location);
        [OperationContract]
        List<Warehouse> GetDetails();
        [OperationContract]
        Warehouse GetDetailsById(int srNo);
        [OperationContract]
        void UpdateDetails(int srNo,string warehouseCity,string warehouseName,string companyName,string itemName,int quantity,string location);
        [OperationContract]
        void DeleteDetails(int srNo);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Warehouse
    {
        int _srNo;
        string _warehouseCity;
        string _warehouseName;
        string _companyName;
        string _itemName;
        int _quantity;
        string _location;

        [DataMember]
        public int srNo
        {
            get { return _srNo; }
            set { _srNo = value; }
        }
        [DataMember]
        public string warehouseCity
        {
            get { return _warehouseCity; }
            set { _warehouseCity = value; }
        }
        [DataMember]
        public string warehouseName
        {
            get { return _warehouseName; }
            set { _warehouseName = value; }
        }
        [DataMember]
        public string companyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        [DataMember]
        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        [DataMember]
        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        [DataMember]
        public string location
        {
            get { return _location; }
            set { _location = value; }
        }
    }

}
