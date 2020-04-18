using System;
using System.Collections.Generic;
using System.Reflection;

namespace SharpeDiem
{
    class ModelHandler {

        public static PropertyInfo[] GetPropertyInfo(object source)
        {
            //Get the type of current object
            string type = source.GetType().ToString();
            //Get all property methods from object
            PropertyInfo[] fields = Type.GetType(type).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            return fields;

        }

        public List<string> DisplayObject(object obj)
        {
            List<string> data = new List<string>();
            PropertyInfo[] fields = GetPropertyInfo(obj);

            foreach(PropertyInfo field in fields)
            {
                data.Add(field.GetValue(obj, null).ToString());
            }

            return data;
            
        }
    }
}