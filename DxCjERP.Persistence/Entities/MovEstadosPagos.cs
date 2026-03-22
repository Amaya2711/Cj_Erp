using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class MovEstadosPagos
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Correlativo { get; set; }

    public int? Estado { get; set; }

    [StringLength(1500)]
    public string? Observacion { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraCreacion { get; set; }
}
