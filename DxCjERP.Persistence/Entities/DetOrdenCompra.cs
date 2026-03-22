using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class DetOrdenCompra
{
    public int? IdOc { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProyecto { get; set; }

    [StringLength(8)]
    public string? IdSite { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Correlativo { get; set; }

    public int? IdTipoTrabajo { get; set; }

    public int? IdTarea { get; set; }

    [StringLength(50)]
    public string? TipoTrabajo { get; set; }

    [StringLength(2500)]
    public string? Detalle { get; set; }

    public int? Cantidad { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? PrecioUnitario { get; set; }

    [StringLength(10)]
    public string? UsuarioCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraCreacion { get; set; }

    [StringLength(10)]
    public string? Ot { get; set; }

    public int? IdAprobador1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaAprobador1 { get; set; }

    public int? IdAprobador2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaAprobador2 { get; set; }

    public int? IdAprobador3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaAprobador3 { get; set; }

    public int? IdComprobante { get; set; }

    public int? Fila { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? MontoAdela { get; set; }

    public int? IdEstado { get; set; }

    public int? IdGestor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaGestor { get; set; }

    [StringLength(250)]
    public string? ImgOc { get; set; }

    [StringLength(250)]
    public string? ImgPresupuesto { get; set; }
}
