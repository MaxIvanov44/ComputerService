using Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicComputers
    {
        public static List<string> GetMark()
        {
            Model1 db = new Model1();
            var ListQuery = db.Computers;
            List<string> MarkList = new List<string>();
            foreach (var mark in ListQuery)
            {
                MarkList.Add(mark.brand + " " + mark.model.ToString());
            }
            return MarkList;
        }

        public static int GetIdMark(string mark)
        {
            Model1 db = new Model1();
            string[] NameArray = new string[2];
            NameArray = mark.Split(' ');
            mark = NameArray[0];

            return db.Computers.Where(m => m.brand == mark).FirstOrDefault().id_comp;
        }
    }
}
