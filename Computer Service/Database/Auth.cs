using Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Database
{
    public class Auth
    {

        public static bool authM(string username, string password)
        {
            Model1 db = new Model1();
            try
            {
                var admin = db.Masters.Where(a => a.username == username && a.password == password);
                if (admin.Count() == 1)
                {
                    return true;
                }
                else return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static bool authMan(string username, string password)
        {
            Model1 db = new Model1();
            try
            {
                var admin = db.Managers.Where(a => a.username == username && a.password == password);
                if (admin.Count() == 1)
                {
                    return true;
                }
                else return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static bool authA(string username, string password)
        {
            Model1 db = new Model1();
            try
            {
                var admin = db.Admin.Where(a => a.username == username && a.password == password);
                if (admin.Count() == 1)
                {
                    return true;
                }
                else return false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }


        public static bool authC(string username, string password)
        {
            Model1 db = new Model1();
            try
            {
                var client = db.Clients.Where(cl => cl.username == username && cl.password == password);
                if (client.Count() == 1)
                {
                    return true;
                }
                else return false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

    }
}
