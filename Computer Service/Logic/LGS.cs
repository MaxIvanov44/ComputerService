using Database.EntityModels;
using System.Linq;

namespace Logic
{
    public class LGS
    {
        public static void CurrentID(string log, string pas)
        {
            Model1 db = new Model1();
            GetIdClient.CurrentID = db.Clients.Where(tr => tr.username == log && tr.password == pas).FirstOrDefault().id_user;
        }

        public static Clients GetCurrentID()
        {
            Model1 db = new Model1();
            return db.Clients.Find(GetIdClient.CurrentID);
        }
    }
}