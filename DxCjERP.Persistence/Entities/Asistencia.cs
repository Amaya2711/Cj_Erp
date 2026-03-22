using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("IdEmpleado", "FechaAsistencia", "IdEstado")]
public partial class Asistencia
{
    [Key]
    public int IdEmpleado { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime FechaAsistencia { get; set; }

    [Key]
    public int IdEstado { get; set; }

    [StringLength(250)]
    public string? Comentario { get; set; }

    public int? UsuarioCre { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    public int? UsuarioAct { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaActualizacion { get; set; }

    public int? Aprobado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaAprobado { get; set; }

    public int? IdAprobador { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hora { get; set; }

    [Column(TypeName = "decimal(9, 6)")]
    public decimal? Latitud { get; set; }

    [Column(TypeName = "decimal(9, 6)")]
    public decimal? Longitud { get; set; }

    public int EstadoMarcacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraSalida { get; set; }

    [Column(TypeName = "decimal(10, 8)")]
    public decimal? LatitudSalida { get; set; }

    [Column(TypeName = "decimal(11, 8)")]
    public decimal? LongitudSalida { get; set; }

    public int? EstadoSalida { get; set; }

    [Column("platform")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Platform { get; set; }

    [Column("app_devie_id")]
    public Guid? AppDevieId { get; set; }

    public int? Rechazado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRechazado { get; set; }

    public int? IdRechazador { get; set; }

    [StringLength(250)]
    public string? Imagen { get; set; }

    [StringLength(250)]
    public string? ImagenSalida { get; set; }
}
