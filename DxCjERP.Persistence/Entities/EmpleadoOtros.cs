using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class EmpleadoOtros
{
    public int? IdEmpleadoCj { get; set; }

    public int? IdEstado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    public int? IdActivo { get; set; }

    public int? IdAutorizado { get; set; }

    public DateOnly? FechaAutorizado { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public DateOnly? FechaPre { get; set; }

    public DateOnly? FechaPrimera { get; set; }

    public int? IdPre { get; set; }

    public int? IdPrimera { get; set; }

    public int? IdGestor { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    public int? IdRechazo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRechazo { get; set; }

    public bool? Pagada { get; set; }
}
