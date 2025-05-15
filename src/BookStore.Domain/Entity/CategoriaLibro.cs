using Volo.Abp.Domain.Entities.Auditing;
using System;

namespace BookStore.Bibliotecas;

public class CategoriaLibro : AuditedAggregateRoot<Guid>
{
    public string Nombre { get; set; }
    
    private CategoriaLibro() { }
    
    public CategoriaLibro(Guid id, string nombre) : base(id)
    {
        Nombre = nombre;
    }
}

