using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("IdCuadrilla", "NroInterno", "Fecha", "Estado", "Tipotrabajo")]
public partial class CuadrillaSeguimiento
{
    [Key]
    [Column("id_cuadrilla")]
    public int IdCuadrilla { get; set; }

    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal NroInterno { get; set; }

    [Key]
    [Column("fecha")]
    [StringLength(15)]
    public string Fecha { get; set; } = null!;

    [Key]
    public int Estado { get; set; }

    [StringLength(15)]
    public string? UsuarioCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Key]
    [Column("tipotrabajo")]
    [StringLength(250)]
    public string Tipotrabajo { get; set; } = null!;
}
