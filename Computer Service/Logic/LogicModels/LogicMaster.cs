using Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicMaster
    {
        public static List<string> GetNameMaster()
        {
            Model1 db = new Model1();
            var ListQuery = db.Masters;
            List<string> NameList = new List<string>();
            foreach (var name in ListQuery)
            {
                NameList.Add(name.id_master + " " + name.first_name + " " + name.last_name + " " + name.middle_name.ToString());
            }
            return NameList;
        }

        public static int GetIdMaster(string ID)
        {
            Model1 db = new Model1();
            string[] NameArray = new string[1];
            NameArray = ID.Split(' ');
            ID = NameArray[0];
            int IDD = Convert.ToInt32(ID);


            return db.Masters.Where(n => n.id_master == IDD).FirstOrDefault().id_master;
        }

        public static void CurrentMaster(int id)
        {
            Model1 db = new Model1();
            GETMASTERID.CurrentMaster = id;

        }
        public static Masters GetCurrentMaster()
        {
            Model1 db = new Model1();
            return db.Masters.Find(GETMASTERID.CurrentMaster);

        }

        public static DataTable GetAllMasters()
        {



            Model1 db = new Model1();

            DataTable dtord = new DataTable();
            dtord.Columns.Add("ID");

            dtord.Columns.Add("Ф");
            dtord.Columns.Add("И");
            dtord.Columns.Add("О");
            dtord.Columns.Add("Телефон");
            dtord.Columns.Add("E-mail");
            dtord.Columns.Add("Block");
            var data = from m in db.Masters
                       select new
                       {
                           ID = m.id_master,

                           F = m.last_name,
                           I = m.first_name,
                           O = m.middle_name,
                           addr = m.address,
                           Phone = m.phone,
                           email = m.email



                       };

            foreach (var dt in db.Masters)
            {
                dtord.Rows.Add(dt.id_master, dt.first_name, dt.last_name, dt.middle_name, dt.address, dt.phone, dt.email);
            }
            return dtord;

        }
    }
}
