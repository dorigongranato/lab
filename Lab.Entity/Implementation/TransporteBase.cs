using Dapper.Contrib.Extensions;

namespace Lab.Entity.Implementation
{
    [Table("TransporteBase")]
    public class TransporteBase
    {
        [Key]
        public int idTransporteBase { get; set; }
        public int AnoFabricacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }

}