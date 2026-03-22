using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class EmpleadoCjAdmLog
{
    public int IdEmpleado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InicioContrato { get; set; }

    public int Activo { get; set; }

    public int? CantMeses { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraCreacion { get; set; }

    [StringLength(10)]
    public string? UsuarioCreacion { get; set; }

    public int? IdEstado { get; set; }
}
