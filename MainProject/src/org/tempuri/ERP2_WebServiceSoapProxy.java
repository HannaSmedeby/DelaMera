package org.tempuri;

public class ERP2_WebServiceSoapProxy implements org.tempuri.ERP2_WebServiceSoap {
  private String _endpoint = null;
  private org.tempuri.ERP2_WebServiceSoap eRP2_WebServiceSoap = null;
  
  public ERP2_WebServiceSoapProxy() {
    _initERP2_WebServiceSoapProxy();
  }
  
  public ERP2_WebServiceSoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initERP2_WebServiceSoapProxy();
  }
  
  private void _initERP2_WebServiceSoapProxy() {
    try {
      eRP2_WebServiceSoap = (new org.tempuri.ERP2_WebServiceLocator()).getERP2_WebServiceSoap();
      if (eRP2_WebServiceSoap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)eRP2_WebServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)eRP2_WebServiceSoap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (eRP2_WebServiceSoap != null)
      ((javax.xml.rpc.Stub)eRP2_WebServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.ERP2_WebServiceSoap getERP2_WebServiceSoap() {
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap;
  }
  
  public java.lang.String[][] employeeContents(java.lang.String args) throws java.rmi.RemoteException{
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap.employeeContents(args);
  }
  
  public java.lang.String[][] employeeRelatives() throws java.rmi.RemoteException{
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap.employeeRelatives();
  }
  
  public java.lang.String[][] sickEmployees() throws java.rmi.RemoteException{
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap.sickEmployees();
  }
  
  public java.lang.String[][] mostSickEmployee() throws java.rmi.RemoteException{
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap.mostSickEmployee();
  }
  
  public java.lang.String[][] getAllKeys(java.lang.String args) throws java.rmi.RemoteException{
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap.getAllKeys(args);
  }
  
  public java.lang.String[][] allIndexes(java.lang.String args) throws java.rmi.RemoteException{
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap.allIndexes(args);
  }
  
  public java.lang.String[][] allConstraints(java.lang.String args) throws java.rmi.RemoteException{
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap.allConstraints(args);
  }
  
  public java.lang.String[][] allTableNames1() throws java.rmi.RemoteException{
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap.allTableNames1();
  }
  
  public java.lang.String[][] allTableNames2() throws java.rmi.RemoteException{
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap.allTableNames2();
  }
  
  public java.lang.String[][] allEmployeeColumns1() throws java.rmi.RemoteException{
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap.allEmployeeColumns1();
  }
  
  public java.lang.String[][] allEmployeeColumns2() throws java.rmi.RemoteException{
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap.allEmployeeColumns2();
  }
  
  public java.lang.String[] employeeTablesTableNames() throws java.rmi.RemoteException{
    if (eRP2_WebServiceSoap == null)
      _initERP2_WebServiceSoapProxy();
    return eRP2_WebServiceSoap.employeeTablesTableNames();
  }
  
  
}