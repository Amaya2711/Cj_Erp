using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class DocumentosMulta
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal? IdMulta { get; set; }

    public int? ContaDoc { get; set; }

    [StringLength(250)]
    public string? TxtDoc { get; set; }

    [StringLength(250)]
    public string? TxtOficio { get; set; }

    [StringLength(250)]
    public string? TxtImagen { get; set; }

    public int? IdTipo { get; set; }

    [StringLength(20)]
    public string? Usuario { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraCreacion { get; set; }

    public int? IdEstado { get; set; }
}
