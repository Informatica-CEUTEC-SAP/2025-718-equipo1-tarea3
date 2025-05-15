using AutoMapper;
using BookStore.Application.Contracts.IBookCategoriaService;
using BookStore.Bibliotecas;

namespace BookStore;

public class CategoriaApplicationAutoMapperProfile : Profile
{
    public CategoriaApplicationAutoMapperProfile()
    {
        CreateMap<CategoriaLibro, CategoriaDto>();
        CreateMap<CreateUpdateCategoriaDto, CategoriaLibro>();
    }
}