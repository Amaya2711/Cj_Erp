using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class CuentaEmpleado
{
    public int? IdEmpleado { get; set; }

    [Column("idCargo")]
    public int? IdCargo { get; set; }

    public int? IdBanco { get; set; }

    [StringLength(50)]
    public string? Cuenta { get; set; }

    [StringLength(50)]
    public string? CuentaInter { get; set; }

    [StringLength(50)]
    public string? NombreCta { get; set; }

    [StringLength(50)]
    public string? UsuarioCreacion { get; set; }

    [StringLength(50)]
    public string? FechaCreacion { get; set; }

    public int? Estado { get; set; }
}
