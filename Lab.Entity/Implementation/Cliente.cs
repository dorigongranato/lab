using Dapper.Contrib.Extensions;

namespace Lab.Entity.Implementation
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}