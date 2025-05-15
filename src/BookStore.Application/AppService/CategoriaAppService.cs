using System;
using BookStore.Application.Contracts.IBookCategoriaService;
using BookStore.Bibliotecas;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BookStore.AppService;

public class CategoriaAppService : CrudAppService<
CategoriaLibro,
CategoriaDto,
Guid,
PagedAndSortedResultRequestDto,
CreateUpdateCategoriaDto>,
    ICategoriaAppService
{
    public CategoriaAppService(IRepository<CategoriaLibro, Guid> repository) : base(repository)
    {
        
    }
    
}