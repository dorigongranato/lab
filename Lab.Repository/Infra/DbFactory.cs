using Lab.Repository.Interface;
using Microsoft.Extensions.Configuration;

namespace Lab.Repository.Infra
{
    public class DbFactory : IDbFactory
    {
        private IConfiguration _configuracoes;

        public DbFactory(IConfiguration configuracoes)
        {
            _configuracoes = configuracoes;
        }

        public string stringConexao()
        {
            return _configuracoes.GetSection("Connection").Value;
        }
    }
}

