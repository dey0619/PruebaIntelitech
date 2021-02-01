//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaIntelitech.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Empleados
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpleado { get; set; }

        [Display(Name = "Primer Nombre")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string PrimerNombre { get; set; }
        [Display(Name = "Segundo Nombre")]
        public string SegundoNombre { get; set; }

        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }

        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
           ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        public string Email { get; set; }
        public Nullable<int> Perfil { get; set; }
        public bool Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }

        [Display(Name = "Documento")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Documento { get; set; }
        public Nullable<int> TipoDocumento { get; set; }
    }
}
