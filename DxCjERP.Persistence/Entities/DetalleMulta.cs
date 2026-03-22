using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class DetalleMulta
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal? IdMulta { get; set; }

    public int? IdMoneda { get; set; }

    public int? IdSolicitado { get; set; }

    public int? IdAtendido { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecRec { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecObj { get; set; }

    public int? IdGerencia { get; set; }

    public int? IdDireccion { get; set; }

    public int? IdContrata { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdEstado { get; set; }

    [StringLength(1000)]
    public string? TxtInfraccion { get; set; }

    [StringLength(1000)]
    public string? TxtMedida { get; set; }

    [StringLength(1000)]
    public string? TxtAfectacion { get; set; }

    [StringLength(1000)]
    public string? TxtConcepto { get; set; }

    [StringLength(1000)]
    public string? TxtLugar { get; set; }

    [StringLength(20)]
    public string? Usuario { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraCreacion { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? MontoMulta { get; set; }
}
