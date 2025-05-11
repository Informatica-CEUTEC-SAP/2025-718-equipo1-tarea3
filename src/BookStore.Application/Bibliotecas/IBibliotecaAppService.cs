using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace BookStore.Bibliotecas
{
    public interface IBibliotecaAppService
    {
        
        Task<List<BibliotecaDto>> GetListAsync();

        
        Task<BibliotecaDto> GetAsync(Guid id);

        
        Task<BibliotecaDto> CreateAsync(CreateUpdateBibliotecaDto input);

        
        Task<BibliotecaDto> UpdateAsync(Guid id, CreateUpdateBibliotecaDto input);

        
        Task DeleteAsync(Guid id);
    }
}
