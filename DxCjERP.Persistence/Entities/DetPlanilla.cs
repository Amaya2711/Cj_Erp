using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
[Table("detPlanilla")]
public partial class DetPlanilla
{
    public int IdProyecto { get; set; }

    [StringLength(8)]
    public string IdSite { get; set; } = null!;

    public int IdTipoTrabajo { get; set; }

    public int IdTarea { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal Correlativo { get; set; }

    [StringLength(15)]
    public string? FecIngreso { get; set; }

    [Column(TypeName = "text")]
    public string? Detalle { get; set; }

    public int? IdResponsable { get; set; }

    public int IdCliente { get; set; }

    public int? IdBien { get; set; }

    public int? IdComprobante { get; set; }

    [Column("RUC")]
    [StringLength(11)]
    public string? Ruc { get; set; }

    [StringLength(250)]
    public string? Serie { get; set; }

    public int? IdTipoPago { get; set; }

    [StringLength(15)]
    public string? FecEmision { get; set; }

    public int? TipoMoneda { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Total { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Subtotal { get; set; }

    [Column("IGV", TypeName = "numeric(18, 2)")]
    public decimal? Igv { get; set; }

    public int? IdRendicion { get; set; }

    [StringLength(500)]
    public string? Observacion { get; set; }

    [StringLength(500)]
    public string? Comentario { get; set; }

    public int? IdSolicitante { get; set; }

    public int? IdGestor { get; set; }

    public int? IdValidador { get; set; }

    public int? IdEjecutor { get; set; }

    public int? IdTransferencia { get; set; }

    public int? IdBanco { get; set; }

    public int? IdMoneda2 { get; set; }

    public int? IdRendir { get; set; }

    [StringLength(15)]
    public string? FechaDeposito { get; set; }

    public int? IdRetencion { get; set; }

    [StringLength(250)]
    public string? Otro { get; set; }

    [StringLength(250)]
    public string? Otro2 { get; set; }

    [StringLength(250)]
    public string? Otro3 { get; set; }

    [StringLength(250)]
    public string? Otro4 { get; set; }

    public int? Estado { get; set; }

    public int? CorreSite { get; set; }

    [StringLength(15)]
    public string? FechaPropuesta { get; set; }

    public int? IdBancoCta { get; set; }

    [StringLength(100)]
    public string? Cuenta { get; set; }

    [StringLength(100)]
    public string? CuentaInter { get; set; }

    [StringLength(250)]
    public string? NombreCta { get; set; }

    [StringLength(150)]
    public string? NombreProyecto { get; set; }

    [StringLength(75)]
    public string? Site { get; set; }

    [Column("Tipo_Trabajo")]
    [StringLength(150)]
    public string? TipoTrabajo { get; set; }

    [StringLength(150)]
    public string? Tarea { get; set; }

    [StringLength(500)]
    public string? Responsable { get; set; }

    [StringLength(50)]
    public string? Cliente { get; set; }

    [StringLength(25)]
    public string? Bien { get; set; }

    [StringLength(25)]
    public string? Comprobante { get; set; }

    [StringLength(15)]
    public string? Pago { get; set; }

    [StringLength(15)]
    public string? Moneda { get; set; }

    [StringLength(50)]
    public string? Rendicion { get; set; }

    [StringLength(500)]
    public string? Solicitante { get; set; }

    [StringLength(500)]
    public string? Gestor { get; set; }

    [StringLength(500)]
    public string? Validador { get; set; }

    [StringLength(500)]
    public string? Ejecutor { get; set; }

    [StringLength(15)]
    public string? Transferencia { get; set; }

    [StringLength(50)]
    public string? Banco { get; set; }

    [StringLength(15)]
    public string? Moneda2 { get; set; }

    [StringLength(50)]
    public string? Rendir { get; set; }

    [StringLength(50)]
    public string? Retencion { get; set; }

    [StringLength(15)]
    public string? FechaAprobador { get; set; }

    [StringLength(50)]
    public string? Usuario { get; set; }

    [StringLength(15)]
    public string? FechaCreacion { get; set; }

    [StringLength(50)]
    public string? HoraCreacion { get; set; }

    [StringLength(50)]
    public string? Ot { get; set; }

    [StringLength(50)]
    public string? TipoPago { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? TipoCambio { get; set; }

    [StringLength(50)]
    public string? NroFactura { get; set; }

    public bool? IdUrgente { get; set; }

    public int? IdReAprobador { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaReAprobador { get; set; }

    public int? IdOc { get; set; }

    public int? Fila { get; set; }

    public int? IdTipoDoc { get; set; }

    [StringLength(50)]
    public string? ImgSustento { get; set; }

    [StringLength(50)]
    public string? ImgFactura { get; set; }

    public int? IdUsuarioFactura { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecImaFactura { get; set; }

    [StringLength(50)]
    public string? NroOperacion { get; set; }
}
