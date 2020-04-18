package lu.uppgift;

import java.rmi.RemoteException;
import java.util.Scanner;

import org.tempuri.WebServiceSoapProxy;

public class Test {

	public static void main(String[] args) {
		
		
		Scanner scan = new Scanner(System.in); 
		WebServiceSoapProxy proxy = new WebServiceSoapProxy();

		try {
			System.out.println("Please fill out document name: ");
			String str = scan.nextLine();
			System.out.println(proxy.getFile(str));
		}
		catch(RemoteException e) {
			e.printStackTrace();
		}

	}

}
