using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio
{
    public class Municipio
    {
        public int Id { get; set; }
        [Display(Name = "Nombre del municipio")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Nombre { get; set; }
    }
}

