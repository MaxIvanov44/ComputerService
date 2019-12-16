using Database.EntityModels;
using System.Linq;

namespace Logic
{
    public class LGS
    {
        public static void CurrentID(string log, string pas) //current transport
        {
            Model1 db = new Model1();
            //securitycontext.CurrentOrder = id;
            GetIdClient.CurrentID = db.Clients.Where(tr => tr.username == log && tr.password == pas).FirstOrDefault().id_user;
        }

        public static Clients GetCurrentID() // get current trasport
        {
            Model1 db = new Model1();

            //return db.Orders.Find(securitycontext.CurrentOrder);
            return db.Clients.Find(GetIdClient.CurrentID);
            //return db.Clients.Where(tr => tr.id_user == securitycontext.CurrentOrder).FirstOrDefault();
        }
    }
}