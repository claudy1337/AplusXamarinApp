using System;
using System.Text;
using System.Collections.Generic;
using SQLite;
using AplusXamarinApp.Models;
using AplusXamarinApp.Page.InformationProjectPage;
using AplusXamarinApp.Page.SecondSprint;
using AplusXamarinApp.Page;
using AplusXamarinApp;
using AplusXamarinApp.Data;

namespace AplusXamarinApp.Data
{
    internal class ProjectBD
    {
        SQLiteConnection database;
        public ProjectBD(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Project>();
        }
        public Project GetItem(int id)
        {
            return database.Get<Project>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Project>(id);
        }
        public int SaveItem(Project item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
        public IEnumerable<Project> GetItems()
        {
            return database.Table<Project>().ToList();
        }
    }
}
