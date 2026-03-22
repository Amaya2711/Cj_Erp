using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class SolicitudEnvio
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

    [StringLength(850)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaEnvio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraEnvio { get; set; }

    [StringLength(50)]
    public string? NroGuia { get; set; }

    public int? IdAgencia { get; set; }

    [StringLength(250)]
    public string? NombreAgencia { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Monto { get; set; }

    public int? IdResponsable { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaEntrega { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaEnviado { get; set; }

    public int? Aplica { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRecojo { get; set; }

    [StringLength(50)]
    public string? Imagen { get; set; }

    public int? IdEstado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraCreacion { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }
}
