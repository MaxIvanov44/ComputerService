using Database.EntityModels;
using System;
using System.Windows;

namespace Database
{
    public class Adding
    {
        public static void AddCompl(int globalid, int count, int pc1, int pc2, int pc3, int pc4, int pc5, int pc6, int pc7, int pc8, int pc9)
        {
            string pc = "1";
            Model1 db = new Model1();
            for (int i = 0; i <= count; i++)
            {
                Details details = new Details
                {
                    Order = Convert.ToInt32(globalid),
                    Parts = Convert.ToInt32(pc + i),
                };
                db.Details.Add(details);
            }
            db.SaveChanges();

            MessageBox.Show("Комплектующие заказа сохранены!");
        }
    }
}