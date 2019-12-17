using Database.EntityModels;
using System.Data;
using System.Linq;

namespace Logic.LogicModels
{
    public class LogicManagers
    {
        public static void CurrentManager(int id)
        {
            Model1 db = new Model1();
            GETMANAGERID.CurrentManager = id;
        }

        public static Managers GetCurrentManager()
        {
            Model1 db = new Model1();
            return db.Managers.Find(GETMANAGERID.CurrentManager);
        }

        public static DataTable GetAllManagers()
        {
            Model1 db = new Model1();

            DataTable dtord = new DataTable();
            dtord.Columns.Add("ID");
            dtord.Columns.Add("Фамилия");
            dtord.Columns.Add("Имя");
            dtord.Columns.Add("Отчество");
            dtord.Columns.Add("Телефон");
            dtord.Columns.Add("E-mail");
            dtord.Columns.Add("Адрес");
            dtord.Columns.Add("Серия паспорта");
            dtord.Columns.Add("Номер паспорта");

            var data = from m in db.Managers
                       select new
                       {
                           ID = m.id_manager,
                           F = m.last_name,
                           I = m.first_name,
                           O = m.middle_name,
                           Phone = m.phone,
                           email = m.email,
                           addr = m.address,
                           ser = m.serial_passport,
                           nom = m.number_passport
                       };

            foreach (var dt in db.Managers)
            {
                dtord.Rows.Add(dt.id_manager, dt.first_name, dt.last_name, dt.middle_name, dt.phone, dt.email, dt.address, dt.serial_passport, dt.number_passport);
            }
            return dtord;
        }
    }
}