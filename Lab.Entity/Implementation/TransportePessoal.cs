using Dapper;
using Dapper.Contrib.Extensions;
using Lab.Entity.Interface;
using MySql.Data.MySqlClient;

namespace Lab.Entity.Implementation
{
    [Table("TransportePessoal")]
    public class TransportePessoal : TransporteBase, ITransporte
    {
        [Key]
        public int idTransportePessoal { get; set; }

        public string Tipo { get; set; }

        public string Inserir()
        {
            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;user=root;password=123456;database=lab"))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string Base = $"Insert into TransporteBase (ano) values (@AnoFabricacao); SELECT last_insert_id();";
                        string Filho = "insert into TransportePessoal (IdTransporteBase, tipo) values (@idTransporteBase, @Tipo);";

                        var idTransporteBase = connection.ExecuteScalar<int>(Base, this, transaction);

                        this.idTransporteBase = idTransporteBase;

                        var arows = connection.Execute(Filho, this, transaction);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;

                    }
                }
                connection.Clone();
                return "Transporte incluido com sucesso!";
            }
        }
    }
}