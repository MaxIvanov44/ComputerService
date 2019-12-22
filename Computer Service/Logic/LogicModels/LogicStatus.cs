using Database.EntityModels;
using System.Collections.Generic;
using System.Linq;

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

        public static List<string> GetStatusMaster()
        {
            Model1 db = new Model1();
            var ListQuery = db.StatusMaster;
            List<string> NameList = new List<string>();
            foreach (var st in ListQuery)
            {
                NameList.Add(st.status.ToString());
            }
            return NameList;
        }

        public static List<string> GetStatusManager()
        {
            Model1 db = new Model1();
            var ListQuery = db.StatusManager;
            List<string> NameList = new List<string>();
            foreach (var st in ListQuery)
            {
                NameList.Add(st.status.ToString());
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