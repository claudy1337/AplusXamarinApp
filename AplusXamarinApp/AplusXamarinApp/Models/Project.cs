using SQLite;

namespace AplusXamarinApp.Models
{
    [Table("Project")]
    internal class Project
    {
        [Table("project")]
        internal class User
        {
            [PrimaryKey, AutoIncrement, Column("_id")]
            public int Id { get; set; }
            public string ProjectName { get; set; }
            public string ProjectTitle { get; set; }
            public string ProjectPicture { get; set; }
            public int idUser { get; set; }
        }
    }
}
