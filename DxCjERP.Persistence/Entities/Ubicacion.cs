using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class Ubicacion
{
    [Key]
    public int NroInterno { get; set; }

    [StringLength(20)]
    public string Nombreubicacion { get; set; } = null!;

    [StringLength(250)]
    public string? Direccion { get; set; }

    [StringLength(250)]
    public string? Referencia { get; set; }

    [Column("fechacreacion", TypeName = "datetime")]
    public DateTime Fechacreacion { get; set; }

    [Column("usuarioCreacion")]
    [StringLength(11)]
    public string? UsuarioCreacion { get; set; }
}
