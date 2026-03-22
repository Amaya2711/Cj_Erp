using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class Ubigeo
{
    [StringLength(6)]
    public string? CodUbigeo { get; set; }

    [StringLength(200)]
    public string? NombreUbigeo { get; set; }
}
