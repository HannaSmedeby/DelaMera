/**
 * ERP2_WebServiceLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class ERP2_WebServiceLocator extends org.apache.axis.client.Service implements org.tempuri.ERP2_WebService {

    public ERP2_WebServiceLocator() {
    }


    public ERP2_WebServiceLocator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public ERP2_WebServiceLocator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for ERP2_WebServiceSoap
    private java.lang.String ERP2_WebServiceSoap_address = "http://localhost:50414/ERP2_WebService.asmx";

    public java.lang.String getERP2_WebServiceSoapAddress() {
        return ERP2_WebServiceSoap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String ERP2_WebServiceSoapWSDDServiceName = "ERP2_WebServiceSoap";

    public java.lang.String getERP2_WebServiceSoapWSDDServiceName() {
        return ERP2_WebServiceSoapWSDDServiceName;
    }

    public void setERP2_WebServiceSoapWSDDServiceName(java.lang.String name) {
        ERP2_WebServiceSoapWSDDServiceName = name;
    }

    public org.tempuri.ERP2_WebServiceSoap getERP2_WebServiceSoap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(ERP2_WebServiceSoap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getERP2_WebServiceSoap(endpoint);
    }

    public org.tempuri.ERP2_WebServiceSoap getERP2_WebServiceSoap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            org.tempuri.ERP2_WebServiceSoapStub _stub = new org.tempuri.ERP2_WebServiceSoapStub(portAddress, this);
            _stub.setPortName(getERP2_WebServiceSoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setERP2_WebServiceSoapEndpointAddress(java.lang.String address) {
        ERP2_WebServiceSoap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (org.tempuri.ERP2_WebServiceSoap.class.isAssignableFrom(serviceEndpointInterface)) {
                org.tempuri.ERP2_WebServiceSoapStub _stub = new org.tempuri.ERP2_WebServiceSoapStub(new java.net.URL(ERP2_WebServiceSoap_address), this);
                _stub.setPortName(getERP2_WebServiceSoapWSDDServiceName());
                return _stub;
            }
        }
        catch (java.lang.Throwable t) {
            throw new javax.xml.rpc.ServiceException(t);
        }
        throw new javax.xml.rpc.ServiceException("There is no stub implementation for the interface:  " + (serviceEndpointInterface == null ? "null" : serviceEndpointInterface.getName()));
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(javax.xml.namespace.QName portName, Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        if (portName == null) {
            return getPort(serviceEndpointInterface);
        }
        java.lang.String inputPortName = portName.getLocalPart();
        if ("ERP2_WebServiceSoap".equals(inputPortName)) {
            return getERP2_WebServiceSoap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://tempuri.org/", "ERP2_WebService");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://tempuri.org/", "ERP2_WebServiceSoap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("ERP2_WebServiceSoap".equals(portName)) {
            setERP2_WebServiceSoapEndpointAddress(address);
        }
        else 
{ // Unknown Port Name
            throw new javax.xml.rpc.ServiceException(" Cannot set Endpoint Address for Unknown Port" + portName);
        }
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(javax.xml.namespace.QName portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        setEndpointAddress(portName.getLocalPart(), address);
    }

}
