﻿using Database.EntityModels;
using System;
using System.Data;
using System.Linq;

namespace Logic
{
    public class LogicComputers
    {
        //public static List<string> GetMark()
        //{
        //    Model1 db = new Model1();
        //    var ListQuery = db.Computers;
        //    List<string> MarkList = new List<string>();
        //    foreach (var mark in ListQuery)
        //    {
        //        MarkList.Add(mark.id_comp + " " + mark.name + " " + mark.brand + " " + mark.model.ToString());
        //    }
        //    return MarkList;
        //}

        public static int GetIdMark(string ID)
        {
            Model1 db = new Model1();
            string[] NameArray = new string[1];
            NameArray = ID.Split(' ');
            ID = NameArray[0];
            int IDD = Convert.ToInt32(ID);

            return db.Computers.Where(m => m.id_comp == IDD).FirstOrDefault().id_comp;
        }

        public static void CurrentPC(int id)
        {
            Model1 db = new Model1();
            GETPCID.CurrentPC = id;
        }

        public static Computers GetCurrentPC()
        {
            Model1 db = new Model1();
            return db.Computers.Find(GETPCID.CurrentPC);
        }

        public static DataTable GetAllPC()
        {
            Model1 db = new Model1();

            DataTable dtord = new DataTable();
            dtord.Columns.Add("ID");

            dtord.Columns.Add("Наименование");
            dtord.Columns.Add("Брэнд");
            dtord.Columns.Add("Марка");
            dtord.Columns.Add("Проблема");
            dtord.Columns.Add("Описание");
            var data = from PC in db.Computers
                       select new
                       {
                           ID = PC.id_comp,
                           Name = PC.name,
                           br = PC.brand,
                           mark = PC.model,
                           problem = PC.problem,
                           des = PC.description
                       };

            foreach (var dt in db.Computers)
            {
                dtord.Rows.Add(dt.id_comp, dt.name, dt.brand, dt.model, dt.problem, dt.description);
            }
            return dtord;
        }



        public static DataTable filter(string text)
        {
            Model1 db = new Model1();
            DataTable dtord = new DataTable();
            dtord.Columns.Add("ID");
            dtord.Columns.Add("Наименование");
            dtord.Columns.Add("Брэнд");
            dtord.Columns.Add("Марка");
            dtord.Columns.Add("Проблема");
            dtord.Columns.Add("Описание");
            string[] NameArray = text.Split(' ');
            string filter = NameArray[0];
            var sort = from PC in db.Computers
                       where (PC.name.Contains(filter) || PC.brand.Contains(filter) || PC.model.Contains(filter))
                       select new
                       {
                           ID = PC.id_comp,
                           Name = PC.name,
                           br = PC.brand,
                           mark = PC.model,
                           problem = PC.problem,
                           des = PC.description
                       };
            foreach (var ins in sort)
            {
                dtord.Rows.Add(ins.ID, ins.Name, ins.br, ins.mark, ins.problem, ins.des);
            }
            return dtord;
        }
    }
}