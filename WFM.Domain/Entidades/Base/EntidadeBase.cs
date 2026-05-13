using WFM.Domain.Interface;

namespace WFM.Domain.Entidades.Base
{
    public class EntidadeBase : IEntidade
    {
        public Guid Hash { get; set; } = new Guid();
        public long Id { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
