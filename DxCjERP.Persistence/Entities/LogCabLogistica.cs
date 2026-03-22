using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class LogCabLogistica
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

    [StringLength(15)]
    public string? IdSolicitud { get; set; }

    [StringLength(1000)]
    public string? ObsSolicitud { get; set; }

    [StringLength(50)]
    public string? Region { get; set; }

    [StringLength(50)]
    public string? Oc { get; set; }

    public int? IdZona { get; set; }

    [StringLength(250)]
    public string? NroGuia { get; set; }

    [StringLength(1500)]
    public string? Observacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraCreacion { get; set; }

    [StringLength(20)]
    public string? Usuario { get; set; }

    public int? IdSolicitante { get; set; }

    public int? IdEstado { get; set; }

    [Column("OT")]
    [StringLength(50)]
    public string? Ot { get; set; }

    [StringLength(750)]
    public string? NombreCliente { get; set; }

    [StringLength(550)]
    public string? NombreProyecto { get; set; }

    [StringLength(150)]
    public string? NombreTrabajo { get; set; }
}
