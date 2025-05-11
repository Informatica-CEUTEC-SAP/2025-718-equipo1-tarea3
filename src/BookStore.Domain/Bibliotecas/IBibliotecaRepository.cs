using System;
using Volo.Abp.Domain.Repositories;

namespace BookStore.Bibliotecas
{
    public interface IBibliotecaRepository : IRepository<Biblioteca, Guid>
    {
        
    }
}
