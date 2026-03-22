using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class CargaLogistica
{
    [Key]
    public Guid Correlativo { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProyecto { get; set; }

    [StringLength(8)]
    public string? IdSite { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? CorreSite { get; set; }

    public int? IdTipoTrabajo { get; set; }

    [StringLength(7)]
    public string? CodPro { get; set; }

    [StringLength(10)]
    public string? PedidoSap { get; set; }

    [StringLength(15)]
    public string? IdSolicitud { get; set; }

    [StringLength(1500)]
    public string? DescSite { get; set; }

    [StringLength(250)]
    public string? Solicitante { get; set; }

    public int? IdSolicitante { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantSolicitada { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantSap { get; set; }

    [StringLength(50)]
    public string? Centro { get; set; }

    [StringLength(50)]
    public string? Almacen { get; set; }

    [StringLength(50)]
    public string? Lote { get; set; }

    [StringLength(1500)]
    public string? Obs { get; set; }

    [StringLength(50)]
    public string? Region { get; set; }

    [StringLength(50)]
    public string? Oc { get; set; }

    [StringLength(15)]
    public string? Posicion { get; set; }

    [StringLength(15)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hora { get; set; }

    [StringLength(15)]
    public string? UsuarioTmp { get; set; }

    [StringLength(1250)]
    public string? Descripcion { get; set; }

    [StringLength(750)]
    public string? NombreCliente { get; set; }

    [StringLength(550)]
    public string? NombreProyecto { get; set; }

    [StringLength(150)]
    public string? NombreTrabajo { get; set; }
}
