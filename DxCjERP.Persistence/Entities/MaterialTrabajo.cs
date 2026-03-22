using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class MaterialTrabajo
{
    [StringLength(10)]
    public string? CodPap { get; set; }

    [StringLength(10)]
    public string? TipoTrabajo { get; set; }

    public int? IdEstado { get; set; }
}
