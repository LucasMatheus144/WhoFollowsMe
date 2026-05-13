namespace WFM.Domain.Repositorio
{
    public interface IRepositorio
    {
        void Incluir(object obj);
        void Excluir(object model);
        T ConsultarPorId<T>(long id);
        IQueryable<T> Consultar<T>();
    }
}
