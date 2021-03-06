using Dapper;
using Dapper.Contrib.Extensions;
using Lab.Entity.Implementation;
using Lab.Repository.Interface;
using MySqlConnector;

namespace Lab.Repository.Implementation
{
    public class TransportePessoalRepository : ITransportePessoalRepository
    {
        private readonly IDbFactory _dbFactory;

        public TransportePessoalRepository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public void Inserir(TransportePessoal transportePessoal)
        {
            using (MySqlConnection connection = new MySqlConnection(_dbFactory.stringConexao()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string Base = $"Insert into TransporteBase (ano) values (@AnoFabricacao); SELECT last_insert_id();";
                        string Filho = "insert into TransportePessoal (IdTransporteBase, tipo) values (@idTransporteBase, @Tipo);";

                        var idTransporteBase = connection.ExecuteScalar<int>(Base, transportePessoal, transaction);

                        transportePessoal.idTransporteBase = idTransporteBase;

                        var arows = connection.Execute(Filho, transportePessoal, transaction);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
                connection.Clone();
            }
        }
    }
}