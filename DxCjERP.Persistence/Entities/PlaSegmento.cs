using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Table("pla_Segmento")]
public partial class PlaSegmento
{
    [Key]
    [Column("SegmentoID")]
    public int SegmentoId { get; set; }

    [Column("PlantillaID")]
    public int PlantillaId { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    public int Orden { get; set; }

    [InverseProperty("Segmento")]
    public virtual ICollection<PlaEvidencia> PlaEvidencia { get; set; } = new List<PlaEvidencia>();

    [ForeignKey("PlantillaId")]
    [InverseProperty("PlaSegmento")]
    public virtual PlaPlantilla Plantilla { get; set; } = null!;

    [InverseProperty("Segmento")]
    public virtual ICollection<PlantillaImagenes> PlantillaImagenes { get; set; } = new List<PlantillaImagenes>();
}
