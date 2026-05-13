namespace WFM.Domain.Repositorio
{
    public interface IProxy
    {
        Task<T> Get<T>(string url);
    }
}
