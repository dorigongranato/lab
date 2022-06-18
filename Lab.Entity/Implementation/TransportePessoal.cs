using Dapper.Contrib.Extensions;

namespace Lab.Entity.Implementation
{
    [Table("TransportePessoal")]
    public class TransportePessoal : TransporteBase
    {
        [Key]
        public int idTransportePessoal { get; set; }

        public string Tipo { get; set; }
    }
}