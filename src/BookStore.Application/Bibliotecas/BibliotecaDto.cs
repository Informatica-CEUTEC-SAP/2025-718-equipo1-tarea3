using System;
using Volo.Abp.Application.Dtos;

namespace BookStore.Bibliotecas
{
    public class BibliotecaDto : EntityDto<Guid>
    {
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Horario { get; set; }
        public bool EsVirtual { get; set; }
    }
}

