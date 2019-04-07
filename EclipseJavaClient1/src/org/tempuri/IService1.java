/**
 * IService1.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface IService1 extends java.rmi.Remote {
    public void insertDetails(java.lang.String warehosueCity, java.lang.String warehouseName, java.lang.String companyName, java.lang.String itemName, java.lang.Integer quantity, java.lang.String location) throws java.rmi.RemoteException;
    public org.datacontract.schemas._2004._07.WarehouseManagementServiceApp1.Warehouse[] getDetails() throws java.rmi.RemoteException;
    public org.datacontract.schemas._2004._07.WarehouseManagementServiceApp1.Warehouse getDetailsById(java.lang.Integer srNo) throws java.rmi.RemoteException;
    public void updateDetails(java.lang.Integer srNo, java.lang.String warehouseCity, java.lang.String warehouseName, java.lang.String companyName, java.lang.String itemName, java.lang.Integer quantity, java.lang.String location) throws java.rmi.RemoteException;
    public void deleteDetails(java.lang.Integer srNo) throws java.rmi.RemoteException;
}
