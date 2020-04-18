using System.Collections.Generic;
using System.Data;

namespace SharpeDiem
{
    public interface IModel
    {
        bool Create(string [] parameters);
        object Find(string id);
        bool Update(string id, string [] parameters);
        bool Remove(string id);
        string ToString();
        DataTable DisplayDataTable(string args);

        //string GenerateID();
    }

}
