using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class EmpleadoAnt
{
    [Key]
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
}
