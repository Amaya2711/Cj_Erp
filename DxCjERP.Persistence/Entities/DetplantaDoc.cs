using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
[Table("detplantaDoc")]
public partial class DetplantaDoc
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

    [StringLength(10)]
    public string NroSolicitud { get; set; } = null!;

    [StringLength(6)]
    public string Posicion { get; set; } = null!;

    [StringLength(50)]
    public string Correlativo { get; set; } = null!;

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hora { get; set; }

    public int? IdEstado { get; set; }

    [StringLength(500)]
    public string? Observacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCarga { get; set; }

    public int? IdRespCarga { get; set; }

    [StringLength(50)]
    public string? ImagenCarga { get; set; }
}
