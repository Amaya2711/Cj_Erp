using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class GastosWeb
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal IdCorrelativo { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProyecto { get; set; }

    [StringLength(8)]
    public string? IdSite { get; set; }

    public int? IdEmpleado { get; set; }

    [StringLength(15)]
    public string? Fecha { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Monto { get; set; }

    public int? Moneda { get; set; }
}
