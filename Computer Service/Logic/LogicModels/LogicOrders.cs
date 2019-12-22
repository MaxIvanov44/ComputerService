using Database.EntityModels;
using System.Data;
using System.Linq;

namespace Logic
{
    public class LogicOrders
    {
        public static string c;
        public static string m;
        public static string pc;
        public static string st;
        public static string pr;
        public static string des;

        public static void CurrentOrder(int id)
        {
            Model1 db = new Model1();
            GETORDERID.CurrentOrder = id;
        }

        public static Orders GetCurrentOrder()
        {
            Model1 db = new Model1();
            return db.Orders.Find(GETORDERID.CurrentOrder);
        }

        public static DataTable GetAllOrders()
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

            foreach (var dt in data)
            {
                dtord.Rows.Add(dt.Id, dt.Status, dt.Client, dt.PC, dt.Master, dt.DateAccept, dt.DateRepair, dt.Price, dt.Descpription);
            }
            return dtord;
        }
    }
}