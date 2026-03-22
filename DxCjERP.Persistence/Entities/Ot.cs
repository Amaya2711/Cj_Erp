using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("Id", "Ot1", "StatusRni")]
[Table("OT")]
public partial class Ot
{
    [Key]
    [Column("OT")]
    [StringLength(50)]
    public string Ot1 { get; set; } = null!;

    [Key]
    [Column("ID")]
    [StringLength(15)]
    public string Id { get; set; } = null!;

    [Column("SITE")]
    [StringLength(50)]
    public string? Site { get; set; }

    [Column("STATUS_OT")]
    [StringLength(15)]
    public string? StatusOt { get; set; }

    [Column("CONTRATA_CONST")]
    [StringLength(50)]
    public string? ContrataConst { get; set; }

    [Column("ESTING")]
    [StringLength(15)]
    public string? Esting { get; set; }

    [Column("PLANO")]
    [StringLength(15)]
    public string? Plano { get; set; }

    [Column("VALMET")]
    [StringLength(15)]
    public string? Valmet { get; set; }

    [Column("STATUS_CW")]
    [StringLength(15)]
    public string? StatusCw { get; set; }

    [Key]
    [Column("STATUS_RNI")]
    [StringLength(15)]
    public string StatusRni { get; set; } = null!;
}
