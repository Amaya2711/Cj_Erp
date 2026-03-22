using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class CabOrdenCompra
{
    [Key]
    public int IdOc { get; set; }

    public int? IdSolicitante { get; set; }

    public int? IdResponsable { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Subtotal { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Igv { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Total { get; set; }

    [StringLength(10)]
    public string? UsuarioCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraCreacion { get; set; }

    public int? IdMoneda { get; set; }

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

    public int? IdRechazador { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRechazado { get; set; }

    public int? IdEstado { get; set; }

    [StringLength(1000)]
    public string? Observacion { get; set; }

    public int? IdValidador { get; set; }

    public int? IdGestor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaGestor { get; set; }

    public int? IdFormaPago { get; set; }

    [Column("DiasPAgo")]
    public int? DiasPago { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Peso { get; set; }
}
