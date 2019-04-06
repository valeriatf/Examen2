using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenParcial3.Models
{
    public enum Type
    {

        Conocido,
        Compañero_de_estudio,
        Colega_de_trabajo,
        amigo_de_infancia,
        pariente

    }
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }

        public string Name { get; set; }
        [Required]

        public Type Amigo { get; set; }

        public string Nickname { get; set; }

        public DateTime Fecha { get; set; }
    }
}