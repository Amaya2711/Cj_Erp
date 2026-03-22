using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class EmpleadoEntrega
{
    public int? IdCliente { get; set; }

    public int? IdProyecto { get; set; }

    [StringLength(8)]
    public string? IdSite { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? CorreSite { get; set; }

    [StringLength(10)]
    public string? PedidoSap { get; set; }

    [StringLength(10)]
    public string? NroSolicitud { get; set; }

    public Guid? Correlativo { get; set; }

    public int? IdEmpleado { get; set; }
}
