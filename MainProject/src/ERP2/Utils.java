package ERP2;

import javax.swing.table.DefaultTableModel;

public class Utils {
    
    public static DefaultTableModel convertListToTable (String[][] list, DefaultTableModel tempTable) {
        
    //Set row count and column count to 0
    tempTable.setRowCount(0);
    tempTable.setColumnCount(0);
    
    // Add columns
    for (String c : list[0]) {
        tempTable.addColumn(c);
    }
    
    //Remove first row (column names)
    int r = list.length;
    int c = list[0].length;
    String[][] data= new String[r][c];
    for(int i = 0; i < r-1; i++) {
        for(int j = 0; j < c; j++) {
                data[i][j] = list[i+1][j];
        }
    }
    
    //Add rows
    for (String[] rowData : data) {
        tempTable.addRow(rowData);
    }
    
    return tempTable;

    }

}


