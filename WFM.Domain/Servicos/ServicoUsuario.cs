using WFM.Domain.Repositorio;

namespace WFM.Domain.Servicos
{
    public class ServicoUsuario
    {
        private readonly IRepositorio _repo;
        private readonly IProxy _proxy;

        public ServicoUsuario(IRepositorio repo, IProxy proxy)
        {
            _repo = repo;
            _proxy = proxy;
        }
    }
}
