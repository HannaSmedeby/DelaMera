using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    //Assignment 1
    [WebMethod]
    public String GetFile(string fileName)
    {
        string source = @"C:\Users\Administrator\Desktop\Assigntment2\";
        source += fileName;
        try
        {
            StreamReader sR = File.OpenText(source);

            String line = sR.ReadToEnd();
            return line;
        }
        catch (IOException io)
        {
            return "No file with this name exist";
        }
        catch (UnauthorizedAccessException uae)
        {
            return "Unauthorized access.";
        }
    }

    //Assignment 2
    [WebMethod]
    public DataTable GetItem()
    {
        string conStr = ConfigurationManager.ConnectionStrings["DatabaseProject"].ConnectionString;
        using (SqlConnection sqlCon = new SqlConnection(conStr))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Item", sqlCon))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable ds = new DataTable("Table Item");
                    da.Fill(ds);
                    return ds;
                }
            }
        }

    }

    [WebMethod]
    public DataTable GetLoan()
    {
        string conStr = ConfigurationManager.ConnectionStrings["DatabaseProject"].ConnectionString;
        using (SqlConnection sqlCon = new SqlConnection(conStr))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Loan", sqlCon))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable ds = new DataTable("Table Loan");
                    da.Fill(ds);
                    return ds;

                }
            }

        }
    }

   [WebMethod]
    public string GetItemForConsole()
    {
        ConnectionBase cB = new ConnectionBase();
        return cB.ItemQuery();
    }

    [WebMethod]
    public string GetLoanForConsole()
    {
        ConnectionBase cB = new ConnectionBase();
        return cB.LoanQuery();
    }
}
