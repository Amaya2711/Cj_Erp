using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class Version
{
    [Key]
    public int IdVersion { get; set; }

    [StringLength(50)]
    public string? NombreVersion { get; set; }

    [StringLength(50)]
    public string? FechaCreacion { get; set; }

    public bool? Estado { get; set; }
}
