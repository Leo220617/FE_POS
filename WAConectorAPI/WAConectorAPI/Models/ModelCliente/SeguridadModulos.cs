﻿ 
namespace WAConectorAPI.Models.ModelCliente
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SeguridadModulos")]
    public partial class SeguridadModulos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodModulo { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }
    }
}