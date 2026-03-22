using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("IdAuto", "PlantillaImagenId")]
public partial class PlantillaSeguimientoImagenes
{
    public int Id { get; set; }

    [Key]
    [Column("Id_Auto")]
    public int IdAuto { get; set; }

    [Key]
    [Column("PlantillaImagenID")]
    public int PlantillaImagenId { get; set; }

    [StringLength(1000)]
    public string? RutaImagen { get; set; }

    [StringLength(15)]
    public string? IdUsuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }
}
