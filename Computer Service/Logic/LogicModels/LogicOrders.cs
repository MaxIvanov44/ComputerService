using Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicOrders
    {
        public static void CurrentOrder(int id) //current transport
        {
            Model1 db = new Model1();
            securitycontext.CurrentOrder = id;
            //securitycontext.CurrentOrder = db.Orders.Where(tr => tr.id_order == id).FirstOrDefault().id_order;
        }
        public static Orders GetCurrentOrder() // get current trasport
        {
            Model1 db = new Model1();
            return db.Orders.Find(securitycontext.CurrentOrder);
           // return db.Orders.Where(tr => tr.id_order == securitycontext.CurrentOrder).FirstOrDefault();
        }

        public static DataTable GetAllOrders() //get transport list
        {



            Model1 db = new Model1();

            DataTable dtord = new DataTable();
            dtord.Columns.Add("ID");
            dtord.Columns.Add("статус");
            dtord.Columns.Add("клиент");
            dtord.Columns.Add("пк");
            dtord.Columns.Add("мастер");
            dtord.Columns.Add("принтие");
            dtord.Columns.Add("возврат");
            dtord.Columns.Add("цена");
            dtord.Columns.Add("описание");
            var data = from Order in db.Orders
                       join Status in db.Status on Order.order_status equals Status.id_status
                       join Client in db.Clients on Order.client equals Client.id_user
                       join Master in db.Masters on Order.master equals Master.id_master
                       join Computers in db.Computers on Order.computer equals Computers.id_comp
                       select new
                       {
                           Id = Order.id_order,
                           Status = Status.status1,
                           Client = Client.first_name + Client.last_name,
                           PC = Computers.brand + Computers.model,
                           Master = Master.first_name + Master.last_name + Master.middle_name,
                           DateAccept = Order.date_of_acceptance,
                           DateRepair = Order.date_of_return,
                           Price = Order.repair_price,
                           Descpription = Order.description

                       };

            foreach (var dt in db.Orders)
            {
                dtord.Rows.Add(dt.id_order, dt.order_status, dt.client, dt.computer, dt.master, dt.date_of_acceptance, dt.date_of_return, dt.repair_price, dt.description);
            }
            return dtord;

        }
    }
}
