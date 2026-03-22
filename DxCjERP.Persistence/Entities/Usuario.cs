using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class Usuario
{
    public int Id { get; set; }

    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [StringLength(10)]
    public string? Clave { get; set; }

    public int? IdEstado { get; set; }

    public int? IdEmpleado { get; set; }

    public int? IdCargo { get; set; }

    [StringLength(250)]
    public string? NombreDispositivo { get; set; }
}
