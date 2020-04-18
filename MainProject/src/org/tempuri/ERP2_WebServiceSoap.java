/**
 * ERP2_WebServiceSoap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface ERP2_WebServiceSoap extends java.rmi.Remote {
    public java.lang.String[][] employeeContents(java.lang.String args) throws java.rmi.RemoteException;
    public java.lang.String[][] employeeRelatives() throws java.rmi.RemoteException;
    public java.lang.String[][] sickEmployees() throws java.rmi.RemoteException;
    public java.lang.String[][] mostSickEmployee() throws java.rmi.RemoteException;
    public java.lang.String[][] getAllKeys(java.lang.String args) throws java.rmi.RemoteException;
    public java.lang.String[][] allIndexes(java.lang.String args) throws java.rmi.RemoteException;
    public java.lang.String[][] allConstraints(java.lang.String args) throws java.rmi.RemoteException;
    public java.lang.String[][] allTableNames1() throws java.rmi.RemoteException;
    public java.lang.String[][] allTableNames2() throws java.rmi.RemoteException;
    public java.lang.String[][] allEmployeeColumns1() throws java.rmi.RemoteException;
    public java.lang.String[][] allEmployeeColumns2() throws java.rmi.RemoteException;
    public java.lang.String[] employeeTablesTableNames() throws java.rmi.RemoteException;
}
