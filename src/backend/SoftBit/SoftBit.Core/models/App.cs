using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace SoftBit.Core.models
{
    public class App
    {
        [Key]
        public int Id {get;set;}
        //codigo para la columna de nombre de la aplicacion
        [Required(ErrorMessage="El nombre es necesario")]
        [StringLength(40, ErrorMessage="Ingrese el nombre de la aplicacion de una manera mas corta y entendible")]
        [DataType(DataType.Text, ErrorMessage="Debe ingresar una cadena de caracteres")]
         public string Aplicacion {get;set;}

        //codigo para la columna de Descripcion de la aplicacion
        [Required(ErrorMessage="La descripcion es necesaria")]
        [StringLength(40, ErrorMessage="Ingrese la descripcion de una manera mas corta y entendible")]
        [DataType(DataType.Text, ErrorMessage="Debe ingresar una cadena de caracteres")]
         public string Descripcion {get;set;}

         public virtual ICollection<Mensajes> Mensajes {get; set;}

    }
}