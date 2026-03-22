using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Table("pla_Evidencia")]
public partial class PlaEvidencia
{
    [Key]
    [Column("EvidenciaID")]
    public int EvidenciaId { get; set; }

    [Column("SegmentoID")]
    public int SegmentoId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    public bool EsObligatoria { get; set; }

    public int Orden { get; set; }

    [InverseProperty("Evidencia")]
    public virtual ICollection<PlantillaImagenes> PlantillaImagenes { get; set; } = new List<PlantillaImagenes>();

    [ForeignKey("SegmentoId")]
    [InverseProperty("PlaEvidencia")]
    public virtual PlaSegmento Segmento { get; set; } = null!;
}
