﻿using System.ComponentModel.DataAnnotations;
namespace AppWeb601_Horacio.Models
{
    public class Producto
    {
        [Key]
        public int Id {  get; set; }
        [Required(ErrorMessage ="La descripcion es obligatoria")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El precio es obligatorio")]
        public int Precio { get; set; }
        [Required(ErrorMessage = "La cantidad es obligatoria")]
        public int Cantidad { get; set; }
    }
}
