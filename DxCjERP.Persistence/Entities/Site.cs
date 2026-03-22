using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("Correlativo", "IdZona", "NombreSite", "IdSite")]
public partial class Site
{
    [Key]
    [StringLength(8)]
    public string IdSite { get; set; } = null!;

    [Key]
    [StringLength(75)]
    public string NombreSite { get; set; } = null!;

    [Key]
    public int IdZona { get; set; }

    [Key]
    public int Correlativo { get; set; }
}
