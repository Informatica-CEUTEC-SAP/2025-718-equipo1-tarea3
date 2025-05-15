using System.Threading.Tasks;
using BookStore.Application.Contracts.IBookCategoriaService;
using Shouldly;
using Xunit;

namespace BookStore.TESTS;

public class CategoriaAppService_tests : BookStoreApplicationTestBase<BookStoreApplicationTestModule>
{
    private readonly ICategoriaAppService _categoriaAppService;

    public CategoriaAppService_tests()
    {
        _categoriaAppService = GetRequiredService<ICategoriaAppService>();
    }

    [Fact]
    public async Task Should_Get_Categoria()
    {
        var result = await _categoriaAppService.CreateAsync(
            new CreateUpdateCategoriaDto { Nombre = "Aventura" });
        
        result.Nombre.ShouldBe("Aventura");
    }
    
}

