using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("IdEmpleado", "InicioContrato", "Activo")]
public partial class EmpleadoCjAdministracion
{
    [Key]
    public int IdEmpleado { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime InicioContrato { get; set; }

    [Key]
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
