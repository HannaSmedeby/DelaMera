package ERP1;

import java.rmi.RemoteException;

public class ExceptionHandler {
    
    public String ExceptionMessage(RemoteException re) 
    {
        return re.getMessage();
    }
}

