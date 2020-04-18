package ERP2;

import java.awt.Color;
import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;



public class JavaApplication {
    
    private Controller controller;

    public JFrame frame;
    
    private JTabbedPane tabs;
    private JPanel dataContainer, metadataContainer;
    private DefaultTableModel dataModel, empMetaModel, metadataModel;
    private JTable dataTable, empMetaTable, metadataTable;
    private JScrollPane dataScrollPane, empMetaScrollPane, metadataScrollPane;
    private JComboBox<String> querySelection, empTableSelection, empMetaSelection, metaSelection;    
    private JButton displayData, displayTables, displayMeta;
    private JLabel dataTableLbl, empMetaTableLbl, dataSelectionLbl, empMetaSelectionLbl, metaTableLbl, metaSelectionLbl, errorLbl, empErrorLbl;

    /**
     * Launch the application.
     */
    public static void main(String[] args) {
        EventQueue.invokeLater(new Runnable() {
            public void run() {
                try {
                    JavaApplication window = new JavaApplication();
                    window.frame.setVisible(true);
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
    }

    /**
     * Create the application.
     */
    public JavaApplication() {
        controller = new Controller();
        initialize();
        handleView();


    }

    /**
     * Initialize the contents of the frame.
     */
    private void initialize() {
        frame = new JFrame();
        frame.setVisible(true);
        frame.setBounds(100, 100, 1000, 600);
        

        tabs = new JTabbedPane();
        
        //Create datamodels
        dataModel = new DefaultTableModel();
        empMetaModel = new DefaultTableModel();
        metadataModel = new DefaultTableModel();
        
        //Create tables
        dataTable = new JTable(dataModel);
        dataTable.setAutoResizeMode(JTable.AUTO_RESIZE_OFF);
        empMetaTable = new JTable(empMetaModel);
        metadataTable = new JTable(metadataModel);
        
        /*  Scroll panes */
        
        //Create data scroll pane, where queries and data table contents will be displayed
        dataScrollPane = new JScrollPane(dataTable, JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED, JScrollPane.HORIZONTAL_SCROLLBAR_AS_NEEDED);
        dataScrollPane.setBounds(20, 30, 650, 300);
        
        //Create emp meta scroll pane, where metadata of employee tables will be displayed
        empMetaScrollPane = new JScrollPane(empMetaTable);
        empMetaScrollPane.setBounds(20, 360, 650, 150);
        
        //Create metadata scroll pane, where metadata from the database will be displayed
        metadataScrollPane = new JScrollPane(metadataTable);
        metadataScrollPane.setBounds(20, 30, 650, 480);
        
        /*  Buttons  */
        
        //Create 'Display data' button
        displayData = new JButton("Display data");
        displayData.setBounds(850, 100, 115, 30);
        
        //Create 'Display tables' button
        displayTables = new JButton("Display tables");
        displayTables.setBounds(850, 480, 115, 30);
        
        //Create 'Display metadata' button
        displayMeta = new JButton("Display metadata");
        displayMeta.setBounds(830, 110, 135, 30);
        
        
        /*  Combo boxes  */
        
        //Create query selection combobox
        String[] queryStrings = {"", "Employees and their relatives", "Sick employees 2004", "Most abscent employee"};
        querySelection = new JComboBox<String>(queryStrings);
        querySelection.setBounds(700, 60, 265, 30);
        
        //Create emp table selection combobox, user chooses
        //which employee table to display content and metadata from
        String [] empTableStrings = controller.allEmployeeTables();
        empTableSelection = new JComboBox<String>(empTableStrings);
        empTableSelection.setBounds(700, 400, 265, 30);
        
        //Create emp meta selection combobox, user chooses which metadata to display
        //from chosen employee table
        String [] empMetaStrings = {"", "All keys", "All indexes", "All constraints"};
        empMetaSelection = new JComboBox<String>(empMetaStrings);
        empMetaSelection.setBounds(700, 440, 265, 30);
        
        //Create metadata selection combobox, user chooses what metadata from the database to display
        String [] metaStrings = {"", "All keys", "All indexes", "All constraints", "All table names 1", "All table names 2", "Employee columns 1", "Employee columns 2"};
        metaSelection = new JComboBox<String>(metaStrings);
        metaSelection.setBounds(700, 70, 265, 30);
        
        
        /*  Labels  */
        dataTableLbl = new JLabel("Employee table");
        dataTableLbl.setBounds(20, 10, 150, 15);
        
        empMetaTableLbl = new JLabel("Employee metadata table");
        empMetaTableLbl.setBounds(20, 340, 150, 15);
        
        dataSelectionLbl = new JLabel("<html>Choose which query to execute</html>");
        dataSelectionLbl.setBounds(700, 30, 270, 25);
        
        empMetaSelectionLbl = new JLabel("<html>Choose table and metadata query to display a table's content and metadata</html>");
        empMetaSelectionLbl.setBounds(700, 350, 265, 45);
        
        metaTableLbl = new JLabel("Metadata table");
        metaTableLbl.setBounds(20, 10, 150, 15);
        
        metaSelectionLbl = new JLabel("<html>Choose what metadata to display</html>");
        metaSelectionLbl.setBounds(700, 30, 265, 30);
        
        errorLbl = new JLabel();
        errorLbl.setBounds(700, 140, 150, 15);
        errorLbl.setForeground(Color.red);
        
        empErrorLbl = new JLabel();
        empErrorLbl.setBounds(700, 140, 150, 15);
        empErrorLbl.setForeground(Color.red);
                
        
        /*  Containers  */
        
        dataContainer = new JPanel();
        dataContainer.setLayout(null);
        
        metadataContainer = new JPanel();
        metadataContainer.setLayout(null);

        
        /*  Add tabs to tab pane  */
        
        tabs.addTab("Employee tables", dataContainer);
        tabs.addTab("Metadata table", metadataContainer);
        
        
        /*  Add components to data container  */
        
        dataContainer.add(querySelection);
        dataContainer.add(empTableSelection);
        dataContainer.add(empMetaSelection);    
        
        dataContainer.add(displayData);
        dataContainer.add(displayTables);        
    
        dataContainer.add(dataScrollPane);
        dataContainer.add(empMetaScrollPane);
        
        dataContainer.add(dataTableLbl);
        dataContainer.add(empMetaTableLbl);
        dataContainer.add(dataSelectionLbl);
        dataContainer.add(empMetaSelectionLbl);
        dataContainer.add(errorLbl);
        
        
        /*  Add components to metadata container  */
        
        metadataContainer.add(metaSelection);
        metadataContainer.add(metadataScrollPane);
        metadataContainer.add(displayMeta);
        metadataContainer.add(metaTableLbl);
        metadataContainer.add(metaSelectionLbl);
        metadataContainer.add(empErrorLbl);
        
        
        /*  Add tabs to frame  */
        
        frame.add(tabs);
                
        frame.setDefaultCloseOperation(JFrame.HIDE_ON_CLOSE);                
    }
    
    private void handleView() {
        
        displayData.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                switch (querySelection.getSelectedIndex()) {
                    case 0:
                    	errorLbl.setBounds(700, 140, 150, 15);
                        errorLbl.setText("Please pick a query");
                        return;
                    case 1:
                    	errorLbl.setText("");
                        System.out.println("du valde emp relatives");
                        dataTable = new JTable(controller.employeeRelatives(dataModel));
                        return;
                    case 2:
                    	errorLbl.setText("");
                        dataTable = new JTable(controller.sickEmployees(dataModel));
                        return;
                    case 3:
                    	errorLbl.setText("");
                        dataTable = new JTable(controller.mostSickEmployee(dataModel));
                        return;
                }    
            }
        });
        
        displayTables.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {            
                    String table = empTableSelection.getSelectedItem().toString();                
                    dataTable = new JTable(controller.employeeContents(table, dataModel));
                    
                    switch (empMetaSelection.getSelectedIndex()) {
                        case 0:
                        	errorLbl.setBounds(700, 480, 115, 30);
                        	errorLbl.setText("Please pick a query");
                            return;
                        case 1:
                        	errorLbl.setText("");
                            empMetaTable = new JTable(controller.getAllKeys(empMetaModel, table));
                            return;
                        case 2:
                        	errorLbl.setText("");
                            empMetaTable = new JTable(controller.allIndexes(empMetaModel, table));
                            return;
                        case 3:
                        	errorLbl.setText("");
                            empMetaTable = new JTable(controller.allConstraints(empMetaModel, table));
                            return;    
                    }                    
            }
        });
        
        displayMeta.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                switch (metaSelection.getSelectedIndex()) {
                    case 0:
                        empErrorLbl.setText("Please pick a query");
                        return;
                    case 1:
                    	empErrorLbl.setText("");
                        metadataTable = new JTable(controller.getAllKeys(metadataModel, null));
                        return;
                    case 2:
                    	empErrorLbl.setText("");
                        metadataTable = new JTable(controller.allIndexes(metadataModel, null));
                        return;
                    case 3:
                    	empErrorLbl.setText("");
                        metadataTable = new JTable(controller.allConstraints(metadataModel, null));
                        return;    
                    case 4:
                    	empErrorLbl.setText("");
                        metadataTable = new JTable(controller.allTableNames1(metadataModel));
                        return;
                    case 5:
                    	empErrorLbl.setText("");
                        metadataTable = new JTable(controller.allTableNames2(metadataModel));
                        return;
                    case 6:
                    	empErrorLbl.setText("");
                        metadataTable = new JTable(controller.allEmployeeColumns1(metadataModel));
                        return;
                    case 7:
                    	empErrorLbl.setText("");
                        metadataTable = new JTable(controller.allEmployeeColumns2(metadataModel));
                        return;
                }
            }
        });
        
    }
    
    


}


