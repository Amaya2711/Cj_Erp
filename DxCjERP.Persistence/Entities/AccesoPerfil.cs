using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("IdEmpleado", "Id", "IdUsuario", "IdPerfil", "IdArea")]
[Table("Acceso_Perfil")]
public partial class AccesoPerfil
{
    [Key]
    public int IdEmpleado { get; set; }

    [Key]
    public int Id { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    public int IdPerfil { get; set; }

    [Key]
    public int IdArea { get; set; }

    public int? IdEstado { get; set; }

    public int? IdEmpleadoCj { get; set; }
}
