package org.tempuri;

public class WebService1SoapProxy implements org.tempuri.WebService1Soap {
  private String _endpoint = null;
  private org.tempuri.WebService1Soap webService1Soap = null;
  
  public WebService1SoapProxy() {
    _initWebService1SoapProxy();
  }
  
  public WebService1SoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initWebService1SoapProxy();
  }
  
  private void _initWebService1SoapProxy() {
    try {
      webService1Soap = (new org.tempuri.WebService1Locator()).getWebService1Soap();
      if (webService1Soap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)webService1Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)webService1Soap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (webService1Soap != null)
      ((javax.xml.rpc.Stub)webService1Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.WebService1Soap getWebService1Soap() {
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap;
  }
  
  public boolean create(java.lang.String initials, java.lang.String name, java.lang.String lastName, java.lang.String title, java.lang.String address, java.lang.String phoneNumber) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.create(initials, name, lastName, title, address, phoneNumber);
  }
  
  public boolean update(java.lang.String id, java.lang.String name, java.lang.String lastName, java.lang.String title, java.lang.String address, java.lang.String phoneNumber) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.update(id, name, lastName, title, address, phoneNumber);
  }
  
  public boolean delete(java.lang.String id) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.delete(id);
  }
  
  public java.lang.String[][] read() throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.read();
  }
  
  public java.lang.String[] find(java.lang.String id) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.find(id);
  }
  
  
}