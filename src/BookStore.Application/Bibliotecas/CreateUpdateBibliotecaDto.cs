using System.ComponentModel.DataAnnotations;

namespace BookStore.Bibliotecas
{
    public class CreateUpdateBibliotecaDto
    {
        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Direccion { get; set; }

        [Required]
        public string? Horario { get; set; }

        public bool EsVirtual { get; set; }
    }
}

