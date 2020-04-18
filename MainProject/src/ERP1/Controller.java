package ERP1;
import java.rmi.RemoteException;
import org.tempuri.WebService1SoapProxy;

public class Controller {

        // TODO Auto-generated method stub

        WebService1SoapProxy soap = new WebService1SoapProxy();
        ExceptionHandler e = new ExceptionHandler();
        
        public Controller() {}
        
        public boolean Create(String id, String name, String lastName, String title, String address, String phoneNbr ) 
        {
            boolean b = false; 
            try
            {
                b = soap.create(id, name, lastName, title, address, phoneNbr);
                return b;
                
            } catch (RemoteException rE) {
                e.ExceptionMessage(rE);
                return false;
            }
            
        }
        
        public boolean Delete(String id) {
            boolean b = false;
            
            
            try {
                b = soap.delete(id);
                return b;
            }catch(RemoteException rE) {
                e.ExceptionMessage(rE);
                return false; 
            }
        }
        public boolean Update(String id, String name, String lastName, String title, String address, String phoneNbr )
        {
            boolean b = false; 
            try
            {
                b = soap.update(id, name, lastName, title, address, phoneNbr);
                return b;
                
            } catch (RemoteException rE) {
                e.ExceptionMessage(rE);
                return false;
            }
        }
        
        public String[][] Read()
        {
            try {
                String[][] list = soap.read();
                return list;
            } catch(RemoteException rE)
            {
                e.ExceptionMessage(rE);
                return null;
            }
        }
}


