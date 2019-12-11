using Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicClient
    {
        public static List<string> GetNameClient()
        {
            Model1 db = new Model1();
            var ListQuery = db.Clients;
            List<string> NameList = new List<string>();
            foreach (var name in ListQuery)
            {
                NameList.Add(name.id_user + " " + name.first_name + " " + name.last_name.ToString());
            }
            return NameList;
        }

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

            dtord.Columns.Add("Ф");
            dtord.Columns.Add("И");
            dtord.Columns.Add("Телефон");
            dtord.Columns.Add("E-mail");
            dtord.Columns.Add("Block");
            var data = from Clients in db.Clients
                       select new
                       {
                          ID = Clients.id_user,

                          F = Clients.last_name,
                          I = Clients.first_name ,
                          Phone = Clients.phone,
                          email = Clients.email,
                          block = Clients.block



                       };

            foreach (var dt in db.Clients)
            {
                dtord.Rows.Add(dt.id_user, dt.first_name, dt.last_name, dt.phone, dt.email, dt.block);
            }
            return dtord;

        }
    }
}
