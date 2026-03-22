using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class CabMulta
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal? IdMulta { get; set; }

    [StringLength(6)]
    public string? CodUbigeo { get; set; }

    public int? IdLugar { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecEmision { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecRecepcion { get; set; }

    public int? IdTipDoc { get; set; }

    [StringLength(250)]
    public string? Referencia { get; set; }

    public int? IdCriticidad { get; set; }

    public int? IdDirigido { get; set; }

    public int? IdCliente { get; set; }

    public int? IdMedio { get; set; }

    [StringLength(250)]
    public string? Asunto { get; set; }

    public int? IdRecibido { get; set; }

    [StringLength(250)]
    public string? Observacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(11)]
    public string? UsuarioCreacion { get; set; }

    [StringLength(50)]
    public string? Imagen { get; set; }

    public int? IdEstado { get; set; }

    public int? IdRespLegal { get; set; }
}
