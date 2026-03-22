using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class EmpleadoCjDetalle
{
    public int? IdEmpleadoCj { get; set; }

    public int? IdEmpresaCj { get; set; }

    public int? IdClienteCj { get; set; }

    public int? IdAreaCj { get; set; }

    public int? IdUbicacionCj { get; set; }

    public int? IdResponsableCj { get; set; }

    public int? IdPrimerVacaciones { get; set; }

    public int? IdSegundoVacaciones { get; set; }

    public int? IdTerceroVacaciones { get; set; }

    public int? IdPrimeroOc { get; set; }

    public int? IdSegundoOc { get; set; }

    public int? IdTerceroOc { get; set; }
}
