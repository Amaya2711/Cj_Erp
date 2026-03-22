using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class MaterialStock
{
    [Key]
    [StringLength(25)]
    public string CodPap { get; set; } = null!;

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Stock { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Bloqueado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Disponible { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Solicitado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Aprobado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Despachado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Enviado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Campo { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Cruce { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Cierre { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Excedente { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Folio { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Culminadas { get; set; }

    public int? Usuario { get; set; }

    public DateOnly? Fecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hora { get; set; }

    public int? IdEstado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Recepcionado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Validado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Observada { get; set; }
}
