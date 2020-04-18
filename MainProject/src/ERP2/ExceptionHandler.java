package ERP2;
import java.rmi.RemoteException;
public class ExceptionHandler {

    public String exceptionMessage(RemoteException rE) {
        return rE.getMessage();
    }
    
    public String exceptionMessage(NullPointerException nE) {
        return "Please pick a table";
    }
    
    public String exceptionMessage(Exception e) {
        return e.getMessage();
    }
}



