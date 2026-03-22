using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("PedidoSap", "Correlativo", "Posicion", "IdEstado", "CorrelativoInt")]
public partial class MovMaterial
{
    [Key]
    [StringLength(10)]
    public string PedidoSap { get; set; } = null!;

    [Key]
    public Guid CorrelativoInt { get; set; }

    [Key]
    [StringLength(50)]
    public string Correlativo { get; set; } = null!;

    [Key]
    [StringLength(6)]
    public string Posicion { get; set; } = null!;

    [Key]
    public int IdEstado { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hora { get; set; }

    [StringLength(1000)]
    public string? Observacion { get; set; }

    [StringLength(10)]
    public string? CodPap { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantSap { get; set; }

    public int? IdSolicitante { get; set; }

    [StringLength(10)]
    public string? NroSolicitud { get; set; }

    public int? IdMovimiento { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProyecto { get; set; }

    [StringLength(8)]
    public string? IdSite { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? CorreSite { get; set; }

    [StringLength(50)]
    public string? TipoTrabajo { get; set; }
}
