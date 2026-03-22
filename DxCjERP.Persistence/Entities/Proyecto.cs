using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class Proyecto
{
    [Key]
    public int IdProyecto { get; set; }

    [StringLength(50)]
    public string NombreProyecto { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FechaInicio { get; set; }

    public bool? Estado { get; set; }
}
