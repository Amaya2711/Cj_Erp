using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class UpdImportar
{
    [StringLength(50)]
    public string? Ot { get; set; }

    [StringLength(50)]
    public string? Cliente { get; set; }

    [StringLength(50)]
    public string? Proyecto { get; set; }

    [StringLength(8)]
    public string? IdSite { get; set; }

    [StringLength(250)]
    public string? TipoTrabajo { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? AnoGestion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hora { get; set; }

    public int? IdActualizar { get; set; }

    [StringLength(250)]
    public string? Site { get; set; }
}
