using projeto_devops07.Context;
using projeto_devops07.Models;
using projeto_devops07.Repositories.Interfaces;

namespace projeto_devops07.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
