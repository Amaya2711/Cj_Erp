using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Table("pla_NodoPrincipal")]
public partial class PlaNodoPrincipal
{
    [Key]
    [Column("NodoID")]
    public int NodoId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [InverseProperty("Nodo")]
    public virtual ICollection<PlaPlantilla> PlaPlantilla { get; set; } = new List<PlaPlantilla>();

    [InverseProperty("Nodo")]
    public virtual ICollection<PlantillaImagenes> PlantillaImagenes { get; set; } = new List<PlantillaImagenes>();
}
