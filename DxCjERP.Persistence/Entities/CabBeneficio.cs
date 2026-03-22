using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class CabBeneficio
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal? IdBeneficio { get; set; }

    public int? IdTipoBeneficio { get; set; }

    public int? IdEmpleado { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Monto { get; set; }

    public int? Meses { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MesInicio { get; set; }

    public int? IdAprobador { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaAprobador { get; set; }

    public int? IdRechazo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRechazo { get; set; }

    public int? IdCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    public int? IdEstado { get; set; }

    public bool? IdAprobado { get; set; }
}
