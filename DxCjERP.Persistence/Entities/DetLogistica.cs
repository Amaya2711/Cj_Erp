using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("IdCliente", "IdProyecto", "IdSite", "CorreSite", "TipoTrabajo", "PedidoSap", "Posicion", "Correlativo")]
public partial class DetLogistica
{
    [Key]
    public int IdCliente { get; set; }

    [Key]
    public int IdProyecto { get; set; }

    [Key]
    [StringLength(8)]
    public string IdSite { get; set; } = null!;

    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal CorreSite { get; set; }

    [Key]
    [StringLength(50)]
    public string TipoTrabajo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    public string PedidoSap { get; set; } = null!;

    [Key]
    [StringLength(6)]
    public string Posicion { get; set; } = null!;

    [Key]
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

    public DateOnly? Fecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hora { get; set; }

    public int? IdEstado { get; set; }

    [StringLength(500)]
    public string? Observacion { get; set; }

    [StringLength(2500)]
    public string? Comentario { get; set; }

    public int? LinReg { get; set; }

    public int? NroEnvio { get; set; }

    public int? IdClienteOrigen { get; set; }

    public int? IdProyectoOrigen { get; set; }

    [StringLength(8)]
    public string? IdSiteOrigen { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? CorreSiteOrigen { get; set; }

    [StringLength(50)]
    public string? TipoTrabajoOrigen { get; set; }

    [StringLength(150)]
    public string? RutaImagen { get; set; }

    public bool? IdDespacho { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantRecepcion { get; set; }

    public DateOnly? FecIngreso { get; set; }

    [StringLength(50)]
    public string? Guia { get; set; }

    [StringLength(50)]
    public string? Guia2 { get; set; }

    public int? IdUbicacion { get; set; }

    public int? IdZonaAlmacen { get; set; }

    public DateOnly? FecIngreso2 { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantSolNew { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRecepcion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaSerie { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaValidacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaSolicitud { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaAprobar { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaDespacho { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaEnvio { get; set; }

    [StringLength(10)]
    public string? UsuarioMod { get; set; }

    public bool? Alm2025 { get; set; }

    public int? IdActivar { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaActivar { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantBloqueada { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantDisponible { get; set; }

    [StringLength(50)]
    public string? Region { get; set; }

    [Column("OC")]
    [StringLength(50)]
    public string? Oc { get; set; }
}
