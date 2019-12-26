using Database.EntityModels;
using System;
using System.Data;
using System.Linq;

namespace Logic
{
    public class LogicClient
    {
        public static int GetIdClient(string ID)
        {
            Model1 db = new Model1();
            string[] NameArray = new string[1];
            NameArray = ID.Split(' ');
            ID = NameArray[0];
            int IDD = Convert.ToInt32(ID);

            return db.Clients.Where(n => n.id_user == IDD).FirstOrDefault().id_user;
        }

        public static void CurrentClient(int id)
        {
            Model1 db = new Model1();
            GETCLIENTID.CurrentClient = id;
        }

        public static Clients GetCurrentClient()
        {
            Model1 db = new Model1();
            return db.Clients.Find(GETCLIENTID.CurrentClient);
        }

        public static DataTable GetAllClients()
        {
            Model1 db = new Model1();

            DataTable dtord = new DataTable();
            dtord.Columns.Add("ID");

            dtord.Columns.Add("Фамилия");
            dtord.Columns.Add("Имя");
            dtord.Columns.Add("Телефон");
            dtord.Columns.Add("E-mail");
            dtord.Columns.Add("Блокировка");
            var data = from Clients in db.Clients
                       select new
                       {
                           ID = Clients.id_user,
                           L = Clients.last_name,
                           F = Clients.first_name,
                           Phone = Clients.phone,
                           email = Clients.email,
                           block = Clients.block
                       };

            foreach (var dt in data)
            {
                dtord.Rows.Add(dt.ID, dt.L, dt.F, dt.Phone, dt.email, dt.block);
            }
            return dtord;
        }
    }
}