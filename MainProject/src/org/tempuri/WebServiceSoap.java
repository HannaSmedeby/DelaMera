/**
 * WebServiceSoap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface WebServiceSoap extends java.rmi.Remote {
    public java.lang.String getFile(java.lang.String fileName) throws java.rmi.RemoteException;
    public org.tempuri.GetItemResponseGetItemResult getItem() throws java.rmi.RemoteException;
    public org.tempuri.GetLoanResponseGetLoanResult getLoan() throws java.rmi.RemoteException;
    public java.lang.String getItemForConsole() throws java.rmi.RemoteException;
    public java.lang.String getLoanForConsole() throws java.rmi.RemoteException;
}
