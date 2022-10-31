﻿ 
namespace WAConectorAPI.Models.ModelCliente
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Roles")]
    public partial class Roles
    {
        [Key]
        public int idRol { get; set; }

        [StringLength(50)]
        public string NombreRol { get; set; }
    }
}