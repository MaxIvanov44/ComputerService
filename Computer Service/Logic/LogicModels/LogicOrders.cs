using Database.EntityModels;
using System;
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

            foreach (var dt in db.Orders)
            {
                dtord.Rows.Add(dt.id_order, dt.order_status, dt.client, dt.computer, dt.master, dt.date_of_acceptance, dt.date_of_return, dt.repair_price, dt.description);
            }
            return dtord;
        }

        public static DataTable AllClientOrders(int id)
        {
            Model1 db = new Model1();

            DataTable dtord = new DataTable();
            dtord.Columns.Add("ID заказа");
            dtord.Columns.Add("Статус");
            dtord.Columns.Add("Наименование техники");
            dtord.Columns.Add("ФИО мастера");
            dtord.Columns.Add("Дата приема");
            dtord.Columns.Add("Дата возврата");
            dtord.Columns.Add("Цена");
            dtord.Columns.Add("Описание");
            var data = from Order in db.Orders
                       join Status in db.Status on Order.order_status equals Status.id_status
                       join Client in db.Clients on Order.client equals Client.id_user
                       join Master in db.Masters on Order.master equals Master.id_master
                       join Computers in db.Computers on Order.computer equals Computers.id_comp
                       where Order.client == id
                       select new
                       {
                           Id = Order.id_order,
                           Status = Status.status1,
                           PC = Computers.name + " - " + Computers.brand + " " + Computers.model,
                           Master = Master.first_name + Master.last_name + Master.middle_name,
                           DateAccept = Order.date_of_acceptance,
                           DateRepair = Order.date_of_return,
                           Price = Order.repair_price,
                           Descpription = Order.description
                       };

            foreach (var dt in db.Orders)
            {
                dtord.Rows.Add(dt.id_order, dt.order_status, dt.computer, dt.master, dt.date_of_acceptance, dt.date_of_return, dt.repair_price, dt.description);
            }
            return dtord;
        }

        public static void GetClientOrder(int id)
        {
            Model1 db = new Model1();

            MMM.mmm = id;


        }

        public static IQueryable GetClientOrder1()
        {
            Model1 db = new Model1();

            var data = from Order in db.Orders
                       join Client in db.Clients on Order.client equals Client.id_user
                       where Order.client == MMM.mmm
                       select new
                       {
                           client = Order.client
                       };
            
            return data;
        }


    }
}