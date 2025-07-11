using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoRolesApi.Models
{
    [Table("RolesEstudiantes")] // Asegúrate que este nombre coincida con la tabla
    public class Rol
    {
        [Key]
        public int Id { get; set; }

        public string NombreCompleto { get; set; } = string.Empty;
    }
}
