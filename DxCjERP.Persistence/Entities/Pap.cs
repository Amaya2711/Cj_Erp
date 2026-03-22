using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
[Table("PAP")]
public partial class Pap
{
    [StringLength(50)]
    public string? OcPos { get; set; }

    [StringLength(50)]
    public string? IdSolicitud { get; set; }

    [Column("Status_Pap")]
    [StringLength(50)]
    public string? StatusPap { get; set; }

    [Column("Estado_Cenfile")]
    [StringLength(50)]
    public string? EstadoCenfile { get; set; }

    [Column("Estado_Ea")]
    [StringLength(50)]
    public string? EstadoEa { get; set; }

    [Column("Monto_Liquidado", TypeName = "numeric(18, 2)")]
    public decimal? MontoLiquidado { get; set; }

    [Column("Estado_aprobacion")]
    [StringLength(50)]
    public string? EstadoAprobacion { get; set; }
}
