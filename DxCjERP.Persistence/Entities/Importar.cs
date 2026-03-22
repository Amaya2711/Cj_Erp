using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class Importar
{
    [StringLength(50)]
    public string? OcPos { get; set; }

    [Column("OT")]
    [StringLength(50)]
    public string? Ot { get; set; }

    [Column("PAP")]
    [StringLength(20)]
    public string? Pap { get; set; }

    [StringLength(8)]
    public string? IdSite { get; set; }

    public int? Correlativo { get; set; }

    [StringLength(50)]
    public string? IdTipoTrabajo { get; set; }

    [StringLength(50)]
    public string? IdWork { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdZona { get; set; }

    [StringLength(50)]
    public string? IdEmpleado { get; set; }

    [StringLength(50)]
    public string? FecAsignacion { get; set; }

    [Column("MES")]
    [StringLength(50)]
    public string? Mes { get; set; }

    [Column("ANO")]
    [StringLength(50)]
    public string? Ano { get; set; }

    [Column("Estado_OC")]
    [StringLength(50)]
    public string? EstadoOc { get; set; }

    [Column("Nro_Oc")]
    [StringLength(50)]
    public string? NroOc { get; set; }

    [StringLength(50)]
    public string? Posicion { get; set; }

    [StringLength(50)]
    public string? FechaOc { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? MontoOc { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? MontoLiq { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? LiqPap { get; set; }

    [Column("ESTADO_EA")]
    [StringLength(15)]
    public string? EstadoEa { get; set; }

    [StringLength(50)]
    public string? FechaEa { get; set; }

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

    [Column("EA")]
    public int? Ea { get; set; }

    [Column("GIS_SMW")]
    [StringLength(50)]
    public string? GisSmw { get; set; }

    [Column("STATUS_PAP")]
    [StringLength(35)]
    public string? StatusPap { get; set; }

    [Column("Status_Fact")]
    [StringLength(50)]
    public string? StatusFact { get; set; }

    [StringLength(10)]
    public string? Mes2 { get; set; }

    [Column("Status_Cj")]
    [StringLength(50)]
    public string? StatusCj { get; set; }

    [StringLength(10)]
    public string? MesActivacion { get; set; }

    [StringLength(50)]
    public string? FecActivaPap { get; set; }

    [StringLength(50)]
    public string? FecActivaF { get; set; }

    [Column("Status_Gerencia")]
    [StringLength(70)]
    public string? StatusGerencia { get; set; }

    [StringLength(70)]
    public string? Gerencia2 { get; set; }

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

    [StringLength(75)]
    public string? Site { get; set; }

    [StringLength(250)]
    public string? TipoTrabajo { get; set; }

    [StringLength(250)]
    public string? Work { get; set; }

    [StringLength(50)]
    public string? Proyecto { get; set; }

    [StringLength(50)]
    public string? Zona { get; set; }

    [StringLength(50)]
    public string? Empleado { get; set; }

    [StringLength(50)]
    public string? Folio { get; set; }

    [StringLength(50)]
    public string? EaTxt { get; set; }

    [StringLength(50)]
    public string? FechaActivacion { get; set; }

    [Column("Folio_Ro")]
    [StringLength(50)]
    public string? FolioRo { get; set; }

    [StringLength(50)]
    public string? Corte { get; set; }

    [StringLength(50)]
    public string? Facturado { get; set; }

    public int? IdCliente { get; set; }

    [StringLength(50)]
    public string? Cliente { get; set; }

    [Column("Pext_Ro")]
    [StringLength(50)]
    public string? PextRo { get; set; }

    [Column("Folio_Roll_Pext")]
    [StringLength(50)]
    public string? FolioRollPext { get; set; }

    [Column("Pext_densi")]
    [StringLength(50)]
    public string? PextDensi { get; set; }

    [Column("Folio_densi_pext")]
    [StringLength(50)]
    public string? FolioDensiPext { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? NroInterno { get; set; }

    public int? IdEstado { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? AnoGestion { get; set; }

    public int? IdStatusClaro { get; set; }

    public int? IdActualizar { get; set; }

    [StringLength(50)]
    public string? StatusOt { get; set; }

    [StringLength(50)]
    public string? StatusOt2 { get; set; }

    public int? IdStatusOt { get; set; }

    public int? IdStatusOt2 { get; set; }

    [StringLength(50)]
    public string? Folio2 { get; set; }

    public int? IdFolio2 { get; set; }

    [StringLength(50)]
    public string? Capitalizacion { get; set; }

    public int? IdStatusCj { get; set; }

    [Column("ATP")]
    [StringLength(50)]
    public string? Atp { get; set; }

    [StringLength(50)]
    public string? PrePasivo { get; set; }

    [StringLength(50)]
    public string? Proyecto2 { get; set; }

    public int? IdPapAdm { get; set; }

    public int? IdPapTec { get; set; }

    [StringLength(25)]
    public string? DiasOn { get; set; }

    [StringLength(25)]
    public string? AntOn { get; set; }

    [Column("GERENCIA")]
    [StringLength(100)]
    public string? Gerencia { get; set; }
}
