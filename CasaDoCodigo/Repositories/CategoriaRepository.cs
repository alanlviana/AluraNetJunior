

using System.Linq;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories{
    public interface ICategoriaRepository{
        Categoria SalvarCategoria(string nomeCategoria);
    }

    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public Categoria SalvarCategoria(string nomeCategoria)
        {
            var categoria = dbSet.Where(c => c.Nome == nomeCategoria).SingleOrDefault();
            if (categoria == null){
                categoria = new Categoria(nomeCategoria);
                dbSet.Add(categoria);
                contexto.SaveChanges();
                return categoria;
            }
            return categoria;
        }
    }
}