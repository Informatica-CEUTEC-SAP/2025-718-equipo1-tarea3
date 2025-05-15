using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BookStore.Application.Contracts.IBookCategoriaService;

public interface ICategoriaAppService : ICrudAppService<
    CategoriaDto,
    Guid,
PagedAndSortedResultRequestDto,
CreateUpdateCategoriaDto>
{
}