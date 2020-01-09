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

        public static int globalidorder;

        public static int count;

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

        public static DataTable GetAllOrdersbyID(int IDD)
        {
            Model1 db = new Model1();

            DataTable dtord = new DataTable();
            dtord.Columns.Add("ID");
            dtord.Columns.Add("Статус");
            dtord.Columns.Add("Клиент");
            dtord.Columns.Add("Дата принятия");
            dtord.Columns.Add("Дата возврата");
            dtord.Columns.Add("Стоимость");
            dtord.Columns.Add("Описание");
            var data = from Order in db.Orders
                       join Status in db.Status on Order.order_status equals Status.id_status
                       join Client in db.Clients on Order.client equals Client.id_user
                       join Master in db.Masters on Order.master equals Master.id_master
                       where Order.master == IDD
                       select new
                       {
                           Id = Order.id_order,
                           Status = Status.status1,
                           Client = Client.last_name + " " + Client.first_name,
                           Master = Master.last_name + " " + Master.first_name + " " + Master.middle_name,
                           DateAccept = Order.date_of_acceptance,
                           DateRepair = Order.date_of_return,
                           Price = Order.cost,
                           Descpription = Order.description
                       };

            foreach (var dt in data)
            {
                dtord.Rows.Add(dt.Id, dt.Status, dt.Client, dt.DateAccept, dt.DateRepair, dt.Price, dt.Descpription);
            }
            return dtord;
        }

        public static DataTable GetAllOrders()
        {
            Model1 db = new Model1();

            DataTable dtord = new DataTable();
            dtord.Columns.Add("ID");
            dtord.Columns.Add("Статус");
            dtord.Columns.Add("Клиент");
            dtord.Columns.Add("Мастер");
            dtord.Columns.Add("Дата принятия");
            dtord.Columns.Add("Дата возврата");
            dtord.Columns.Add("Стоимость");
            dtord.Columns.Add("Описание");
            var data = from Order in db.Orders
                       join Status in db.Status on Order.order_status equals Status.id_status
                       join Client in db.Clients on Order.client equals Client.id_user
                       join Master in db.Masters on Order.master equals Master.id_master

                       select new
                       {
                           Id = Order.id_order,
                           Status = Status.status1,
                           Client = Client.last_name + " " + Client.first_name,
                           Master = Master.last_name + " " + Master.first_name + " " + Master.middle_name,
                           DateAccept = Order.date_of_acceptance,
                           DateRepair = Order.date_of_return,
                           Price = Order.cost,
                           Descpription = Order.description
                       };

            foreach (var dt in data)
            {
                dtord.Rows.Add(dt.Id, dt.Status, dt.Client, dt.Master, dt.DateAccept, dt.DateRepair, dt.Price, dt.Descpription);
            }
            return dtord;
        }

        public static DataTable AllClientOrders(int id)
        {
            Model1 db = new Model1();

            DataTable dtord = new DataTable();
            dtord.Columns.Add("ID");
            dtord.Columns.Add("Статус");
            dtord.Columns.Add("Мастер");
            dtord.Columns.Add("Дата принятия");
            dtord.Columns.Add("Дата возврата");
            dtord.Columns.Add("Стоимость");
            dtord.Columns.Add("Описание");
            var data = from Order in db.Orders
                       join Status in db.Status on Order.order_status equals Status.id_status
                       join Client in db.Clients on Order.client equals Client.id_user
                       join Master in db.Masters on Order.master equals Master.id_master
                       where Order.client == id
                       select new
                       {
                           ID = Order.id_order,
                           Статус = Status.status1,
                           Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                           Дата_принятия = Order.date_of_acceptance,
                           Дата_возврата = Order.date_of_return,
                           Стоимость = Order.cost,
                           Описание = Order.description
                       };

            foreach (var dt in data)
            {
                dtord.Rows.Add(dt.ID, dt.Статус, dt.Мастер, dt.Дата_принятия, dt.Дата_возврата, dt.Стоимость, dt.Описание);
            }
            return dtord;
        }

        //public static DataTable Sort(string text)
        //{
        //    Model1 db = new Model1();

        //    DataTable dtord = new DataTable();
        //    dtord.Columns.Add("ID");
        //    dtord.Columns.Add("статус");
        //    dtord.Columns.Add("клиент");
        //    dtord.Columns.Add("пк");
        //    dtord.Columns.Add("мастер");
        //    dtord.Columns.Add("принтие");
        //    dtord.Columns.Add("возврат");
        //    dtord.Columns.Add("цена");
        //    dtord.Columns.Add("описание");
        //    var data = from Order in db.Orders
        //               join Status in db.Status on Order.order_status equals Status.id_status
        //               join Client in db.Clients on Order.client equals Client.id_user
        //               join Master in db.Masters on Order.master equals Master.id_master
        //               join Computers in db.Component on Order.id_order equals Computers.order
        //               where Computers.order == Order.id_order && Computers.name == text
        //               select new
        //               {
        //                   Id = Order.id_order,
        //                   Status = Status.status1,
        //                   Client = Client.first_name + Client.last_name,
        //                   PC = Computers.brand + Computers.model,
        //                   Master = Master.first_name + Master.last_name + Master.middle_name,
        //                   DateAccept = Order.date_of_acceptance,
        //                   DateRepair = Order.date_of_return,
        //                   Price = Order.cost_price,
        //                   Descpription = Order.description
        //               };

        //    foreach (var dt in data)
        //    {
        //        dtord.Rows.Add(dt.Id, dt.Status, dt.Client, dt.PC, dt.Master, dt.DateAccept, dt.DateRepair, dt.Price, dt.Descpription);
        //    }
        //    return dtord;
        //}
    }
}