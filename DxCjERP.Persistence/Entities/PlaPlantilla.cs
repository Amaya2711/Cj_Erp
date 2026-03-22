using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Table("pla_Plantilla")]
public partial class PlaPlantilla
{
    [Key]
    [Column("PlantillaID")]
    public int PlantillaId { get; set; }

    [Column("NodoID")]
    public int NodoId { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [ForeignKey("NodoId")]
    [InverseProperty("PlaPlantilla")]
    public virtual PlaNodoPrincipal Nodo { get; set; } = null!;

    [InverseProperty("Plantilla")]
    public virtual ICollection<PlaSegmento> PlaSegmento { get; set; } = new List<PlaSegmento>();

    [InverseProperty("Plantilla")]
    public virtual ICollection<PlantillaImagenes> PlantillaImagenes { get; set; } = new List<PlantillaImagenes>();
}
