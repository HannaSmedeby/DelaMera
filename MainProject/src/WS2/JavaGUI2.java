package WS2;

import java.awt.BorderLayout;
import Homepage.HomeApp;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import org.tempuri.WebServiceSoapProxy;

import javax.swing.JTextField;
import javax.swing.JTextPane;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;
import java.awt.event.ActionEvent;
import javax.swing.JTextArea;
import javax.swing.JList;
import javax.swing.JScrollBar;
import javax.swing.JLabel;
import javax.swing.JScrollPane;

public class JavaGUI2 extends JFrame {

	private JPanel contentPane;

	public JFrame frame; 

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					JavaGUI2 frame = new JavaGUI2();
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
	public JavaGUI2() {
		
		setDefaultCloseOperation(JFrame.HIDE_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		//frame = new JFrame(); 
		this.setVisible(true); 
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(27, 82, 377, 147);
		contentPane.add(scrollPane);
		
		final JTextArea textArea = new JTextArea();
		scrollPane.setViewportView(textArea);
		
		JButton btnNewButton = new JButton("Get item");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				WebServiceSoapProxy proxy = new WebServiceSoapProxy();
				try {
					String s = proxy.getItemForConsole();
					textArea.setText(s);
				} catch (RemoteException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
		});
		btnNewButton.setBounds(31, 48, 89, 23);
		contentPane.add(btnNewButton);
		
		JButton button = new JButton("Get loan");
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				WebServiceSoapProxy proxy = new WebServiceSoapProxy();
				
				String s;
				try {
					s = proxy.getLoanForConsole();
					textArea.setText(s);
				} catch (RemoteException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				
			}
		});
		button.setBounds(149, 48, 89, 23);
		contentPane.add(button);
		
		JLabel lblPleaseChooseA = new JLabel("Please choose a table to populate:");
		lblPleaseChooseA.setBounds(31, 23, 233, 14);
		contentPane.add(lblPleaseChooseA);
		
		

		
		
		
		
		
		
		
		
		
		
		
	}

	
}
