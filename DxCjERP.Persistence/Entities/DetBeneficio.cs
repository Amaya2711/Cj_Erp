using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class DetBeneficio
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal? IdBeneficio { get; set; }

    [StringLength(50)]
    public string? MesPago { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Monto { get; set; }

    public int? IdEstado { get; set; }

    public int? IdUsuarioPago { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaPago { get; set; }

    public int? IdActualizacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaActualizacion { get; set; }
}
