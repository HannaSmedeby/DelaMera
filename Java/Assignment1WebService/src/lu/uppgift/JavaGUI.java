package lu.uppgift;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import org.tempuri.WebServiceSoapProxy;

import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.JLabel;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;
import java.awt.event.ActionEvent;

public class JavaGUI extends JFrame {

	private JPanel contentPane;
	private JTextField textField;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					JavaGUI frame = new JavaGUI();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public JavaGUI() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		textField = new JTextField();
		textField.setBounds(31, 48, 214, 20);
		contentPane.add(textField);
		textField.setColumns(10);
		
		final JLabel label1 = new JLabel("");
		label1.setBounds(31, 104, 232, 14);
		contentPane.add(label1);
		
		JButton btnGetDocument = new JButton("Get document");
		btnGetDocument.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				WebServiceSoapProxy proxy = new WebServiceSoapProxy();
				
				String str = "";
				String str1;
				str = textField.getText();
				try {
					str1 = proxy.getFile(str);
					label1.setText(str1);
				} catch (RemoteException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				
				
			}
		});
		btnGetDocument.setBounds(259, 47, 116, 23);
		contentPane.add(btnGetDocument);
		
		
		
		JLabel lblOutput = new JLabel("Output:");
		lblOutput.setBounds(31, 79, 46, 14);
		contentPane.add(lblOutput);
	
		
		JLabel lblPleaseFillOut = new JLabel("Please fill out document name:");
		lblPleaseFillOut.setBounds(31, 24, 232, 14);
		contentPane.add(lblPleaseFillOut);
	}
}
