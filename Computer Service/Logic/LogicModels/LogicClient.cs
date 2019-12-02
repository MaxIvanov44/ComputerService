using Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicClient
    {
        public static List<string> GetNameClient()
        {
            Model1 db = new Model1();
            var ListQuery = db.Clients;
            List<string> NameList = new List<string>();
            foreach (var name in ListQuery)
            {
                NameList.Add(name.first_name + " " +  name.last_name.ToString());
            }
            return NameList;
        }

        public static int GetIdClient(string name)
        {
            Model1 db = new Model1();
            string[] NameArray = new string[2];
            NameArray = name.Split(' ');
            name = NameArray[0];
           
            return db.Clients.Where(n => n.first_name == name).FirstOrDefault().id_user;
        }
    }
}
