using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

public partial class Cliente
{
    [Key]
    public int IdCliente { get; set; }

    [StringLength(50)]
    public string NombreCliente { get; set; } = null!;

    public int? Estado { get; set; }
}
