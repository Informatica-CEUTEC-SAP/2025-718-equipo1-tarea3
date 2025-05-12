using Volo.Abp.Domain.Entities.Auditing;
using System;

namespace BookStore.Bibliotecas
{
    public class Biblioteca : FullAuditedAggregateRoot<Guid>
    {
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Horario { get; set; } = string.Empty;
        public bool EsVirtual { get; set; }

        public Biblioteca() { }

        public Biblioteca(string nombre, string direccion, string horario, bool esVirtual)
        {
            Nombre = nombre;
            Direccion = direccion;
            Horario = horario;
            EsVirtual = esVirtual;
        }
    }
}
