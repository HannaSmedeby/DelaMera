using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace WebApplication1
{


    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        WebApplication1.DAL.ERP1_DAL dal = new WebApplication1.DAL.ERP1_DAL();

        [WebMethod]
        public bool Create(string initials, string name, string lastName, string title, string address, string phoneNumber)
        {   
            return dal.Create(initials, name, lastName, title, address, phoneNumber);
        }

        [WebMethod]
        public bool Update(string id, string name, string lastName, string title, string address, string phoneNumber)
        {
            return dal.Update(id, name, lastName, title, address, phoneNumber);
        }

        [WebMethod]
        public bool Delete(string id)
        {
            return dal.Delete(id);
        }

        [WebMethod]
        public List<List<String>> Read()
        {
            return dal.Read();
        }


        [WebMethod]
        public List<String> Find(String id)
        {
            return dal.Find(id);
        }

    }
}
