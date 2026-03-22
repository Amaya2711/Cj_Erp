using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class Material
{
    [Key]
    [StringLength(25)]
    public string CodPap { get; set; } = null!;

    [StringLength(250)]
    public string? NombreMaterial { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? CodEstado { get; set; }

    [StringLength(6)]
    public string? UnidadMedida { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaEliminar { get; set; }

    [StringLength(50)]
    public string? UsuarioDel { get; set; }
}
