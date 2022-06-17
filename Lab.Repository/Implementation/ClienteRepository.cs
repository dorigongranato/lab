using Dapper.Contrib.Extensions;
using Lab.Entity.Implementation;
using Lab.Repository.Interface;
using MySqlConnector;

namespace Lab.Repository.Implementation
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IDbFactory _dbFactory;

        public ClienteRepository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public List<Cliente> Listar()
        {
            using (MySqlConnection conexao = new MySqlConnection(_dbFactory.stringConexao()))
            {
                return conexao.GetAll<Cliente>().ToList();
            }

        }
    }
}

