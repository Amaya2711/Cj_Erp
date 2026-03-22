using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("CodPap", "CorrelativoInt", "Serie")]
public partial class MaterialSerie
{
    [Key]
    [StringLength(10)]
    public string CodPap { get; set; } = null!;

    [Key]
    public Guid CorrelativoInt { get; set; }

    [Key]
    [StringLength(50)]
    public string Serie { get; set; } = null!;

    [StringLength(10)]
    public string? PedidoSap { get; set; }

    [StringLength(6)]
    public string? IdSolicitud { get; set; }

    [StringLength(50)]
    public string? Correlativo { get; set; }

    public int? IdEstado { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hora { get; set; }
}
