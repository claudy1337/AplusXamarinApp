using SQLite;

namespace AplusXamarinApp.Models
{
    [Table("Project")]
    internal class Project
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
    }
}
