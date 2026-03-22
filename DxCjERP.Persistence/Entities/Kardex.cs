using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class Kardex
{
    [Key]
    public Guid Idkardex { get; set; }

    public int? TipoMovimiento { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CantSap { get; set; }

    [StringLength(10)]
    public string? CodPap { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CantAnterior { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CantRestante { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ValorUnitario { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ValorTotal { get; set; }

    [StringLength(50)]
    public string? Referencia { get; set; }

    public int? Almacen { get; set; }

    [StringLength(2000)]
    public string? Observaciones { get; set; }

    public DateOnly? Fecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hora { get; set; }

    public int? IdEmpleadoCj { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProyecto { get; set; }

    [StringLength(10)]
    public string? IdSite { get; set; }

    public int? CorreSite { get; set; }

    [StringLength(50)]
    public string? TipoTrabajo { get; set; }

    [StringLength(20)]
    public string? Lote { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CantBloqueado { get; set; }

    public int? UsuarioBloqueo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaBloqueo { get; set; }

    [StringLength(50)]
    public string? NroSolicitud { get; set; }

    public int? IdEstado { get; set; }

    [StringLength(10)]
    public string? PedidoSap { get; set; }

    public int? FilaPedido { get; set; }

    public int? FilaSolicitud { get; set; }

    [StringLength(50)]
    public string? Serie { get; set; }
}
