using Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Logic.LogicModels
{
    public class LogicOrders
    {

        public static void CurrentTransport(int idd)
        {
            Model1 db = new Model1();
            securitycontext.Order= db.Orders.Where(tr => tr.id_order == idd).FirstOrDefault().id_order;
        }

        public static Orders GetOrders()
        {
            Model1 db = new Model1();
            return db.Orders.Where(tr => tr.id_order == securitycontext.Order).FirstOrDefault();
        }
    }
}
