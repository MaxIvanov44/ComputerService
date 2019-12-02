using Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicStatus
    {
        public static List<string> GetStatus()
        {
            Model1 db = new Model1();
            var ListQuery = db.Status;
            List<string> NameList = new List<string>();
            foreach (var st in ListQuery)
            {
                NameList.Add(st.status1.ToString());
            }
            return NameList;
        }

        public static int GetIdStatus(string name)
        {
            Model1 db = new Model1();

            return db.Status.Where(n => n.status1 == name).FirstOrDefault().id_status;
        }
    }
}
