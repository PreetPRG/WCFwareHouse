package org.tempuri;

public class IService1Proxy implements org.tempuri.IService1 {
  private String _endpoint = null;
  private org.tempuri.IService1 iService1 = null;
  
  public IService1Proxy() {
    _initIService1Proxy();
  }
  
  public IService1Proxy(String endpoint) {
    _endpoint = endpoint;
    _initIService1Proxy();
  }
  
  private void _initIService1Proxy() {
    try {
      iService1 = (new org.tempuri.Service1Locator()).getBasicHttpBinding_IService1();
      if (iService1 != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)iService1)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)iService1)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (iService1 != null)
      ((javax.xml.rpc.Stub)iService1)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.IService1 getIService1() {
    if (iService1 == null)
      _initIService1Proxy();
    return iService1;
  }
  
  public void insertDetails(java.lang.String warehosueCity, java.lang.String warehouseName, java.lang.String companyName, java.lang.String itemName, java.lang.Integer quantity, java.lang.String location) throws java.rmi.RemoteException{
    if (iService1 == null)
      _initIService1Proxy();
    iService1.insertDetails(warehosueCity, warehouseName, companyName, itemName, quantity, location);
  }
  
  public org.datacontract.schemas._2004._07.WarehouseManagementServiceApp1.Warehouse[] getDetails() throws java.rmi.RemoteException{
    if (iService1 == null)
      _initIService1Proxy();
    return iService1.getDetails();
  }
  
  public org.datacontract.schemas._2004._07.WarehouseManagementServiceApp1.Warehouse getDetailsById(java.lang.Integer srNo) throws java.rmi.RemoteException{
    if (iService1 == null)
      _initIService1Proxy();
    return iService1.getDetailsById(srNo);
  }
  
  public void updateDetails(java.lang.Integer srNo, java.lang.String warehouseCity, java.lang.String warehouseName, java.lang.String companyName, java.lang.String itemName, java.lang.Integer quantity, java.lang.String location) throws java.rmi.RemoteException{
    if (iService1 == null)
      _initIService1Proxy();
    iService1.updateDetails(srNo, warehouseCity, warehouseName, companyName, itemName, quantity, location);
  }
  
  public void deleteDetails(java.lang.Integer srNo) throws java.rmi.RemoteException{
    if (iService1 == null)
      _initIService1Proxy();
    iService1.deleteDetails(srNo);
  }
  
  
}