using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[PrimaryKey("Idsolicitud", "OcPos")]
[Table("PORTAL")]
public partial class Portal
{
    [Key]
    [Column("OC_POS")]
    [StringLength(40)]
    public string OcPos { get; set; } = null!;

    [Key]
    [Column("IDSOLICITUD")]
    [StringLength(25)]
    public string Idsolicitud { get; set; } = null!;

    [Column("AREA_RESPONSABLE")]
    [StringLength(15)]
    public string? AreaResponsable { get; set; }

    [Column("ACCION")]
    [StringLength(50)]
    public string? Accion { get; set; }

    [Column("ANTIGUAMIENTO")]
    [StringLength(15)]
    public string? Antiguamiento { get; set; }

    [Column("PENDIENTE_DE")]
    [StringLength(50)]
    public string? PendienteDe { get; set; }

    [Column("CONTRATISTA")]
    [StringLength(75)]
    public string? Contratista { get; set; }

    [Column("NOMBRE")]
    [StringLength(75)]
    public string? Nombre { get; set; }

    [Column("ESTATUS PAP")]
    [StringLength(35)]
    public string? EstatusPap { get; set; }

    [Column("TIPO_PROYECTO")]
    [StringLength(100)]
    public string? TipoProyecto { get; set; }

    [Column("CODIGO_SITE")]
    [StringLength(25)]
    public string? CodigoSite { get; set; }

    [Column("NOMBRE_SITE")]
    [StringLength(50)]
    public string? NombreSite { get; set; }

    [Column("ESTADO_SITIO")]
    [StringLength(30)]
    public string? EstadoSitio { get; set; }

    [Column("F_ESTADO_SITIO")]
    public DateOnly? FEstadoSitio { get; set; }

    [Column("ESTADO_CENFILE")]
    [StringLength(25)]
    public string? EstadoCenfile { get; set; }

    [Column("F_CENFILE_APRUEBA")]
    public DateOnly? FCenfileAprueba { get; set; }

    [Column("CENFILE")]
    [StringLength(25)]
    public string? Cenfile { get; set; }

    [Column("ORDEN_COMPRA")]
    [StringLength(20)]
    public string? OrdenCompra { get; set; }

    [Column("POSICION_OC")]
    [StringLength(10)]
    public string? PosicionOc { get; set; }

    [Column("FECHA_SOLICITUD")]
    public DateOnly? FechaSolicitud { get; set; }

    [Column("SUPERVISOR_OYM_ASIGNADO")]
    [StringLength(50)]
    public string? SupervisorOymAsignado { get; set; }

    [Column("FECHA_VISITA")]
    public DateOnly? FechaVisita { get; set; }

    [Column("FECHA_PROGRAMACION")]
    public DateOnly? FechaProgramacion { get; set; }

    [Column("FECHA_LISTA_PEND")]
    public DateOnly? FechaListaPend { get; set; }

    [Column("FECHA_EMISION_PEND")]
    public DateOnly? FechaEmisionPend { get; set; }

    [Column("FECHA_LEV_OBS")]
    public DateOnly? FechaLevObs { get; set; }

    [Column("FECHA_EMISION_PAC")]
    public DateOnly? FechaEmisionPac { get; set; }

    [Column("JEFE_APROBADOR")]
    [StringLength(50)]
    public string? JefeAprobador { get; set; }

    [Column("FECHA_APR_JEFE")]
    public DateOnly? FechaAprJefe { get; set; }

    [Column("GERENTE_APROBADOR")]
    [StringLength(50)]
    public string? GerenteAprobador { get; set; }

    [Column("FECHA_APR_GTE")]
    public DateOnly? FechaAprGte { get; set; }

    [Column("SUB_DIRECTOS_APROBADOR")]
    [StringLength(50)]
    public string? SubDirectosAprobador { get; set; }

    [Column("FECHA_APR_SUB_DIR")]
    public DateOnly? FechaAprSubDir { get; set; }

    [Column("FECHA_EMISION_FAC")]
    public DateOnly? FechaEmisionFac { get; set; }

    [Column("JEFE_APR_FAC")]
    [StringLength(50)]
    public string? JefeAprFac { get; set; }

    [Column("FECHA_APR_JEFE_FAC")]
    public DateOnly? FechaAprJefeFac { get; set; }

    [Column("GTE_APR_FAC")]
    [StringLength(50)]
    public string? GteAprFac { get; set; }

    [Column("FECHA_APR_GTE_FAC")]
    public DateOnly? FechaAprGteFac { get; set; }

    [Column("SUB_DIR_APR_FAC")]
    [StringLength(50)]
    public string? SubDirAprFac { get; set; }

    [Column("FECHA_APR_SUB_DIR_FAC")]
    public DateOnly? FechaAprSubDirFac { get; set; }

    [Column("FECHA_OBS_SOL")]
    public DateOnly? FechaObsSol { get; set; }

    [Column("ESTADO_EA")]
    [StringLength(15)]
    public string? EstadoEa { get; set; }

    [Column("FECHA_ENVIO_SOLICITUD")]
    public DateOnly? FechaEnvioSolicitud { get; set; }

    [Column("FECHA_ENVIO_APROBACION")]
    public DateOnly? FechaEnvioAprobacion { get; set; }

    [Column("ESTADO_PROYECTO")]
    [StringLength(15)]
    public string? EstadoProyecto { get; set; }

    [Column("OBSERVACION")]
    [StringLength(250)]
    public string? Observacion { get; set; }

    [Column("DETALLE_OBS_SOL")]
    [StringLength(1000)]
    public string? DetalleObsSol { get; set; }

    [Column("ESTADO_OBS_SOL")]
    [StringLength(250)]
    public string? EstadoObsSol { get; set; }

    [Column("OC")]
    [StringLength(20)]
    public string? Oc { get; set; }

    [Column("POSICION")]
    [StringLength(10)]
    public string? Posicion { get; set; }

    [Column("MONTO_OC", TypeName = "numeric(18, 2)")]
    public decimal? MontoOc { get; set; }

    [Column("MONTO_LIQUIDADO", TypeName = "numeric(18, 2)")]
    public decimal? MontoLiquidado { get; set; }

    [Column("PORCENTAJE", TypeName = "numeric(18, 2)")]
    public decimal? Porcentaje { get; set; }

    [Column("MONEDA")]
    [StringLength(15)]
    public string? Moneda { get; set; }

    [Column("REGION")]
    [StringLength(15)]
    public string? Region { get; set; }

    [Column("SUP_CONSTRUCCION")]
    [StringLength(50)]
    public string? SupConstruccion { get; set; }

    [Column("STATUS_GIS")]
    [StringLength(25)]
    public string? StatusGis { get; set; }

    [Column("ESTADO_APROBACION")]
    [StringLength(15)]
    public string? EstadoAprobacion { get; set; }

    [Column("APLICA_PAC")]
    [StringLength(5)]
    public string? AplicaPac { get; set; }

    [Column("FEC_STAREGISTRO")]
    public DateOnly? FecStaregistro { get; set; }

    [Column("AUTO_ACEPTACION")]
    [StringLength(5)]
    public string? AutoAceptacion { get; set; }

    [Column("CONCEPTO")]
    [StringLength(250)]
    public string? Concepto { get; set; }

    [StringLength(150)]
    public string? Columna1 { get; set; }

    [StringLength(150)]
    public string? Columna2 { get; set; }

    [StringLength(150)]
    public string? Columna3 { get; set; }

    [StringLength(150)]
    public string? Columna4 { get; set; }

    [StringLength(150)]
    public string? Columna5 { get; set; }
}
