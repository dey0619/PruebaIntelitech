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

    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.DetalleFacturas = new HashSet<DetalleFacturas>();
        }



        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }

        [Display(Name = "Codigo")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Codigo { get; set; }

        [Display(Name = "Nombre producto")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string NombreProducto { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }

        [Display(Name = "Estado")]
        public bool Estado { get; set; }
        [Display(Name = "Precio")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public Nullable<decimal> Precio { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFacturas> DetalleFacturas { get; set; }
    }
}