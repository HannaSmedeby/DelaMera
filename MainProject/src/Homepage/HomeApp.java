package Homepage;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import ERP2.JavaApplication;
import ERP1.ERP1ApplicationWindow;
import WS2.JavaGUI2;
import WS1.JavaGUI1;

public class HomeApp extends JFrame {

	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					HomeApp frame = new HomeApp();
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
	public HomeApp() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 340, 380);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JButton btnWebService1 = new JButton("Web Service Assignment 1");
		btnWebService1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				JavaGUI1 jG1 = new JavaGUI1(); 
				jG1.frame.setVisible(true); 
			}
		});
		btnWebService1.setBounds(47, 33, 220, 40);
		contentPane.add(btnWebService1);
		
		JButton btnWebService2 = new JButton("Web Service Assignment 2");
		btnWebService2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				JavaGUI2 jG2 = new JavaGUI2(); 
				jG2.frame.setVisible(true); 
				
			
			}
		});
		btnWebService2.setBounds(47, 97, 220, 40);
		contentPane.add(btnWebService2);
		
		JButton btnErpAssignment1 = new JButton("ERP Assignment 1");
		btnErpAssignment1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				ERP1ApplicationWindow aW = new ERP1ApplicationWindow();
				aW.frame.setVisible(true); 
				
			}
		});
		btnErpAssignment1.setBounds(47, 160, 220, 40);
		contentPane.add(btnErpAssignment1);
		
		JButton btnErpAssignment2 = new JButton("ERP Assignment 2");
		btnErpAssignment2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				JavaApplication jA = new JavaApplication(); 
				jA.frame.setVisible(true); 
			}
		});
		btnErpAssignment2.setBounds(47, 226, 220, 40);
		contentPane.add(btnErpAssignment2);
		
		
		
		
	}
}
