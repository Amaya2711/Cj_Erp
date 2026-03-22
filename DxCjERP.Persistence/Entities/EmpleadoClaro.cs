using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class EmpleadoClaro
{
    [Key]
    public int IdEmpleadoClaro { get; set; }

    public int? IdCargoEmpleado { get; set; }

    [StringLength(250)]
    public string? NombreEmpleado { get; set; }
}
