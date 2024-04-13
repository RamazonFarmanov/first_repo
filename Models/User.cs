using SQLite;

namespace Shell_App.Models
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, Column("id")]
        public int Id { get; set; }
        [MaxLength(25), Column("name")]
        public string Name { get; set; }
        [MaxLength(25), Column("password")]
        public string Password { get; set; }
        [Column("is_admin")]
        public bool Is_Admin { get; set; }
        [Column("is_active")]
        public bool Is_Active { get; set; }
    }
}
