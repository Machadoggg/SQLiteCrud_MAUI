using SQLite;
using System.ComponentModel.DataAnnotations.Schema;
using ColumnAttribute = SQLite.ColumnAttribute;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;

namespace SQLiteCrud_MAUI
{
    [Table("customer")]
    public class Customer
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("customer_name")]
        public string CustomerName { get; set; } = default!;

        [Column("mobile")]
        public string Mobile { get; set; } = default!;

        [Column("email")]
        public string Email { get; set; } = default!;

    }
}
