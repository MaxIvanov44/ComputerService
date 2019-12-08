using Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LGS
    {
        public static void CurrentID(string log, string pas) //current transport
        {
            Model1 db = new Model1();
            //securitycontext.CurrentOrder = id;
            securitycontext1.CurrentID = db.Clients.Where(tr => tr.username == log && tr.password == pas).FirstOrDefault().id_user;
        }
        public static Clients GetCurrentID() // get current trasport
        {
            Model1 db = new Model1();

            //return db.Orders.Find(securitycontext.CurrentOrder);
            return db.Clients.Find(securitycontext1.CurrentID);
            //return db.Clients.Where(tr => tr.id_user == securitycontext.CurrentOrder).FirstOrDefault();
        }



    }
}
