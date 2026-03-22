using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("Ot", "Pap", "IdSite", "Correlativo", "IdTipoTrabajo", "IdWork", "Posicion")]
public partial class Principal
{
    [Key]
    [Column("OT")]
    [StringLength(50)]
    public string Ot { get; set; } = null!;

    [Key]
    [Column("PAP")]
    [StringLength(20)]
    public string Pap { get; set; } = null!;

    [Key]
    [StringLength(8)]
    public string IdSite { get; set; } = null!;

    [Key]
    public int Correlativo { get; set; }

    [Key]
    [StringLength(50)]
    public string IdTipoTrabajo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string IdWork { get; set; } = null!;

    public int? IdProyecto { get; set; }

    public int? IdZona { get; set; }

    [StringLength(50)]
    public string? IdEmpleado { get; set; }

    public DateOnly? FecAsignacion { get; set; }

    [Column("MES", TypeName = "numeric(18, 0)")]
    public decimal? Mes { get; set; }

    [Column("ANO", TypeName = "numeric(18, 0)")]
    public decimal? Ano { get; set; }

    [Column("Estado_OC")]
    [StringLength(50)]
    public string? EstadoOc { get; set; }

    [Column("Nro_Oc")]
    [StringLength(50)]
    public string NroOc { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string Posicion { get; set; } = null!;

    [StringLength(50)]
    public string OcPos { get; set; } = null!;

    public DateOnly? FechaOc { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? MontoOc { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? MontoLiq { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? LiqPap { get; set; }

    [Column("ESTADO_EA")]
    [StringLength(15)]
    public string? EstadoEa { get; set; }

    public DateOnly? FechaEa { get; set; }

    [Column("TIEMPO_EA")]
    [StringLength(50)]
    public string? TiempoEa { get; set; }

    [Column("ANTIG_EA")]
    [StringLength(50)]
    public string? AntigEa { get; set; }

    [Column("CENFILE")]
    [StringLength(25)]
    public string? Cenfile { get; set; }

    [Column("STATUS_GIS")]
    [StringLength(25)]
    public string? StatusGis { get; set; }

    [Column("Status_Atp")]
    [StringLength(50)]
    public string? StatusAtp { get; set; }

    [Column("Status_Folio")]
    public int? StatusFolio { get; set; }

    [StringLength(750)]
    public string? Comentarios { get; set; }

    public int? IdEa { get; set; }

    [Column("GIS_SMW")]
    [StringLength(50)]
    public string? GisSmw { get; set; }

    [Column("STATUS_PAP")]
    [StringLength(35)]
    public string? StatusPap { get; set; }

    [Column("Status_Fact")]
    [StringLength(50)]
    public string? StatusFact { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Mes2 { get; set; }

    [Column("Status_Cj")]
    [StringLength(50)]
    public string? StatusCj { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? MesActivacion { get; set; }

    public DateOnly? FecActivaPap { get; set; }

    public DateOnly? FecActivaF { get; set; }

    [Column("Status_Gerencia", TypeName = "numeric(18, 0)")]
    public decimal? StatusGerencia { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Gerencia2 { get; set; }

    [Column("ESTING")]
    [StringLength(15)]
    public string? Esting { get; set; }

    [Column("PLANO")]
    [StringLength(15)]
    public string? Plano { get; set; }

    [Column("VALMET")]
    [StringLength(15)]
    public string? Valmet { get; set; }

    [Column("STATUS_CW")]
    [StringLength(15)]
    public string? StatusCw { get; set; }

    [Column("STATUS_RINI")]
    [StringLength(15)]
    public string? StatusRini { get; set; }

    [StringLength(50)]
    public string? StatusClaroMod { get; set; }

    [StringLength(50)]
    public string? FecActMod { get; set; }

    [StringLength(50)]
    public string? LiqMod { get; set; }

    [StringLength(50)]
    public string? FolioMod { get; set; }

    [Column("Status_Claro")]
    [StringLength(50)]
    public string? StatusClaro { get; set; }

    [Column("F_act_Real")]
    [StringLength(50)]
    public string? FActReal { get; set; }

    [Column("FOLIO_DENSI")]
    [StringLength(50)]
    public string? FolioDensi { get; set; }

    [Column("LIQ_DENSI")]
    [StringLength(50)]
    public string? LiqDensi { get; set; }

    [Column("Status_Ro")]
    [StringLength(50)]
    public string? StatusRo { get; set; }

    [StringLength(50)]
    public string? Liquidacion { get; set; }

    [StringLength(50)]
    public string? Ivan { get; set; }
}
