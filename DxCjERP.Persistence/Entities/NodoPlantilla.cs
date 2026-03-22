using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class NodoPlantilla
{
    [Key]
    public int IndNodo { get; set; }

    [Column("NodoID")]
    public int NodoId { get; set; }

    [Column("PlantillaID")]
    public int PlantillaId { get; set; }

    [StringLength(10)]
    public string IdUsuario { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }
}
