using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class EmpleadoCj
{
    public int IdEmpleado { get; set; }

    [StringLength(250)]
    public string NombreEmpleado { get; set; } = null!;

    [StringLength(3)]
    public string InicialesEmpleado { get; set; } = null!;

    public int IdCargo { get; set; }

    public int? IdDocumento { get; set; }

    [StringLength(11)]
    public string? NroDocumento { get; set; }

    [StringLength(50)]
    public string? Telefono { get; set; }

    [StringLength(200)]
    public string? Correo { get; set; }

    [StringLength(20)]
    public string? UsuarioCre { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    public int? IdEstado { get; set; }

    [StringLength(20)]
    public string? UsuarioDel { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaEliminar { get; set; }

    [StringLength(500)]
    public string? Direccion { get; set; }

    public int? IdTipoEmpleado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaIniLaboral { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaFinlaboral { get; set; }

    public bool? IdActivo { get; set; }

    public int? IdAptobeneficio { get; set; }

    public int? IdSexo { get; set; }

    public int? IdEmpRel { get; set; }

    [StringLength(15)]
    public string? NroAlterno { get; set; }

    public int? IdEstable { get; set; }

    public int? IdEmpleadoAnt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaBaja { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaVacaciones { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DiasVacMype { get; set; }
}
