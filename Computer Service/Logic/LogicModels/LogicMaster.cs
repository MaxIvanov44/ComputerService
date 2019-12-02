using Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicMaster
    {
        public static List<string> GetNameMaster()
        {
            Model1 db = new Model1();
            var ListQuery = db.Masters;
            List<string> NameList = new List<string>();
            foreach (var name in ListQuery)
            {
                NameList.Add(name.first_name + " " + name.last_name + " " + name.middle_name.ToString());
            }
            return NameList;
        }

        public static int GetIdMaster(string name)
        {
            Model1 db = new Model1();
            string[] NameArray = new string[2];
            NameArray = name.Split(' ');
            name = NameArray[0];
            return db.Masters.Where(n => n.first_name == name).FirstOrDefault().id_master;
        }
    }
}
