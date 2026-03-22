using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("CodPap", "Correlativo", "CorrelaInt")]
[Table("Kardex_Material")]
public partial class KardexMaterial
{
    [Key]
    [StringLength(10)]
    public string CodPap { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string Correlativo { get; set; } = null!;

    [Key]
    public Guid CorrelaInt { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantSap { get; set; }

    [StringLength(1000)]
    public string? Observacion { get; set; }

    public int? CodKardex { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hora { get; set; }
}
