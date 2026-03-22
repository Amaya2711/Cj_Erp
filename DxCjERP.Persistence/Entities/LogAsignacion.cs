using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
[Table("LogASignacion")]
public partial class LogAsignacion
{
    public int? IdCliente { get; set; }

    public int? IdProyecto { get; set; }

    [StringLength(8)]
    public string? IdSite { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? CorreSite { get; set; }

    [StringLength(50)]
    public string? TipoTrabajo { get; set; }

    [StringLength(50)]
    public string? Campo { get; set; }

    [StringLength(50)]
    public string? Valor { get; set; }

    [StringLength(10)]
    public string? IdUsuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(50)]
    public string? ValorNuevo { get; set; }

    [Column("ot")]
    [StringLength(10)]
    public string? Ot { get; set; }
}
