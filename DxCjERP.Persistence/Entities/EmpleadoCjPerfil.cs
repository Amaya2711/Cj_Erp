using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("IdEmpleadoCj", "IdPerfil")]
public partial class EmpleadoCjPerfil
{
    [Key]
    public int IdEmpleadoCj { get; set; }

    [Key]
    public int IdPerfil { get; set; }

    public int? IdEstado { get; set; }

    public int? IdCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    public int? IdModificar { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaModificacion { get; set; }
}
