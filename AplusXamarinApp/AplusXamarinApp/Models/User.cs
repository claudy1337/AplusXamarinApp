using SQLite;
using AplusXamarinApp.Data;
using AplusXamarinApp.Page.InformationProjectPage;
using AplusXamarinApp.Page.SecondSprint;
using AplusXamarinApp.Page;
using AplusXamarinApp;

namespace AplusXamarinApp.Models

{
    [Table("user")]
    internal class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneOne { get; set; }
    }
}
