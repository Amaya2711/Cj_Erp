using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("IdCuadrilla", "Idsite", "Corresite", "Fecha", "NroInterno", "Tipotrabajo")]
public partial class CuadrillaAsignacion
{
    [Key]
    [Column("id_cuadrilla")]
    public int IdCuadrilla { get; set; }

    [Key]
    [Column("idsite")]
    [StringLength(8)]
    public string Idsite { get; set; } = null!;

    [Key]
    [Column("corresite")]
    public int Corresite { get; set; }

    [Key]
    [Column("fecha")]
    [StringLength(15)]
    public string Fecha { get; set; } = null!;

    public int Estado { get; set; }

    [StringLength(15)]
    public string UsuarioCreacion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaCreacion { get; set; }

    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal NroInterno { get; set; }

    [Key]
    [Column("tipotrabajo")]
    [StringLength(250)]
    public string Tipotrabajo { get; set; } = null!;

    [Column("NodoID")]
    public int NodoId { get; set; }

    [Column("PlantillaID")]
    public int PlantillaId { get; set; }

    [Column("SegmentoID")]
    public int SegmentoId { get; set; }

    [Column("RutaPDF")]
    [StringLength(1000)]
    public string? RutaPdf { get; set; }

    [Column("ID_Auto")]
    public int IdAuto { get; set; }

    [Column("ID_Principal")]
    public bool IdPrincipal { get; set; }

    [StringLength(250)]
    public string Comentario { get; set; } = null!;
}
