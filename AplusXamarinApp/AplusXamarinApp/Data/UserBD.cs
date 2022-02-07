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
    internal class UserBD
    {
        SQLiteConnection database;
        public UserBD(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<User>();
        }
        public User GetItem(int id)
        {
            return database.Get<User>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<User>(id);
        }
        public int SaveItem(User item)
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
        public IEnumerable<User> GetItems()
        {
            return database.Table<User>().ToList();
        }
    }
}
