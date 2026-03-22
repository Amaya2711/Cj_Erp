using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Table("Plantilla_Imagenes")]
public partial class PlantillaImagenes
{
    [Key]
    [Column("PlantillaImagenID")]
    public int PlantillaImagenId { get; set; }

    [Column("NodoID")]
    public int NodoId { get; set; }

    [Column("PlantillaID")]
    public int PlantillaId { get; set; }

    [Column("SegmentoID")]
    public int SegmentoId { get; set; }

    [Column("EvidenciaID")]
    public int EvidenciaId { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? RutaImagen { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? IdUsuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRegistro { get; set; }

    [ForeignKey("EvidenciaId")]
    [InverseProperty("PlantillaImagenes")]
    public virtual PlaEvidencia Evidencia { get; set; } = null!;

    [ForeignKey("NodoId")]
    [InverseProperty("PlantillaImagenes")]
    public virtual PlaNodoPrincipal Nodo { get; set; } = null!;

    [ForeignKey("PlantillaId")]
    [InverseProperty("PlantillaImagenes")]
    public virtual PlaPlantilla Plantilla { get; set; } = null!;

    [ForeignKey("SegmentoId")]
    [InverseProperty("PlantillaImagenes")]
    public virtual PlaSegmento Segmento { get; set; } = null!;
}
