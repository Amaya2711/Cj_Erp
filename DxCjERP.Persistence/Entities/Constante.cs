using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("Correlativo", "Campo", "Programa", "Sociedad")]
public partial class Constante
{
    [Key]
    [StringLength(50)]
    public string Sociedad { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string Programa { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string Campo { get; set; } = null!;

    [Key]
    public int Correlativo { get; set; }

    [StringLength(50)]
    public string ValorIni { get; set; } = null!;

    [StringLength(50)]
    public string ValorFin { get; set; } = null!;

    [StringLength(150)]
    public string? Detalle { get; set; }

    [StringLength(250)]
    public string? Adicional { get; set; }
}
