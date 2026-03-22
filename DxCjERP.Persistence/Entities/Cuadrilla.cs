using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Table("CUADRILLA")]
public partial class Cuadrilla
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    public int IdEmpleado { get; set; }

    [StringLength(250)]
    public string NombreCuadrilla { get; set; } = null!;

    [Column(TypeName = "decimal(10, 6)")]
    public decimal? Latitud { get; set; }

    [Column(TypeName = "decimal(10, 6)")]
    public decimal? Longitud { get; set; }

    public bool Activo { get; set; }
}
