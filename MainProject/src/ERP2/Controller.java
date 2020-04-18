package ERP2;

import java.rmi.RemoteException;

import javax.swing.table.DefaultTableModel;

import org.tempuri.ERP2_WebServiceSoapProxy;

public class Controller {
    
    private org.tempuri.ERP2_WebServiceSoapProxy client = new org.tempuri.ERP2_WebServiceSoapProxy();
    ExceptionHandler exceptionHandler = new ExceptionHandler();
    
    //DATA METHODS
    
    public DefaultTableModel employeeContents(String args, DefaultTableModel tableModel){
        try {
            return Utils.convertListToTable(client.employeeContents(args), tableModel);
        }
        catch(RemoteException rE) {
            exceptionHandler.exceptionMessage(rE);
            return null;
        }
    }
    
    public DefaultTableModel employeeRelatives(DefaultTableModel tableModel) {
        try {
            return Utils.convertListToTable(client.employeeRelatives(), tableModel);
        }
        catch (RemoteException rE) {
            exceptionHandler.exceptionMessage(rE);
            return null;
        }
    }
    
    public DefaultTableModel sickEmployees(DefaultTableModel tableModel) {
        try {
            return Utils.convertListToTable(client.sickEmployees(), tableModel);
        }
        catch (RemoteException rE) {
            exceptionHandler.exceptionMessage(rE);
            return null;
        }
    }
    
    public DefaultTableModel mostSickEmployee(DefaultTableModel tableModel) {
        try {
            return Utils.convertListToTable(client.mostSickEmployee(), tableModel);
        }
        catch (RemoteException rE) {
            exceptionHandler.exceptionMessage(rE);
            return null;
        }
    }
    
    public DefaultTableModel getAllKeys(DefaultTableModel tableModel, String args) {
        try {
            return Utils.convertListToTable(client.getAllKeys(args), tableModel);
        }
        catch (RemoteException rE) {
            exceptionHandler.exceptionMessage(rE);
            return null;
        }
    }
    
    //METADATA METHODS
    
    public DefaultTableModel allIndexes (DefaultTableModel tableModel, String args) {
        try {
            return Utils.convertListToTable(client.allIndexes(args), tableModel);
        }
        catch (RemoteException rE) {
            exceptionHandler.exceptionMessage(rE);
            return null;
        }
    }
    
    public DefaultTableModel allConstraints (DefaultTableModel tableModel, String args) {
        try {
            return Utils.convertListToTable(client.allConstraints(args), tableModel);
        }
        catch (RemoteException rE) {
            exceptionHandler.exceptionMessage(rE);
            return null;
        }
    }
    
    public DefaultTableModel allTableNames1 (DefaultTableModel tableModel) {
        try {
            return Utils.convertListToTable(client.allTableNames1(), tableModel);
        }
        catch (RemoteException rE) {
            exceptionHandler.exceptionMessage(rE);
            return null;
        }
    }
    
    public DefaultTableModel allTableNames2 (DefaultTableModel tableModel) {
        try {
            return Utils.convertListToTable(client.allTableNames2(), tableModel);
        }
        catch (RemoteException rE) {
            exceptionHandler.exceptionMessage(rE);
            return null;
        }
    }
    
    public DefaultTableModel allEmployeeColumns1 (DefaultTableModel tableModel) {
        try {
            return Utils.convertListToTable(client.allEmployeeColumns1(), tableModel);
        }
        catch (RemoteException rE) {
            exceptionHandler.exceptionMessage(rE);
            return null;
        }
    }
    
    public DefaultTableModel allEmployeeColumns2 (DefaultTableModel tableModel) {
        try {
            return Utils.convertListToTable(client.allEmployeeColumns2(), tableModel);
        }
        catch (RemoteException rE) {
            exceptionHandler.exceptionMessage(rE);
            return null;
        }
    }
    
    //HEJ
    
    // ALL EMPLOYEE TABLE'S TABLE NAMES
    public String[] allEmployeeTables() {
        try {
            return client.employeeTablesTableNames();
        }
        catch (RemoteException rE) {
            exceptionHandler.exceptionMessage(rE);
            return null;
        }
    }
}


