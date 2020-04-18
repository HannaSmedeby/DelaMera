/**
 * WebService1Soap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface WebService1Soap extends java.rmi.Remote {
    public boolean create(java.lang.String initials, java.lang.String name, java.lang.String lastName, java.lang.String title, java.lang.String address, java.lang.String phoneNumber) throws java.rmi.RemoteException;
    public boolean update(java.lang.String id, java.lang.String name, java.lang.String lastName, java.lang.String title, java.lang.String address, java.lang.String phoneNumber) throws java.rmi.RemoteException;
    public boolean delete(java.lang.String id) throws java.rmi.RemoteException;
    public java.lang.String[][] read() throws java.rmi.RemoteException;
    public java.lang.String[] find(java.lang.String id) throws java.rmi.RemoteException;
}
