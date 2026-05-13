
using System.Collections.Generic;
using System.Linq;
using WFM.Domain.Interface;

namespace WFM.Domain.Repositorio.Implementacao
{
    public class RepositorioEmMemoria : IRepositorio
    {
        private static long id = 100;

        public static Dictionary<string, List<object>> Dados = new Dictionary<string, List<object>>();

        public void Incluir(object obj)
        {
            var entidade = obj as IEntidade;
            
            entidade.Id = id++;

            GetList(obj).Add(obj);
        }

        public void Excluir(object model)
        {
            GetList(model).Remove(model);
        }

        public IQueryable<T> Consultar<T>()
        {
            var nomeEntidade = typeof(T).Name;
            if (!Dados.ContainsKey(nomeEntidade))
            {
                return new List<T>().AsQueryable();
            }
            return Dados[nomeEntidade]
                .Cast<T>()
                .AsQueryable();
        }

        public T ConsultarPorId<T>(long id)
        {
            var nomeEntidade = typeof(T).Name;
            if (!Dados.ContainsKey(nomeEntidade))
                return default;
            var entidade = Dados[nomeEntidade].
                FirstOrDefault(
                    e => (e as IEntidade).Id == id
                );
            return (T)entidade;
        }

        private List<object> GetList(object model)
        {
            var nomeEntidade = model.GetType().Name;
            if (!Dados.ContainsKey(nomeEntidade))
            {
                Dados[nomeEntidade] = new List<object>();
            }
            return Dados[nomeEntidade];
        }

    }
}
