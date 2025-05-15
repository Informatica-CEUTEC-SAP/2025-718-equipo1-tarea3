using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace BookStore.Application.Contracts.IBookCategoriaService;

public class CreateUpdateCategoriaDto
{
    [Required] 
    [StringLength(50)]
    public string Nombre { get; set; }
}

public class CategoriaDto : EntityDto<Guid>
{
  
    public string Nombre { get; set; }
}