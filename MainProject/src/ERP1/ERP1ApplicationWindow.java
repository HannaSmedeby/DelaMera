package ERP1;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.table.DefaultTableModel;

import ERP1.Controller;
import ERP1.Utils;

import javax.swing.JButton;
import javax.swing.JScrollPane;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTextArea;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import Homepage.HomeApp;

import java.awt.Font;
import java.awt.Color;

public class ERP1ApplicationWindow {

    public JFrame frame;
    private JTextField textField_Id;
    private JTextField textField_Name;
    private JTextField textField_LastName;
    private JTextField textField_Address;
    private JTextField textField_PhoneNumber;
    private JTextField textField_Title;
    private JTextField textField_IdDelete;
    private DefaultTableModel defaultTableModel;    
    Controller con = new Controller();
    
    private JTable table_showAll;
    private JScrollPane scrollPane_showAll_1;

    /**
     * Launch the application.
     */
    public static void main(String[] args) {
        EventQueue.invokeLater(new Runnable() {
            public void run() {
                try {
                    ERP1ApplicationWindow window = new ERP1ApplicationWindow();
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
    public ERP1ApplicationWindow() {
        initialize();
    }

    /**
     * Initialize the contents of the frame.
     */
    private void initialize() {
        frame = new JFrame();
        frame.setBounds(100, 100, 808, 491);
        frame.setDefaultCloseOperation(JFrame.HIDE_ON_CLOSE);
        frame.getContentPane().setLayout(null);
        
        final JLabel createResponseLbl = new JLabel("");
        createResponseLbl.setBounds(9, 334, 231, 35);
        frame.getContentPane().add(createResponseLbl);
        
        
        final JLabel removeResponseLbl = new JLabel("");
        removeResponseLbl.setBounds(269, 79, 291, 14);
        frame.getContentPane().add(removeResponseLbl);
        
        JLabel lblId = new JLabel("Id:");
        lblId.setBounds(72, 119, 14, 14);
        frame.getContentPane().add(lblId);
        
        JLabel lblName = new JLabel("Name:");
        lblName.setBounds(55, 144, 79, 14);
        frame.getContentPane().add(lblName);
        
        JLabel lblLastName = new JLabel("Last name:");
        lblLastName.setBounds(30, 169, 89, 14);
        frame.getContentPane().add(lblLastName);
        
        JLabel lblAdress = new JLabel("Address:");
        lblAdress.setBounds(40, 194, 94, 14);
        frame.getContentPane().add(lblAdress);
        
        JLabel lblPhoneNumber = new JLabel("Phone number:");
        lblPhoneNumber.setBounds(13, 219, 106, 14);
        frame.getContentPane().add(lblPhoneNumber);
        
        JLabel lblTitle = new JLabel("Title:");
        lblTitle.setBounds(62, 246, 57, 17);
        frame.getContentPane().add(lblTitle);
        
        textField_Id = new JTextField();
        textField_Id.setBounds(108, 119, 100, 20);
        frame.getContentPane().add(textField_Id);
        textField_Id.setColumns(10);
        
        textField_Name = new JTextField();
        textField_Name.setColumns(10);
        textField_Name.setBounds(108, 144, 100, 20);
        frame.getContentPane().add(textField_Name);
        
        textField_LastName = new JTextField();
        textField_LastName.setBounds(108, 172, 100, 20);
        frame.getContentPane().add(textField_LastName);
        textField_LastName.setColumns(10);
        
        textField_Address = new JTextField();
        textField_Address.setBounds(108, 197, 100, 20);
        frame.getContentPane().add(textField_Address);
        textField_Address.setColumns(10);
        
        textField_PhoneNumber = new JTextField();
        textField_PhoneNumber.setBounds(108, 222, 100, 20);
        frame.getContentPane().add(textField_PhoneNumber);
        textField_PhoneNumber.setColumns(10);
        
        textField_Title = new JTextField();
        textField_Title.setBounds(108, 247, 100, 20);
        frame.getContentPane().add(textField_Title);
        textField_Title.setColumns(10);
        
        JButton btnCreate = new JButton("Create");
        btnCreate.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                String id = textField_Id.getText();
                String name = textField_Name.getText();
                String lastName = textField_LastName.getText();
                String address = textField_Address.getText();
                String title = textField_Title.getText();
                String phoneNbr = textField_PhoneNumber.getText();
                
                createResponseLbl.setText(null);
                removeResponseLbl.setText(null);
                
                if(id.isEmpty() || name.isEmpty() || lastName.isEmpty() || address.isEmpty() || title.isEmpty()
                        || phoneNbr.isEmpty())
                {
                    createResponseLbl.setText("Please fill in all information");
                } else 
                {
                    boolean b = con.Create(id, name, lastName, title, address, phoneNbr);
                    
                    if(b == true)
                    {
                        createResponseLbl.setText("Employee " + id + " was added to database");
                        textField_Id.setText(null);
                        textField_Name.setText(null);
                        textField_LastName.setText(null);
                        textField_Address.setText(null);
                        textField_Title.setText(null);
                        textField_PhoneNumber.setText(null);
    
                    } else {
                        createResponseLbl.setText("Something went wrong, please try again.");
                    }
                }        
            }
        });
        btnCreate.setBounds(118, 278, 89, 23);
        frame.getContentPane().add(btnCreate);
        
        JButton btnUpdate = new JButton("Update");
        btnUpdate.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                
                String id = textField_Id.getText();
                String name = textField_Name.getText();
                String lastName = textField_LastName.getText();
                String address = textField_Address.getText();
                String title = textField_Title.getText();
                String phoneNbr = textField_PhoneNumber.getText();
                
                createResponseLbl.setText(null);
                removeResponseLbl.setText(null);
                
                if(id.isEmpty() || name.isEmpty() || lastName.isEmpty() || address.isEmpty() || title.isEmpty()
                        || phoneNbr.isEmpty())
                {
                    createResponseLbl.setText("Please fill in all information");
                } else 
                {
                    boolean b = con.Update(id, name, lastName, title, address, phoneNbr);
                    
                    if(b == true)
                    {
                        createResponseLbl.setText("Employee " + id + " was updated.");
                        textField_Id.setText(null);
                        textField_Name.setText(null);
                        textField_LastName.setText(null);
                        textField_Address.setText(null);
                        textField_Title.setText(null);
                        textField_PhoneNumber.setText(null);
    
                    } else {
                        createResponseLbl.setText("Something went wrong, please try again.");
                    }
                }        
            }
                
        });
        btnUpdate.setBounds(119, 306, 89, 23);
        frame.getContentPane().add(btnUpdate);
        
        JLabel lbl_id = new JLabel("Id:");
        lbl_id.setBounds(296, 54, 14, 14);
        frame.getContentPane().add(lbl_id);
        
        textField_IdDelete = new JTextField();
        textField_IdDelete.setBounds(328, 51, 114, 20);
        frame.getContentPane().add(textField_IdDelete);
        textField_IdDelete.setColumns(10);
        
        JButton btn_Delete = new JButton("Delete");
        btn_Delete.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                removeResponseLbl.setText(null);
                createResponseLbl.setText(null);
                
                String id = textField_IdDelete.getText();
                
                if(id.isEmpty())
                {
                    removeResponseLbl.setText("Please fill in id number");    
                } else 
                {
                    Boolean b = con.Delete(id);
                    
                    if(b == (true))
                    {
                        removeResponseLbl.setText("Employee " + id + " was deleted." );
                        textField_IdDelete.setText(null);
                    } else 
                    {
                        removeResponseLbl.setText("Something went wrong, please try again.");
                    }
                }
                
                
            }    
        });
        btn_Delete.setBounds(452, 50, 89, 23);
        frame.getContentPane().add(btn_Delete);
        
        
        JPanel panel_showAll = new JPanel();
        panel_showAll.setBounds(250, 119, 500, 286);
        frame.getContentPane().add(panel_showAll);
        
        table_showAll = new JTable();
        panel_showAll.add(table_showAll);
        final DefaultTableModel model = new DefaultTableModel();

        //Add Columns Table


        table_showAll = new JTable(model);
        
        table_showAll.setEnabled(false);
        JScrollPane scrollPane_showAll = new JScrollPane(table_showAll);
        scrollPane_showAll.setBounds(250, 119, 500, 286);
        

        frame.getContentPane().add(scrollPane_showAll);
        
        
        JButton btnShowAll = new JButton("Show all");
        btnShowAll.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent arg0) {
            
                
                String[][] tempList = con.Read();
                
                table_showAll = new JTable(Utils.convertListToTable(tempList, model));
            }
        });
        btnShowAll.setBounds(661, 85, 89, 23);
        frame.getContentPane().add(btnShowAll);
        
        JLabel lblEmployeeTable = new JLabel("Employee Table");
        lblEmployeeTable.setForeground(Color.BLUE);
        lblEmployeeTable.setFont(new Font("Palatino Linotype", Font.PLAIN, 25));
        lblEmployeeTable.setBounds(13, 11, 231, 28);
        frame.getContentPane().add(lblEmployeeTable);
        
        JLabel lblCreateAndUpdate = new JLabel("Create and update Employee");
        lblCreateAndUpdate.setFont(new Font("Palatino Linotype", Font.PLAIN, 14));
        lblCreateAndUpdate.setBounds(13, 83, 222, 28);
        frame.getContentPane().add(lblCreateAndUpdate);
        
        JLabel removeLbl = new JLabel("Delete employee");
        removeLbl.setFont(new Font("Palatino Linotype", Font.PLAIN, 14));
        removeLbl.setBounds(269, 14, 137, 28);
        frame.getContentPane().add(removeLbl);
        
        


    }
}


