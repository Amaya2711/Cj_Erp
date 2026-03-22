using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class LogDetLogistica
{
    public int IdCliente { get; set; }

    public int IdProyecto { get; set; }

    [StringLength(8)]
    public string IdSite { get; set; } = null!;

    [Column(TypeName = "numeric(18, 0)")]
    public decimal CorreSite { get; set; }

    [StringLength(50)]
    public string TipoTrabajo { get; set; } = null!;

    [StringLength(10)]
    public string PedidoSap { get; set; } = null!;

    [StringLength(6)]
    public string Posicion { get; set; } = null!;

    public Guid Correlativo { get; set; }

    [StringLength(50)]
    public string? Serie { get; set; }

    [StringLength(10)]
    public string? CodPap { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantSap { get; set; }

    [StringLength(20)]
    public string? Centro { get; set; }

    [StringLength(20)]
    public string? Almacen { get; set; }

    [StringLength(20)]
    public string? Lote { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hora { get; set; }

    public int? IdEstado { get; set; }

    [StringLength(500)]
    public string? Observacion { get; set; }

    [StringLength(2500)]
    public string? Comentario { get; set; }
}
