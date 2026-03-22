using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class SeguimientoMulta
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal? IdMulta { get; set; }

    public int? ContaSeg { get; set; }

    public DateOnly? FecSeg { get; set; }

    [StringLength(1000)]
    public string? TxtSeg { get; set; }

    [StringLength(250)]
    public string? TxtImagen { get; set; }

    [StringLength(20)]
    public string? Usuario { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraCreacion { get; set; }
}
