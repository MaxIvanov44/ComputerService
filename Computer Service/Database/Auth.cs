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
                foreach (var users in db.Masters)
                {
                    if (users.password == password && users.username == username)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

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
                foreach (var users in db.Clients)
                {
                    if (users.password == password && users.username == username)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

    }
}
